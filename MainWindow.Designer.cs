
namespace TMNT_Tello
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnExport = new System.Windows.Forms.Button();
            this.pictPreview = new System.Windows.Forms.PictureBox();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.labelImagePreview = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelVerNum = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tvFolders = new System.Windows.Forms.TreeView();
            this.btnGameDir = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelExportDisabled = new System.Windows.Forms.Label();
            this.panelOverlay = new System.Windows.Forms.Panel();
            this.labelOutputDir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSameDir = new System.Windows.Forms.CheckBox();
            this.panelSocials = new System.Windows.Forms.Panel();
            this.btnUpdateNotif = new System.Windows.Forms.Button();
            this.imgSF = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgTwitch = new System.Windows.Forms.PictureBox();
            this.imgYoutube = new System.Windows.Forms.PictureBox();
            this.imgBMCSupport = new System.Windows.Forms.PictureBox();
            this.labelSupport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictPreview)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelSocials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBMCSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(742, 393);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 26);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "      Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pictPreview
            // 
            this.pictPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictPreview.Location = new System.Drawing.Point(497, 59);
            this.pictPreview.Name = "pictPreview";
            this.pictPreview.Size = new System.Drawing.Size(327, 327);
            this.pictPreview.TabIndex = 5;
            this.pictPreview.TabStop = false;
            this.pictPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictPreview_MouseDown);
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.ItemHeight = 17;
            this.fileListBox.Location = new System.Drawing.Point(308, 59);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(183, 327);
            this.fileListBox.TabIndex = 7;
            this.fileListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelImagePreview
            // 
            this.labelImagePreview.AutoSize = true;
            this.labelImagePreview.Location = new System.Drawing.Point(494, 393);
            this.labelImagePreview.Name = "labelImagePreview";
            this.labelImagePreview.Size = new System.Drawing.Size(0, 17);
            this.labelImagePreview.TabIndex = 8;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(649, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 42;
            this.btnMinimize.Text = "̶̶";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(685, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.labelVerNum);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(110, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(721, 36);
            this.panelTop.TabIndex = 45;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // labelVerNum
            // 
            this.labelVerNum.AutoSize = true;
            this.labelVerNum.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerNum.ForeColor = System.Drawing.Color.White;
            this.labelVerNum.Location = new System.Drawing.Point(115, 13);
            this.labelVerNum.Name = "labelVerNum";
            this.labelVerNum.Size = new System.Drawing.Size(96, 13);
            this.labelVerNum.TabIndex = 44;
            this.labelVerNum.Text = "v1.0 by honganqi";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(97, 21);
            this.labelTitle.TabIndex = 41;
            this.labelTitle.Text = "TMNT Tello";
            // 
            // tvFolders
            // 
            this.tvFolders.Location = new System.Drawing.Point(116, 59);
            this.tvFolders.Name = "tvFolders";
            this.tvFolders.Size = new System.Drawing.Size(186, 327);
            this.tvFolders.TabIndex = 47;
            this.tvFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnGameDir
            // 
            this.btnGameDir.FlatAppearance.BorderSize = 0;
            this.btnGameDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGameDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameDir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameDir.ForeColor = System.Drawing.Color.White;
            this.btnGameDir.Location = new System.Drawing.Point(11, 10);
            this.btnGameDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGameDir.Name = "btnGameDir";
            this.btnGameDir.Size = new System.Drawing.Size(90, 90);
            this.btnGameDir.TabIndex = 11;
            this.btnGameDir.Text = "Game Folder";
            this.btnGameDir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGameDir.UseVisualStyleBackColor = true;
            this.btnGameDir.Click += new System.EventHandler(this.btnGameDir_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.FlatAppearance.BorderSize = 0;
            this.btnInstructions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Location = new System.Drawing.Point(11, 441);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(90, 90);
            this.btnInstructions.TabIndex = 40;
            this.btnInstructions.Text = "How-To";
            this.btnInstructions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOutputDir.FlatAppearance.BorderSize = 0;
            this.btnOutputDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOutputDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputDir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputDir.ForeColor = System.Drawing.Color.White;
            this.btnOutputDir.Location = new System.Drawing.Point(11, 345);
            this.btnOutputDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(90, 56);
            this.btnOutputDir.TabIndex = 43;
            this.btnOutputDir.Text = "Output Folder";
            this.btnOutputDir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(21, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 2);
            this.label3.TabIndex = 52;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.btnOutputDir);
            this.panelLeft.Controls.Add(this.btnInstructions);
            this.panelLeft.Controls.Add(this.btnGameDir);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(110, 540);
            this.panelLeft.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Folder Browser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "ZXNB files in folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 91;
            this.label6.Text = "Preview";
            // 
            // labelExportDisabled
            // 
            this.labelExportDisabled.AutoSize = true;
            this.labelExportDisabled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExportDisabled.ForeColor = System.Drawing.Color.Red;
            this.labelExportDisabled.Location = new System.Drawing.Point(591, 392);
            this.labelExportDisabled.Name = "labelExportDisabled";
            this.labelExportDisabled.Size = new System.Drawing.Size(149, 39);
            this.labelExportDisabled.TabIndex = 2;
            this.labelExportDisabled.Text = "Set an Output Folder or\r\ntick \"Same folder\" to enable\r\nthe \"Export\" button\".";
            this.labelExportDisabled.Visible = false;
            // 
            // panelOverlay
            // 
            this.panelOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOverlay.Location = new System.Drawing.Point(0, 0);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.Size = new System.Drawing.Size(831, 540);
            this.panelOverlay.TabIndex = 93;
            this.panelOverlay.Visible = false;
            // 
            // labelOutputDir
            // 
            this.labelOutputDir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputDir.Location = new System.Drawing.Point(119, 409);
            this.labelOutputDir.Name = "labelOutputDir";
            this.labelOutputDir.Size = new System.Drawing.Size(375, 53);
            this.labelOutputDir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Export Destination Folder:";
            // 
            // chkSameDir
            // 
            this.chkSameDir.AutoSize = true;
            this.chkSameDir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSameDir.Location = new System.Drawing.Point(742, 422);
            this.chkSameDir.Name = "chkSameDir";
            this.chkSameDir.Size = new System.Drawing.Size(87, 17);
            this.chkSameDir.TabIndex = 10;
            this.chkSameDir.Text = "Same folder";
            this.chkSameDir.UseVisualStyleBackColor = true;
            this.chkSameDir.CheckedChanged += new System.EventHandler(this.chkSameDir_CheckedChanged);
            // 
            // panelSocials
            // 
            this.panelSocials.Controls.Add(this.btnUpdateNotif);
            this.panelSocials.Controls.Add(this.imgSF);
            this.panelSocials.Controls.Add(this.label1);
            this.panelSocials.Controls.Add(this.imgTwitch);
            this.panelSocials.Controls.Add(this.imgYoutube);
            this.panelSocials.Controls.Add(this.imgBMCSupport);
            this.panelSocials.Controls.Add(this.labelSupport);
            this.panelSocials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSocials.Location = new System.Drawing.Point(110, 476);
            this.panelSocials.Name = "panelSocials";
            this.panelSocials.Size = new System.Drawing.Size(721, 64);
            this.panelSocials.TabIndex = 0;
            // 
            // btnUpdateNotif
            // 
            this.btnUpdateNotif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNotif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNotif.Location = new System.Drawing.Point(198, 14);
            this.btnUpdateNotif.Name = "btnUpdateNotif";
            this.btnUpdateNotif.Size = new System.Drawing.Size(160, 43);
            this.btnUpdateNotif.TabIndex = 95;
            this.btnUpdateNotif.Text = "vx.x is now available!\r\nGET IT NOW!";
            this.btnUpdateNotif.UseVisualStyleBackColor = false;
            this.btnUpdateNotif.Visible = false;
            this.btnUpdateNotif.Click += new System.EventHandler(this.btnUpdateNotif_Click);
            // 
            // imgSF
            // 
            this.imgSF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSF.Location = new System.Drawing.Point(619, 37);
            this.imgSF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgSF.Name = "imgSF";
            this.imgSF.Size = new System.Drawing.Size(95, 20);
            this.imgSF.TabIndex = 91;
            this.imgSF.TabStop = false;
            this.imgSF.Click += new System.EventHandler(this.imgSF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(666, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 94;
            this.label1.Text = "Updates on";
            // 
            // imgTwitch
            // 
            this.imgTwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTwitch.Location = new System.Drawing.Point(602, 40);
            this.imgTwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgTwitch.Name = "imgTwitch";
            this.imgTwitch.Size = new System.Drawing.Size(15, 16);
            this.imgTwitch.TabIndex = 93;
            this.imgTwitch.TabStop = false;
            this.imgTwitch.Click += new System.EventHandler(this.imgTwitch_Click);
            // 
            // imgYoutube
            // 
            this.imgYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgYoutube.Location = new System.Drawing.Point(577, 40);
            this.imgYoutube.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgYoutube.Name = "imgYoutube";
            this.imgYoutube.Size = new System.Drawing.Size(23, 16);
            this.imgYoutube.TabIndex = 92;
            this.imgYoutube.TabStop = false;
            this.imgYoutube.Click += new System.EventHandler(this.imgYoutube_Click);
            // 
            // imgBMCSupport
            // 
            this.imgBMCSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBMCSupport.InitialImage = null;
            this.imgBMCSupport.Location = new System.Drawing.Point(6, 14);
            this.imgBMCSupport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBMCSupport.Name = "imgBMCSupport";
            this.imgBMCSupport.Size = new System.Drawing.Size(152, 43);
            this.imgBMCSupport.TabIndex = 89;
            this.imgBMCSupport.TabStop = false;
            this.imgBMCSupport.Click += new System.EventHandler(this.imgBMCSupport_Click);
            // 
            // labelSupport
            // 
            this.labelSupport.AutoSize = true;
            this.labelSupport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSupport.Location = new System.Drawing.Point(4, 5);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(86, 15);
            this.labelSupport.TabIndex = 90;
            this.labelSupport.Text = "Support me on";
            this.labelSupport.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOutputDir);
            this.Controls.Add(this.tvFolders);
            this.Controls.Add(this.panelSocials);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.labelImagePreview);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.pictPreview);
            this.Controls.Add(this.chkSameDir);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.labelExportDisabled);
            this.Controls.Add(this.panelOverlay);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "TMNT Tello";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictPreview)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelSocials.ResumeLayout(false);
            this.panelSocials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBMCSupport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.PictureBox pictPreview;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Label labelImagePreview;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelVerNum;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TreeView tvFolders;
        private System.Windows.Forms.Button btnGameDir;
        private System.Windows.Forms.Button btnInstructions;
        public System.Windows.Forms.Button btnOutputDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelExportDisabled;
        private System.Windows.Forms.Panel panelOverlay;
        private System.Windows.Forms.CheckBox chkSameDir;
        private System.Windows.Forms.Panel panelSocials;
        public System.Windows.Forms.Button btnUpdateNotif;
        public System.Windows.Forms.PictureBox imgSF;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox imgTwitch;
        public System.Windows.Forms.PictureBox imgYoutube;
        public System.Windows.Forms.PictureBox imgBMCSupport;
        public System.Windows.Forms.Label labelSupport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOutputDir;
    }
}

