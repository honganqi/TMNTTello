using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Reflection;
using System.Net.Http;
using System.Threading.Tasks;
using System.Globalization;

namespace TMNT_Tello
{
    public partial class MainWindow : Form
    {
        string gameDir = "";
        string outputDir = "";
        string outputSameDir = "";
        Bitmap currentImage;
        List<string> filePaths = new();

        // internal variables
        Assembly imageAssembly = Assembly.GetExecutingAssembly();

        // window stuff
        public int initialWindowWidth;
        public int fullWindowWidth;
        public Point lastLocation;
        Instructions instructionsPanel;
        StartScreen startPanel;
        readonly ToolTip tooltip = new();

        // update stuff
        public bool updateAvailable = false;
        string updateurl = "https://raw.githubusercontent.com/honganqi/TMNTTello/main/latest.json";
        string downloadURL = "";

        public MainWindow()
        {
            InitializeComponent();

            instructionsPanel = new Instructions(this)
            {
                TopLevel = false,
                TopMost = true
            };
            startPanel = new StartScreen()
            {
                TopLevel = false,
                TopMost = true
            };

            Initialize();

            CheckUpdate(updateurl);
        }

        private void Initialize()
        {
            SetButtonImages();

            labelTitle.Text = Assembly.GetExecutingAssembly().GetName().Name;
            string currentVerString = Application.ProductVersion;
            List<string> currentVersionSplit = currentVerString.Split('.').ToList();
            if (currentVersionSplit[3] == "0") currentVersionSplit.RemoveAt(3);
            if (currentVersionSplit[2] == "0") currentVersionSplit.RemoveAt(2);
            labelVerNum.Text = "v" + string.Join(".", currentVersionSplit) + " by honganqi";

            if ((Properties.Settings.Default.gameDir != "") && Directory.Exists(Properties.Settings.Default.gameDir))
                gameDir = Properties.Settings.Default.gameDir;

            if ((Properties.Settings.Default.outputDir != "") && Directory.Exists(Properties.Settings.Default.outputDir))
                outputDir = Properties.Settings.Default.outputDir;

            if (Properties.Settings.Default.sameDir)
                chkSameDir.Checked = true;

            if (outputDir == "")
                tooltip.SetToolTip(btnExport, "");

            if (CheckGameDir())
            {
                SwitchTab("main");
            }
            else
            {
                SwitchTab("start");
            }
                
            CheckExportDir();
        }


        private Bitmap DecompressFile(string filename)
        {
            Stream inputStream = File.OpenRead(filename);
            Stream deflatedStream = new DeflateStream(inputStream, CompressionMode.Decompress, leaveOpen: false);

            Xnb xnb = new();
            xnb.Load(deflatedStream);

            // prepare the data for export to image
            XnbContentExport export = xnb.Content.Export;
            export.PrepareExport();

            // generate the image from the prepared export (duh, repeating myself)
            if (export.Data != null)
            {
                TelloImage image = new();
                image.ImageData = export;
                return image.GenerateImage();
            }
            else
            {
                MessageBox.Show("Invalid image in ZXNB file", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new Bitmap(1, 1);
            }

        }

        private void ExportFile(string _outputPath = null)
        {
            if (fileListBox.SelectedIndex != -1)
            {
                FileInfo fi = new(filePaths[fileListBox.SelectedIndex]);
                if (_outputPath == null)
                    _outputPath = chkSameDir.Checked ? fi.DirectoryName : outputDir;

                string filenameNoExt = Path.GetFileNameWithoutExtension(fi.Name);
                string outputFilename = Path.Combine(_outputPath, filenameNoExt + ".png");

                currentImage.Save(outputFilename, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Output File:\n" + filenameNoExt + ".png\n\nOutput Folder:\n" + _outputPath, "Image exported successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No file selected for export!", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ShowPreview(Bitmap image)
        {
            labelImagePreview.Text = "W: " + image.Width + "px\nH: " + image.Height + "px";
            if (image.Width > pictPreview.Width || image.Height > pictPreview.Height)
            {
                TelloImage imageObject = new();
                imageObject.Image = image;
                pictPreview.Image = imageObject.ResizeImage(pictPreview.Size);
            }
            else
            {
                pictPreview.Image = image;
            }
        }


        #region Updates
        public async void CheckUpdate(string url)
        {
            List<string> onlineVer = new();
            List<string> currentVer = new();
            var client = new HttpClient();
            var request = client.GetAsync(url);

            Task timeout = Task.Delay(3000);
            await Task.WhenAny(timeout, request);

            try
            {
                HttpResponseMessage response = request.Result;
                if (response.IsSuccessStatusCode)
                {
                    var page = response.Content.ReadAsStringAsync();
                    var queryResult = Newtonsoft.Json.JsonConvert.DeserializeObject<VersionClass>(page.Result);

                    if ((queryResult != null) && (queryResult.ReleaseDate != null))
                    {
                        DateTime releaseDate = DateTime.Parse(queryResult.ReleaseDate).ToUniversalTime();
                        string onlineVerString = queryResult.Version;
                        string currentVerString = Application.ProductVersion;
                        downloadURL = queryResult.DownloadURL;
                        if (onlineVerString.CompareTo(currentVerString) > 0)
                        {
                            List<string> versionSplit = onlineVerString.Split('.').ToList();
                            if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                            if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                            onlineVer.Add(string.Join(".", versionSplit));
                            onlineVer.Add(releaseDate.ToLocalTime().ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
                            btnUpdateNotif.Text = "v" + onlineVer[0] + " is now available!\nGET IT NOW!";
                            if (queryResult.Description != "")
                            {
                                ToolTip updateTooltip = new();
                                updateTooltip.SetToolTip(btnUpdateNotif, "Download from: " + queryResult.DownloadURL + "\n\n" + queryResult.Description);
                            }

                            versionSplit = new(currentVerString.Split('.').ToList());
                            if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                            if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                            currentVer.Add(string.Join(".", versionSplit));
                            currentVer.Add(releaseDate.ToLocalTime().ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
                            btnUpdateNotif.Show();
                        }
                    }
                }
                else
                {
                    switch (response.StatusCode)
                    {
                        case System.Net.HttpStatusCode.NotFound:
                            throw new Exception("The update file was not found on the server.");
                        case System.Net.HttpStatusCode.BadRequest:
                            throw new Exception("");
                        case System.Net.HttpStatusCode.InternalServerError:
                            throw new Exception("");
                        case System.Net.HttpStatusCode.MethodNotAllowed:
                            throw new Exception("");
                        case System.Net.HttpStatusCode.Forbidden:
                            throw new Exception("");
                    }
                }
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void GetUpdate()
        {
            if (downloadURL != "") System.Diagnostics.Process.Start(downloadURL);
        }

        #endregion

        #region Folder Stuff

        private void ListFolders(string gamepath)
        {
            tvFolders.Nodes.Clear();
            ListDirectory(tvFolders, gamepath);
        }

        private void GetZxnbFromFolder(DirectoryInfo dir)
        {
            FileInfo[] files = dir.GetFiles("*.zxnb", SearchOption.AllDirectories);
            foreach (FileInfo file in files)
            {
                fileListBox.Items.Add(file.Name);
                filePaths.Add(file.FullName);
            }
        }


        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            DirectoryInfo gameDirInfo = new(path);
            // Do not add the root directory to the tree because, why?
            // treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));

            foreach (var directory in gameDirInfo.GetDirectories())
            {
                // add to tree only if directory has ZXNB files
                FileInfo[] files = directory.GetFiles("*.zxnb", SearchOption.AllDirectories);
                if (files.Count() > 0)
                    tvFolders.Nodes.Add(CreateDirectoryNode(directory));
            }
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
            {
                // add to tree only if directory has ZXNB files
                FileInfo[] files = directory.GetFiles("*.zxnb", SearchOption.AllDirectories);
                if (files.Count() > 0)
                    directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            return directoryNode;
        }
        #endregion

        #region System Checks

        private bool CheckGameDir()
        {
            bool returnVal;
            if (gameDir != "")
            {
                filePaths = new();
                labelExportDisabled.Show();
                btnGameDir.BackColor = Color.Transparent;
                ListFolders(gameDir);
                returnVal = true;
            }
            else
            {
                btnGameDir.BackColor = Color.FromArgb(255, 120, 0, 0);
                returnVal = false;
            }
            return returnVal;
        }

        private void CheckExportDir()
        {
            if (chkSameDir.Checked)
            {
                labelExportDisabled.Hide();
                if (outputSameDir != "")
                    labelOutputDir.Text = outputSameDir;
                btnExport.Enabled = true;
            }
            else
            {
                if (outputDir != "")
                {
                    labelExportDisabled.Hide();
                    labelOutputDir.Text = outputDir;
                    btnExport.Enabled = true;
                    btnOutputDir.BackColor = Color.Transparent;
                }
                else
                {
                    btnOutputDir.BackColor = Color.FromArgb(255, 120, 0, 0);
                    labelOutputDir.Text = "";

                    if (gameDir != "")
                        labelExportDisabled.Show();
                    btnExport.Enabled = false;
                }
            }
            Properties.Settings.Default.sameDir = chkSameDir.Checked;
        }
        #endregion

        #region Window Stuff
        public void MoveWindow(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - lastLocation.X;
                int dy = e.Location.Y - lastLocation.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }

        public void SwitchTab(string target)
        {
            switch (target)
            {
                case "main":
                    if (gameDir != "")
                    {
                        panelOverlay.Hide();
                    }
                    else
                    {
                        SwitchTab("start");
                    }
                    
                    break;
                default:
                    Control targetPanel = null;
                    switch (target)
                    {
                        case "instructions":
                            if (!instructionsPanel.Visible)
                            {
                                panelOverlay.Controls.Clear();
                                panelOverlay.Controls.Add(instructionsPanel);
                                instructionsPanel.Show();
                            }
                            targetPanel = instructionsPanel;
                            break;
                        case "start":
                            if (!startPanel.Visible)
                            {
                                panelOverlay.Controls.Add(startPanel);
                                startPanel.Show();
                            }
                            targetPanel = startPanel;
                            break;
                    }
                    foreach (Control panel in panelOverlay.Controls)
                    {
                        if (panel == targetPanel)
                            break;
                        panelOverlay.Controls.Clear();
                        panelOverlay.Controls.Add(targetPanel);
                        targetPanel.Show();
                    }

                    panelOverlay.BringToFront();
                    panelOverlay.Show();

                    break;
            }
        }
        #endregion

        #region UI Design
        private void SetButtonImages()
        {
            Stream thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.bmc.png");
            Bitmap thumbBitmap = new Bitmap(thumbStream);
            imgBMCSupport.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.sflogo.png");
            thumbBitmap = new Bitmap(thumbStream);
            imgSF.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.youtube.png");
            thumbBitmap = new Bitmap(thumbStream);
            imgYoutube.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.twitch.png");
            thumbBitmap = new Bitmap(thumbStream);
            imgTwitch.Image = thumbBitmap;

            thumbStream = thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.open.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnGameDir.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.exit.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnClose.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.min.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnMinimize.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.help.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnInstructions.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.load.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnOutputDir.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.export.png");
            thumbBitmap = new Bitmap(thumbStream);
            btnExport.BackgroundImage = thumbBitmap;
        }
        #endregion

        #region Events
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitAsk = MessageBox.Show("Yeah?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitAsk == DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
            }
            else
            {
                e.Cancel = true;
            }
            //e.Cancel = (exitAsk == DialogResult.No);
            
        }

        private void btnGameDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new();
            if (gameDir != "")
                fbd.SelectedPath = gameDir;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                gameDir = fbd.SelectedPath;
                Properties.Settings.Default.gameDir = gameDir;
                if (CheckGameDir())
                {
                    SwitchTab("main");
                }
                else
                {
                    SwitchTab("start");
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            filePaths = new();
            fileListBox.Items.Clear();
            DirectoryInfo di = new(Path.Combine(gameDir, tvFolders.SelectedNode.FullPath));
            GetZxnbFromFolder(di);
        }

        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new();
            fbd.SelectedPath = outputDir;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                outputDir = fbd.SelectedPath;
                CheckExportDir();
                Properties.Settings.Default.outputDir = outputDir;
                Properties.Settings.Default.Save();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportFile();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileListBox.SelectedIndex != -1)
            {
                string filename = filePaths[fileListBox.SelectedIndex];
                outputSameDir = filename;
                currentImage = DecompressFile(filename);
                ShowPreview(currentImage);
            }
        }

        private void chkSameDir_CheckedChanged(object sender, EventArgs e)
        {
            CheckExportDir();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void PictContextMenu_Click(object sender, EventArgs e)
        {
            FileInfo fi = new(filePaths[fileListBox.SelectedIndex]);
            string filename = Path.GetFileNameWithoutExtension(fi.Name) + ".png";

            SaveFileDialog sfd = new();
            sfd.Filter = "PNG Image|*.png";
            sfd.Title = "Save PNG Image File";
            sfd.FileName = filename;
            if (chkSameDir.Checked)
            {
                sfd.InitialDirectory = fi.DirectoryName;
            }
            else
            if (outputDir != "")
            {
                sfd.InitialDirectory = outputDir;
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string outputPath = sfd.FileName;
                ExportFile(Path.GetDirectoryName(outputPath));
            }
        }

        private void pictPreview_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (pictPreview.Image != null))
            {
                ContextMenu cm = new();
                cm.MenuItems.Add("Export as...", new EventHandler(PictContextMenu_Click));
                pictPreview.ContextMenu = cm;
            }
        }

        private void imgBMCSupport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://buymeacoffee.com/honganqi");
        }

        private void imgYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/honganqi");
        }

        private void imgTwitch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitch.tv/honganqi");
        }

        private void imgSF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/tmnt-tello/");
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            SwitchTab("instructions");
        }

        private void btnUpdateNotif_Click(object sender, EventArgs e)
        {
            GetUpdate();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

    }

    class VersionClass
    {
        [Newtonsoft.Json.JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [Newtonsoft.Json.JsonProperty("version")]
        public string Version { get; set; }
        [Newtonsoft.Json.JsonProperty("download_url")]
        public string DownloadURL { get; set; }
        [Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; }
    }
}
