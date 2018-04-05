namespace UltraSuperDuperLanPartyProvider
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.lbGamers = new System.Windows.Forms.ListBox();
            this.btnStartStream = new System.Windows.Forms.Button();
            this.btnSaveGamer = new System.Windows.Forms.Button();
            this.lblGamerName = new System.Windows.Forms.Label();
            this.txtGamerName = new System.Windows.Forms.TextBox();
            this.btnSaveCam = new System.Windows.Forms.Button();
            this.cbSelectCam = new System.Windows.Forms.ComboBox();
            this.pbStream = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblNickname = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.pnlContent.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStream)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Felix Titling", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(14, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1084, 74);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Mooi daj d\'r bin Thom brink!";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlConfig);
            this.pnlContent.Controls.Add(this.pbStream);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 100);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1302, 327);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlConfig
            // 
            this.pnlConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfig.Controls.Add(this.lbGamers);
            this.pnlConfig.Controls.Add(this.btnStartStream);
            this.pnlConfig.Controls.Add(this.btnSaveGamer);
            this.pnlConfig.Controls.Add(this.lblGamerName);
            this.pnlConfig.Controls.Add(this.txtGamerName);
            this.pnlConfig.Controls.Add(this.btnSaveCam);
            this.pnlConfig.Controls.Add(this.cbSelectCam);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlConfig.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConfig.Location = new System.Drawing.Point(876, 0);
            this.pnlConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(426, 327);
            this.pnlConfig.TabIndex = 2;
            this.pnlConfig.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlConfig_MouseDoubleClick);
            // 
            // lbGamers
            // 
            this.lbGamers.FormattingEnabled = true;
            this.lbGamers.ItemHeight = 15;
            this.lbGamers.Location = new System.Drawing.Point(18, 125);
            this.lbGamers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbGamers.Name = "lbGamers";
            this.lbGamers.Size = new System.Drawing.Size(393, 184);
            this.lbGamers.TabIndex = 7;
            this.lbGamers.DoubleClick += new System.EventHandler(this.lbGamers_DoubleClick);
            this.lbGamers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbGamers_KeyDown);
            // 
            // btnStartStream
            // 
            this.btnStartStream.Location = new System.Drawing.Point(270, 44);
            this.btnStartStream.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartStream.Name = "btnStartStream";
            this.btnStartStream.Size = new System.Drawing.Size(143, 23);
            this.btnStartStream.TabIndex = 6;
            this.btnStartStream.Text = "Herstart stream";
            this.btnStartStream.UseVisualStyleBackColor = true;
            this.btnStartStream.Click += new System.EventHandler(this.btnStartStream_Click);
            // 
            // btnSaveGamer
            // 
            this.btnSaveGamer.Location = new System.Drawing.Point(270, 96);
            this.btnSaveGamer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveGamer.Name = "btnSaveGamer";
            this.btnSaveGamer.Size = new System.Drawing.Size(143, 23);
            this.btnSaveGamer.TabIndex = 5;
            this.btnSaveGamer.Text = "Gamer toevoegen";
            this.btnSaveGamer.UseVisualStyleBackColor = true;
            this.btnSaveGamer.Click += new System.EventHandler(this.btnSaveGamer_Click);
            // 
            // lblGamerName
            // 
            this.lblGamerName.AutoSize = true;
            this.lblGamerName.Location = new System.Drawing.Point(14, 83);
            this.lblGamerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGamerName.Name = "lblGamerName";
            this.lblGamerName.Size = new System.Drawing.Size(49, 15);
            this.lblGamerName.TabIndex = 4;
            this.lblGamerName.Text = "Naam:";
            // 
            // txtGamerName
            // 
            this.txtGamerName.Location = new System.Drawing.Point(18, 99);
            this.txtGamerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGamerName.Name = "txtGamerName";
            this.txtGamerName.Size = new System.Drawing.Size(245, 23);
            this.txtGamerName.TabIndex = 3;
            // 
            // btnSaveCam
            // 
            this.btnSaveCam.Location = new System.Drawing.Point(270, 15);
            this.btnSaveCam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveCam.Name = "btnSaveCam";
            this.btnSaveCam.Size = new System.Drawing.Size(143, 23);
            this.btnSaveCam.TabIndex = 2;
            this.btnSaveCam.Text = "Cam selecteren";
            this.btnSaveCam.UseVisualStyleBackColor = true;
            this.btnSaveCam.Click += new System.EventHandler(this.btnSaveCam_Click);
            // 
            // cbSelectCam
            // 
            this.cbSelectCam.FormattingEnabled = true;
            this.cbSelectCam.Location = new System.Drawing.Point(18, 17);
            this.cbSelectCam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSelectCam.Name = "cbSelectCam";
            this.cbSelectCam.Size = new System.Drawing.Size(245, 23);
            this.cbSelectCam.TabIndex = 1;
            // 
            // pbStream
            // 
            this.pbStream.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbStream.BackgroundImage")));
            this.pbStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbStream.Location = new System.Drawing.Point(0, 0);
            this.pbStream.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbStream.Name = "pbStream";
            this.pbStream.Size = new System.Drawing.Size(1302, 327);
            this.pbStream.TabIndex = 0;
            this.pbStream.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1302, 100);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblNickname);
            this.pnlBottom.Controls.Add(this.txtNickname);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 427);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1302, 113);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(8, 20);
            this.lblNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(474, 28);
            this.lblNickname.TabIndex = 1;
            this.lblNickname.Text = "Beste keerl, wat is oe nickname?";
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickname.Location = new System.Drawing.Point(14, 52);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(1036, 49);
            this.txtNickname.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 540);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UltraSuperDuperLanPartyProvider V4.6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContent.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStream)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbStream;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Button btnSaveCam;
        private System.Windows.Forms.ComboBox cbSelectCam;
        private System.Windows.Forms.Label lblGamerName;
        private System.Windows.Forms.TextBox txtGamerName;
        private System.Windows.Forms.Button btnSaveGamer;
        private System.Windows.Forms.Button btnStartStream;
        private System.Windows.Forms.ListBox lbGamers;
    }
}

