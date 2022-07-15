
namespace TMNT_Tello
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.panelBorder = new System.Windows.Forms.Panel();
            this.labelYoutube = new System.Windows.Forms.Label();
            this.labelInstructionsSummary = new System.Windows.Forms.Label();
            this.linkHelpExtract = new System.Windows.Forms.LinkLabel();
            this.linkHelpPng = new System.Windows.Forms.LinkLabel();
            this.linkHelpCompress = new System.Windows.Forms.LinkLabel();
            this.labelHelpExtract = new System.Windows.Forms.Label();
            this.labelHelpPng = new System.Windows.Forms.Label();
            this.labelHelpCompress = new System.Windows.Forms.Label();
            this.picYoutube = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picYoutube)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorder.Location = new System.Drawing.Point(12, 12);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(694, 382);
            this.panelBorder.TabIndex = 72;
            // 
            // labelYoutube
            // 
            this.labelYoutube.AutoSize = true;
            this.labelYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelYoutube.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYoutube.Location = new System.Drawing.Point(34, 171);
            this.labelYoutube.Name = "labelYoutube";
            this.labelYoutube.Size = new System.Drawing.Size(317, 17);
            this.labelYoutube.TabIndex = 61;
            this.labelYoutube.Text = "You can also check out the tutorials on        YouTube.";
            this.labelYoutube.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelYoutube.Click += new System.EventHandler(this.labelYoutube_Click);
            // 
            // labelInstructionsSummary
            // 
            this.labelInstructionsSummary.Location = new System.Drawing.Point(26, 52);
            this.labelInstructionsSummary.Name = "labelInstructionsSummary";
            this.labelInstructionsSummary.Size = new System.Drawing.Size(679, 40);
            this.labelInstructionsSummary.TabIndex = 62;
            this.labelInstructionsSummary.Text = "The sprites in TMNT Shredder\'s Revenge are stored in compressed XNB files called " +
    "ZXNB.\r\nYou can extract them into PNG image files using this tool.";
            // 
            // linkHelpExtract
            // 
            this.linkHelpExtract.AutoSize = true;
            this.linkHelpExtract.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkHelpExtract.Location = new System.Drawing.Point(34, 99);
            this.linkHelpExtract.Name = "linkHelpExtract";
            this.linkHelpExtract.Size = new System.Drawing.Size(162, 17);
            this.linkHelpExtract.TabIndex = 63;
            this.linkHelpExtract.TabStop = true;
            this.linkHelpExtract.Text = "Extracting PNG image files";
            this.linkHelpExtract.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelpExtract_LinkClicked);
            // 
            // linkHelpPng
            // 
            this.linkHelpPng.AutoSize = true;
            this.linkHelpPng.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkHelpPng.Location = new System.Drawing.Point(34, 123);
            this.linkHelpPng.Name = "linkHelpPng";
            this.linkHelpPng.Size = new System.Drawing.Size(266, 17);
            this.linkHelpPng.TabIndex = 64;
            this.linkHelpPng.TabStop = true;
            this.linkHelpPng.Text = "Using the modded PNG images in the game";
            this.linkHelpPng.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelpPng_LinkClicked);
            // 
            // linkHelpCompress
            // 
            this.linkHelpCompress.AutoSize = true;
            this.linkHelpCompress.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkHelpCompress.Location = new System.Drawing.Point(34, 147);
            this.linkHelpCompress.Name = "linkHelpCompress";
            this.linkHelpCompress.Size = new System.Drawing.Size(303, 17);
            this.linkHelpCompress.TabIndex = 65;
            this.linkHelpCompress.TabStop = true;
            this.linkHelpCompress.Text = "Compressing the PNG images back into ZXNB files";
            this.linkHelpCompress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelpCompress_LinkClicked);
            // 
            // labelHelpExtract
            // 
            this.labelHelpExtract.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelHelpExtract.Location = new System.Drawing.Point(13, 202);
            this.labelHelpExtract.Name = "labelHelpExtract";
            this.labelHelpExtract.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.labelHelpExtract.Size = new System.Drawing.Size(691, 191);
            this.labelHelpExtract.TabIndex = 66;
            this.labelHelpExtract.Text = resources.GetString("labelHelpExtract.Text");
            this.labelHelpExtract.Visible = false;
            // 
            // labelHelpPng
            // 
            this.labelHelpPng.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelHelpPng.Location = new System.Drawing.Point(13, 202);
            this.labelHelpPng.Name = "labelHelpPng";
            this.labelHelpPng.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.labelHelpPng.Size = new System.Drawing.Size(691, 191);
            this.labelHelpPng.TabIndex = 67;
            this.labelHelpPng.Text = resources.GetString("labelHelpPng.Text");
            this.labelHelpPng.Visible = false;
            // 
            // labelHelpCompress
            // 
            this.labelHelpCompress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelHelpCompress.Location = new System.Drawing.Point(13, 202);
            this.labelHelpCompress.Name = "labelHelpCompress";
            this.labelHelpCompress.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.labelHelpCompress.Size = new System.Drawing.Size(691, 191);
            this.labelHelpCompress.TabIndex = 68;
            this.labelHelpCompress.Text = "* This is an optional step and is not required for you to see your modded in the " +
    "game. This function is a work-in-progress.";
            this.labelHelpCompress.Visible = false;
            // 
            // picYoutube
            // 
            this.picYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picYoutube.Location = new System.Drawing.Point(268, 172);
            this.picYoutube.Name = "picYoutube";
            this.picYoutube.Size = new System.Drawing.Size(25, 16);
            this.picYoutube.TabIndex = 69;
            this.picYoutube.TabStop = false;
            this.picYoutube.Click += new System.EventHandler(this.picYoutube_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(593, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 24);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "Close How-To";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Instructions";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picYoutube);
            this.Controls.Add(this.labelHelpCompress);
            this.Controls.Add(this.labelHelpPng);
            this.Controls.Add(this.labelHelpExtract);
            this.Controls.Add(this.linkHelpCompress);
            this.Controls.Add(this.linkHelpPng);
            this.Controls.Add(this.linkHelpExtract);
            this.Controls.Add(this.labelInstructionsSummary);
            this.Controls.Add(this.labelYoutube);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelBorder);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Instructions";
            this.Text = "Instructions";
            ((System.ComponentModel.ISupportInitialize)(this.picYoutube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label labelYoutube;
        private System.Windows.Forms.Label labelInstructionsSummary;
        private System.Windows.Forms.LinkLabel linkHelpExtract;
        private System.Windows.Forms.LinkLabel linkHelpPng;
        private System.Windows.Forms.LinkLabel linkHelpCompress;
        private System.Windows.Forms.Label labelHelpExtract;
        private System.Windows.Forms.Label labelHelpPng;
        private System.Windows.Forms.Label labelHelpCompress;
        private System.Windows.Forms.PictureBox picYoutube;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}