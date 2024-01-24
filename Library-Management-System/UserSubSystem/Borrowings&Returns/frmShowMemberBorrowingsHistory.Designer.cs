namespace LibraryManagementSystem.Borrowings_Returns
{
    partial class frmShowMemberBorrowingsHistory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvMemberBorrowingsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsBorrowings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ucMemberCard1 = new LibraryManagementSystem.Members.UserControls.ucMemberCard();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberBorrowingsList)).BeginInit();
            this.cmsBorrowings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.lblTitle.Location = new System.Drawing.Point(316, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 46);
            this.lblTitle.TabIndex = 173;
            this.lblTitle.Text = "Borrowings History";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.guna2GroupBox1.BorderRadius = 25;
            this.guna2GroupBox1.Controls.Add(this.dgvMemberBorrowingsList);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 553);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(979, 224);
            this.guna2GroupBox1.TabIndex = 290;
            // 
            // dgvMemberBorrowingsList
            // 
            this.dgvMemberBorrowingsList.AllowUserToAddRows = false;
            this.dgvMemberBorrowingsList.AllowUserToDeleteRows = false;
            this.dgvMemberBorrowingsList.AllowUserToOrderColumns = true;
            this.dgvMemberBorrowingsList.AllowUserToResizeColumns = false;
            this.dgvMemberBorrowingsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvMemberBorrowingsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberBorrowingsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberBorrowingsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMemberBorrowingsList.ColumnHeadersHeight = 45;
            this.dgvMemberBorrowingsList.ContextMenuStrip = this.cmsBorrowings;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberBorrowingsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMemberBorrowingsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberBorrowingsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvMemberBorrowingsList.Location = new System.Drawing.Point(0, 40);
            this.dgvMemberBorrowingsList.MultiSelect = false;
            this.dgvMemberBorrowingsList.Name = "dgvMemberBorrowingsList";
            this.dgvMemberBorrowingsList.ReadOnly = true;
            this.dgvMemberBorrowingsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberBorrowingsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMemberBorrowingsList.RowHeadersVisible = false;
            this.dgvMemberBorrowingsList.RowHeadersWidth = 50;
            this.dgvMemberBorrowingsList.RowTemplate.Height = 35;
            this.dgvMemberBorrowingsList.Size = new System.Drawing.Size(979, 184);
            this.dgvMemberBorrowingsList.TabIndex = 66;
            this.dgvMemberBorrowingsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvMemberBorrowingsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvMemberBorrowingsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMemberBorrowingsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMemberBorrowingsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMemberBorrowingsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMemberBorrowingsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMemberBorrowingsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvMemberBorrowingsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvMemberBorrowingsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMemberBorrowingsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvMemberBorrowingsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMemberBorrowingsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMemberBorrowingsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvMemberBorrowingsList.ThemeStyle.ReadOnly = true;
            this.dgvMemberBorrowingsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvMemberBorrowingsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMemberBorrowingsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvMemberBorrowingsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMemberBorrowingsList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvMemberBorrowingsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvMemberBorrowingsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMemberBorrowingsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMemberBorrowingsList_DataBindingComplete);
            // 
            // cmsBorrowings
            // 
            this.cmsBorrowings.BackColor = System.Drawing.Color.White;
            this.cmsBorrowings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cmsBorrowings.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsBorrowings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem});
            this.cmsBorrowings.Name = "contextMenuStrip1";
            this.cmsBorrowings.Size = new System.Drawing.Size(256, 40);
            // 
            // ucMemberCard1
            // 
            this.ucMemberCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucMemberCard1.Location = new System.Drawing.Point(15, 58);
            this.ucMemberCard1.Name = "ucMemberCard1";
            this.ucMemberCard1.Size = new System.Drawing.Size(979, 477);
            this.ucMemberCard1.TabIndex = 0;
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.showDetailsToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.information_pamphlet;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.showDetailsToolStripMenuItem.Text = "&Show Borrowing Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 22;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.btnClose.FillColor2 = System.Drawing.Color.SandyBrown;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::LibraryManagementSystem.Properties.Resources.folder__1_;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(817, 794);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 54);
            this.btnClose.TabIndex = 288;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowMemberBorrowingsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 863);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ucMemberCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowMemberBorrowingsHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Borrowings History";
            this.Load += new System.EventHandler(this.frmShowMemberBorrowingsHistory_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberBorrowingsList)).EndInit();
            this.cmsBorrowings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Members.UserControls.ucMemberCard ucMemberCard1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMemberBorrowingsList;
        private System.Windows.Forms.ContextMenuStrip cmsBorrowings;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
    }
}