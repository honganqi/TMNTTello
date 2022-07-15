using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMNT_Tello
{
    public partial class Instructions : Form
    {
        MainWindow _mainwindow;
        Assembly imageAssembly = Assembly.GetExecutingAssembly();
        public Instructions(MainWindow mainwindow)
        {
            _mainwindow = mainwindow;
            InitializeComponent();

            btnClose.Text = "\u2716 Close How-To";

            Stream thumbStream = imageAssembly.GetManifestResourceStream("TMNT_Tello.img.youtube.png");
            Bitmap thumbBitmap = new Bitmap(thumbStream);
            picYoutube.Image = thumbBitmap;
        }

        private void SwitchTab(Label target, LinkLabel linktarget)
        {
            Label[] contents =
            {
                labelHelpExtract,
                labelHelpPng,
                labelHelpCompress
            };
            foreach (Label content in contents)
            {
                if ((target == content) && !target.Visible)
                {
                    content.BringToFront();
                    content.Show();
                }
                else
                {
                    content.Hide();
                }
            }
            LinkLabel[] links =
            {
                linkHelpExtract,
                linkHelpPng,
                linkHelpCompress
            };
            foreach (LinkLabel item in links)
            {
                if (linktarget == item)
                {
                    item.Font = new(item.Font, FontStyle.Bold);
                }
                else
                {
                    item.Font = new(item.Font, FontStyle.Regular);
                }
            }
        }

        private void linkHelpExtract_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchTab(labelHelpExtract, linkHelpExtract);
        }

        private void linkHelpPng_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchTab(labelHelpPng, linkHelpPng);
        }

        private void linkHelpCompress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchTab(labelHelpCompress, linkHelpCompress);
        }

        private void labelYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=w1_efI2H4Hg&list=PLTUnVIy4j6R4lpdbGYYIFbMD18eUzETU5");
        }

        private void picYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=w1_efI2H4Hg&list=PLTUnVIy4j6R4lpdbGYYIFbMD18eUzETU5");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _mainwindow.SwitchTab("main");
        }
    }
}
