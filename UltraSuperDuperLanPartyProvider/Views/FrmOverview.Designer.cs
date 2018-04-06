namespace UltraSuperDuperLanPartyProvider.Views
{
    partial class FrmOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRed = new System.Windows.Forms.DataGridView();
            this.empty = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBlue = new System.Windows.Forms.DataGridView();
            this.blueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blueNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bluePaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.blueScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.redScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvRed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.empty, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvBlue, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1518, 825);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvRed
            // 
            this.dgvRed.AllowUserToAddRows = false;
            this.dgvRed.AllowUserToDeleteRows = false;
            this.dgvRed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.redName,
            this.redNickname,
            this.redPaid,
            this.redScore});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRed.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRed.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRed.Location = new System.Drawing.Point(785, 153);
            this.dgvRed.Margin = new System.Windows.Forms.Padding(6);
            this.dgvRed.Name = "dgvRed";
            this.dgvRed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRed.RowHeadersVisible = false;
            this.dgvRed.RowTemplate.Height = 40;
            this.dgvRed.Size = new System.Drawing.Size(727, 758);
            this.dgvRed.TabIndex = 5;
            this.dgvRed.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRed_CellEndEdit);
            // 
            // empty
            // 
            this.empty.AllowUserToAddRows = false;
            this.empty.AllowUserToDeleteRows = false;
            this.empty.BackgroundColor = System.Drawing.SystemColors.Control;
            this.empty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empty.Dock = System.Windows.Forms.DockStyle.Right;
            this.empty.GridColor = System.Drawing.SystemColors.Control;
            this.empty.Location = new System.Drawing.Point(745, 153);
            this.empty.Margin = new System.Windows.Forms.Padding(6);
            this.empty.Name = "empty";
            this.empty.ReadOnly = true;
            this.empty.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empty.RowHeadersVisible = false;
            this.empty.Size = new System.Drawing.Size(28, 758);
            this.empty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(785, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(727, 105);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rode team";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 105);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blauwe team";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvBlue
            // 
            this.dgvBlue.AllowUserToAddRows = false;
            this.dgvBlue.AllowUserToDeleteRows = false;
            this.dgvBlue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBlue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBlue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blueName,
            this.blueNickname,
            this.bluePaid,
            this.blueScore});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBlue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBlue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvBlue.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBlue.Location = new System.Drawing.Point(6, 153);
            this.dgvBlue.Margin = new System.Windows.Forms.Padding(6);
            this.dgvBlue.Name = "dgvBlue";
            this.dgvBlue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBlue.RowHeadersVisible = false;
            this.dgvBlue.RowTemplate.Height = 40;
            this.dgvBlue.Size = new System.Drawing.Size(727, 758);
            this.dgvBlue.TabIndex = 3;
            this.dgvBlue.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlue_CellEndEdit);
            // 
            // blueName
            // 
            this.blueName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.blueName.DataPropertyName = "PlayerName";
            this.blueName.HeaderText = "Speler";
            this.blueName.Name = "blueName";
            this.blueName.ReadOnly = true;
            this.blueName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.blueName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // blueNickname
            // 
            this.blueNickname.DataPropertyName = "Nickname";
            this.blueNickname.HeaderText = "Nickname";
            this.blueNickname.Name = "blueNickname";
            this.blueNickname.Width = 139;
            // 
            // bluePaid
            // 
            this.bluePaid.DataPropertyName = "hasPaid";
            this.bluePaid.FalseValue = "false";
            this.bluePaid.HeaderText = "Betaald";
            this.bluePaid.Name = "bluePaid";
            this.bluePaid.TrueValue = "true";
            this.bluePaid.Width = 92;
            // 
            // blueScore
            // 
            this.blueScore.DataPropertyName = "Score";
            this.blueScore.HeaderText = "Score";
            this.blueScore.Name = "blueScore";
            this.blueScore.Width = 92;
            // 
            // redName
            // 
            this.redName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.redName.DataPropertyName = "PlayerName";
            this.redName.HeaderText = "Speler";
            this.redName.Name = "redName";
            this.redName.ReadOnly = true;
            this.redName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.redName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // redNickname
            // 
            this.redNickname.DataPropertyName = "Nickname";
            this.redNickname.HeaderText = "Nickname";
            this.redNickname.Name = "redNickname";
            this.redNickname.Width = 139;
            // 
            // redPaid
            // 
            this.redPaid.DataPropertyName = "hasPaid";
            this.redPaid.FalseValue = "false";
            this.redPaid.HeaderText = "Betaald";
            this.redPaid.Name = "redPaid";
            this.redPaid.ReadOnly = true;
            this.redPaid.TrueValue = "true";
            this.redPaid.Width = 92;
            // 
            // redScore
            // 
            this.redScore.DataPropertyName = "Score";
            this.redScore.HeaderText = "Score";
            this.redScore.Name = "redScore";
            this.redScore.Width = 92;
            // 
            // FrmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 825);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOverview";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRed;
        private System.Windows.Forms.DataGridView empty;
        private System.Windows.Forms.DataGridView dgvBlue;
        private System.Windows.Forms.DataGridViewTextBoxColumn redName;
        private System.Windows.Forms.DataGridViewTextBoxColumn redNickname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn redPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn redScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn blueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn blueNickname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bluePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn blueScore;
    }
}