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
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(846, 73);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Mooi daj d\'r bin Thom brink!";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlConfig);
            this.pnlContent.Controls.Add(this.pbStream);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 100);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1116, 327);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.lbGamers);
            this.pnlConfig.Controls.Add(this.btnStartStream);
            this.pnlConfig.Controls.Add(this.btnSaveGamer);
            this.pnlConfig.Controls.Add(this.lblGamerName);
            this.pnlConfig.Controls.Add(this.txtGamerName);
            this.pnlConfig.Controls.Add(this.btnSaveCam);
            this.pnlConfig.Controls.Add(this.cbSelectCam);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConfig.Location = new System.Drawing.Point(751, 0);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(365, 327);
            this.pnlConfig.TabIndex = 2;
            this.pnlConfig.Visible = false;
            // 
            // lbGamers
            // 
            this.lbGamers.FormattingEnabled = true;
            this.lbGamers.ItemHeight = 16;
            this.lbGamers.Location = new System.Drawing.Point(15, 125);
            this.lbGamers.Name = "lbGamers";
            this.lbGamers.Size = new System.Drawing.Size(338, 196);
            this.lbGamers.TabIndex = 7;
            this.lbGamers.DoubleClick += new System.EventHandler(this.lbGamers_DoubleClick);
            this.lbGamers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbGamers_KeyDown);
            // 
            // btnStartStream
            // 
            this.btnStartStream.Location = new System.Drawing.Point(231, 44);
            this.btnStartStream.Name = "btnStartStream";
            this.btnStartStream.Size = new System.Drawing.Size(122, 23);
            this.btnStartStream.TabIndex = 6;
            this.btnStartStream.Text = "Herstart stream";
            this.btnStartStream.UseVisualStyleBackColor = true;
            this.btnStartStream.Click += new System.EventHandler(this.btnStartStream_Click);
            // 
            // btnSaveGamer
            // 
            this.btnSaveGamer.Location = new System.Drawing.Point(231, 96);
            this.btnSaveGamer.Name = "btnSaveGamer";
            this.btnSaveGamer.Size = new System.Drawing.Size(122, 23);
            this.btnSaveGamer.TabIndex = 5;
            this.btnSaveGamer.Text = "Gamer toevoegen";
            this.btnSaveGamer.UseVisualStyleBackColor = true;
            this.btnSaveGamer.Click += new System.EventHandler(this.btnSaveGamer_Click);
            // 
            // lblGamerName
            // 
            this.lblGamerName.AutoSize = true;
            this.lblGamerName.Location = new System.Drawing.Point(12, 83);
            this.lblGamerName.Name = "lblGamerName";
            this.lblGamerName.Size = new System.Drawing.Size(48, 16);
            this.lblGamerName.TabIndex = 4;
            this.lblGamerName.Text = "Naam:";
            // 
            // txtGamerName
            // 
            this.txtGamerName.Location = new System.Drawing.Point(15, 99);
            this.txtGamerName.Name = "txtGamerName";
            this.txtGamerName.Size = new System.Drawing.Size(210, 22);
            this.txtGamerName.TabIndex = 3;
            // 
            // btnSaveCam
            // 
            this.btnSaveCam.Location = new System.Drawing.Point(231, 15);
            this.btnSaveCam.Name = "btnSaveCam";
            this.btnSaveCam.Size = new System.Drawing.Size(122, 23);
            this.btnSaveCam.TabIndex = 2;
            this.btnSaveCam.Text = "Cam selecteren";
            this.btnSaveCam.UseVisualStyleBackColor = true;
            // 
            // cbSelectCam
            // 
            this.cbSelectCam.FormattingEnabled = true;
            this.cbSelectCam.Location = new System.Drawing.Point(15, 17);
            this.cbSelectCam.Name = "cbSelectCam";
            this.cbSelectCam.Size = new System.Drawing.Size(210, 24);
            this.cbSelectCam.TabIndex = 1;
            // 
            // pbStream
            // 
            this.pbStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbStream.Location = new System.Drawing.Point(0, 0);
            this.pbStream.Name = "pbStream";
            this.pbStream.Size = new System.Drawing.Size(1116, 327);
            this.pbStream.TabIndex = 0;
            this.pbStream.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1116, 100);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblNickname);
            this.pnlBottom.Controls.Add(this.txtNickname);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 427);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1116, 113);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(7, 20);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(395, 29);
            this.lblNickname.TabIndex = 1;
            this.lblNickname.Text = "Beste keerl, wat is oe nickname?";
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickname.Location = new System.Drawing.Point(12, 52);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(889, 49);
            this.txtNickname.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 540);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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

