﻿namespace UltraSuperDuperLanPartyProvider.Views
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
            this.redName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.dgvRed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.redName,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRed.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRed.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRed.Location = new System.Drawing.Point(785, 153);
            this.dgvRed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvRed.Name = "dgvRed";
            this.dgvRed.ReadOnly = true;
            this.dgvRed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRed.RowHeadersVisible = false;
            this.dgvRed.RowTemplate.Height = 40;
            this.dgvRed.Size = new System.Drawing.Size(727, 758);
            this.dgvRed.TabIndex = 5;
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
            this.empty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.dgvBlue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBlue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blueName,
            this.dataGridViewTextBoxColumn2});
            this.dgvBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBlue.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBlue.Location = new System.Drawing.Point(6, 153);
            this.dgvBlue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvBlue.Name = "dgvBlue";
            this.dgvBlue.ReadOnly = true;
            this.dgvBlue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBlue.RowHeadersVisible = false;
            this.dgvBlue.RowTemplate.Height = 40;
            this.dgvBlue.Size = new System.Drawing.Size(727, 758);
            this.dgvBlue.TabIndex = 3;
            // 
            // redName
            // 
            this.redName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.redName.DataPropertyName = "Name";
            this.redName.HeaderText = "Speler";
            this.redName.Name = "redName";
            this.redName.ReadOnly = true;
            this.redName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.redName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Score";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // blueName
            // 
            this.blueName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.blueName.DataPropertyName = "Name";
            this.blueName.HeaderText = "Speler";
            this.blueName.Name = "blueName";
            this.blueName.ReadOnly = true;
            this.blueName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.blueName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FrmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 825);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOverview";
            this.TopMost = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn blueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}