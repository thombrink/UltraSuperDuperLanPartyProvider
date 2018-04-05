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
            this.cbPaid = new System.Windows.Forms.ComboBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lbGamers = new System.Windows.Forms.ListBox();
            this.btnSaveGamer = new System.Windows.Forms.Button();
            this.lblGamerName = new System.Windows.Forms.Label();
            this.txtGamerName = new System.Windows.Forms.TextBox();
            this.pbStream = new System.Windows.Forms.PictureBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSaveNickName = new System.Windows.Forms.Button();
            this.lblNickname = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.btnResetState = new System.Windows.Forms.Button();
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
            this.lblWelcome.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblWelcome.Location = new System.Drawing.Point(10, 24);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(449, 129);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welkom!";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlConfig);
            this.pnlContent.Controls.Add(this.pbStream);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 161);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1096, 298);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlConfig
            // 
            this.pnlConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfig.Controls.Add(this.btnResetState);
            this.pnlConfig.Controls.Add(this.cbPaid);
            this.pnlConfig.Controls.Add(this.lblPaid);
            this.pnlConfig.Controls.Add(this.lbGamers);
            this.pnlConfig.Controls.Add(this.btnSaveGamer);
            this.pnlConfig.Controls.Add(this.lblGamerName);
            this.pnlConfig.Controls.Add(this.txtGamerName);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlConfig.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConfig.Location = new System.Drawing.Point(742, 0);
            this.pnlConfig.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(354, 298);
            this.pnlConfig.TabIndex = 2;
            this.pnlConfig.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlConfig_MouseDoubleClick);
            // 
            // cbPaid
            // 
            this.cbPaid.FormattingEnabled = true;
            this.cbPaid.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.cbPaid.Location = new System.Drawing.Point(195, 23);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(146, 26);
            this.cbPaid.TabIndex = 10;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(192, 5);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(56, 18);
            this.lblPaid.TabIndex = 9;
            this.lblPaid.Text = "Betaald:";
            // 
            // lbGamers
            // 
            this.lbGamers.FormattingEnabled = true;
            this.lbGamers.ItemHeight = 18;
            this.lbGamers.Location = new System.Drawing.Point(12, 126);
            this.lbGamers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbGamers.Name = "lbGamers";
            this.lbGamers.Size = new System.Drawing.Size(330, 220);
            this.lbGamers.TabIndex = 7;
            this.lbGamers.DoubleClick += new System.EventHandler(this.lbGamers_DoubleClick);
            this.lbGamers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbGamers_KeyDown);
            // 
            // btnSaveGamer
            // 
            this.btnSaveGamer.Location = new System.Drawing.Point(12, 54);
            this.btnSaveGamer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveGamer.Name = "btnSaveGamer";
            this.btnSaveGamer.Size = new System.Drawing.Size(330, 27);
            this.btnSaveGamer.TabIndex = 5;
            this.btnSaveGamer.Text = "Gamer toevoegen";
            this.btnSaveGamer.UseVisualStyleBackColor = true;
            this.btnSaveGamer.Click += new System.EventHandler(this.btnSaveGamer_Click);
            // 
            // lblGamerName
            // 
            this.lblGamerName.AutoSize = true;
            this.lblGamerName.Location = new System.Drawing.Point(10, 5);
            this.lblGamerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGamerName.Name = "lblGamerName";
            this.lblGamerName.Size = new System.Drawing.Size(48, 18);
            this.lblGamerName.TabIndex = 4;
            this.lblGamerName.Text = "Naam:";
            // 
            // txtGamerName
            // 
            this.txtGamerName.Location = new System.Drawing.Point(12, 23);
            this.txtGamerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGamerName.Name = "txtGamerName";
            this.txtGamerName.Size = new System.Drawing.Size(176, 25);
            this.txtGamerName.TabIndex = 3;
            // 
            // pbStream
            // 
            this.pbStream.BackColor = System.Drawing.Color.White;
            this.pbStream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbStream.Image = global::UltraSuperDuperLanPartyProvider.Properties.Resources.wallpaper;
            this.pbStream.Location = new System.Drawing.Point(0, 0);
            this.pbStream.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbStream.Name = "pbStream";
            this.pbStream.Size = new System.Drawing.Size(1096, 298);
            this.pbStream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStream.TabIndex = 0;
            this.pbStream.TabStop = false;
            this.pbStream.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbStream_MouseDoubleClick);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.No;
            this.txtInput.Location = new System.Drawing.Point(11, 24);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(109, 20);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "Barcode input";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Controls.Add(this.txtInput);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1096, 161);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnSaveNickName);
            this.pnlBottom.Controls.Add(this.lblNickname);
            this.pnlBottom.Controls.Add(this.txtNickname);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 459);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1096, 164);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnSaveNickName
            // 
            this.btnSaveNickName.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNickName.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSaveNickName.Location = new System.Drawing.Point(923, 74);
            this.btnSaveNickName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveNickName.Name = "btnSaveNickName";
            this.btnSaveNickName.Size = new System.Drawing.Size(162, 49);
            this.btnSaveNickName.TabIndex = 3;
            this.btnSaveNickName.Text = "Opslaan";
            this.btnSaveNickName.UseVisualStyleBackColor = true;
            this.btnSaveNickName.Click += new System.EventHandler(this.btnSaveNickName_Click);
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNickname.Location = new System.Drawing.Point(23, 14);
            this.lblNickname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(357, 50);
            this.lblNickname.TabIndex = 1;
            this.lblNickname.Text = "Wat is je nickname?";
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickname.Location = new System.Drawing.Point(32, 74);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(878, 49);
            this.txtNickname.TabIndex = 0;
            this.txtNickname.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtNickname_PreviewKeyDown);
            // 
            // btnResetState
            // 
            this.btnResetState.Location = new System.Drawing.Point(11, 87);
            this.btnResetState.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResetState.Name = "btnResetState";
            this.btnResetState.Size = new System.Drawing.Size(330, 27);
            this.btnResetState.TabIndex = 11;
            this.btnResetState.Text = "Reset state";
            this.btnResetState.UseVisualStyleBackColor = true;
            this.btnResetState.Click += new System.EventHandler(this.btnResetState_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 623);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbStream;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Label lblGamerName;
        private System.Windows.Forms.TextBox txtGamerName;
        private System.Windows.Forms.Button btnSaveGamer;
        private System.Windows.Forms.ListBox lbGamers;
        protected System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSaveNickName;
        private System.Windows.Forms.ComboBox cbPaid;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Button btnResetState;
    }
}

