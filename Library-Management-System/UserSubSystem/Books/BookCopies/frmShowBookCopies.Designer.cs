namespace LibraryManagementSystem.Books
{
    partial class frmShowBookCopies
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvBookCopiesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsBookCopies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCopyBorrowingsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ucBookCard1 = new LibraryManagementSystem.Books.UserControls.ucBookCard();
            this.showCopyReservationsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopiesList)).BeginInit();
            this.cmsBookCopies.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.guna2GroupBox1.BorderRadius = 25;
            this.guna2GroupBox1.Controls.Add(this.dgvBookCopiesList);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 489);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(998, 224);
            this.guna2GroupBox1.TabIndex = 298;
            // 
            // dgvBookCopiesList
            // 
            this.dgvBookCopiesList.AllowUserToAddRows = false;
            this.dgvBookCopiesList.AllowUserToDeleteRows = false;
            this.dgvBookCopiesList.AllowUserToOrderColumns = true;
            this.dgvBookCopiesList.AllowUserToResizeColumns = false;
            this.dgvBookCopiesList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvBookCopiesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookCopiesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookCopiesList.ColumnHeadersHeight = 45;
            this.dgvBookCopiesList.ContextMenuStrip = this.cmsBookCopies;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookCopiesList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookCopiesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookCopiesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvBookCopiesList.Location = new System.Drawing.Point(0, 40);
            this.dgvBookCopiesList.MultiSelect = false;
            this.dgvBookCopiesList.Name = "dgvBookCopiesList";
            this.dgvBookCopiesList.ReadOnly = true;
            this.dgvBookCopiesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookCopiesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookCopiesList.RowHeadersVisible = false;
            this.dgvBookCopiesList.RowHeadersWidth = 50;
            this.dgvBookCopiesList.RowTemplate.Height = 35;
            this.dgvBookCopiesList.Size = new System.Drawing.Size(998, 184);
            this.dgvBookCopiesList.TabIndex = 66;
            this.dgvBookCopiesList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvBookCopiesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvBookCopiesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBookCopiesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBookCopiesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBookCopiesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBookCopiesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookCopiesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvBookCopiesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvBookCopiesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBookCopiesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvBookCopiesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBookCopiesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookCopiesList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvBookCopiesList.ThemeStyle.ReadOnly = true;
            this.dgvBookCopiesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvBookCopiesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBookCopiesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvBookCopiesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBookCopiesList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvBookCopiesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvBookCopiesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBookCopiesList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBookCopiesList_DataBindingComplete);
            // 
            // cmsBookCopies
            // 
            this.cmsBookCopies.BackColor = System.Drawing.Color.White;
            this.cmsBookCopies.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cmsBookCopies.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsBookCopies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.showCopyBorrowingsHistoryToolStripMenuItem,
            this.showCopyReservationsHistoryToolStripMenuItem});
            this.cmsBookCopies.Name = "contextMenuStrip1";
            this.cmsBookCopies.Size = new System.Drawing.Size(308, 140);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.showDetailsToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.information_pamphlet;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.showDetailsToolStripMenuItem.Text = "&Show Copy Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // showCopyBorrowingsHistoryToolStripMenuItem
            // 
            this.showCopyBorrowingsHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.showCopyBorrowingsHistoryToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources._3d_calendar;
            this.showCopyBorrowingsHistoryToolStripMenuItem.Name = "showCopyBorrowingsHistoryToolStripMenuItem";
            this.showCopyBorrowingsHistoryToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.showCopyBorrowingsHistoryToolStripMenuItem.Text = "Show Copy Borrowings History";
            this.showCopyBorrowingsHistoryToolStripMenuItem.Click += new System.EventHandler(this.showCopyBorrowingsHistoryToolStripMenuItem_Click);
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
            this.btnClose.Location = new System.Drawing.Point(833, 728);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 54);
            this.btnClose.TabIndex = 297;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.lblTitle.Location = new System.Drawing.Point(378, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 46);
            this.lblTitle.TabIndex = 296;
            this.lblTitle.Text = "Book\'s Copies ";
            // 
            // ucBookCard1
            // 
            this.ucBookCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucBookCard1.Location = new System.Drawing.Point(12, 65);
            this.ucBookCard1.Name = "ucBookCard1";
            this.ucBookCard1.Size = new System.Drawing.Size(1001, 407);
            this.ucBookCard1.TabIndex = 299;
            // 
            // showCopyReservationsHistoryToolStripMenuItem
            // 
            this.showCopyReservationsHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.showCopyReservationsHistoryToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources._3d_calendar;
            this.showCopyReservationsHistoryToolStripMenuItem.Name = "showCopyReservationsHistoryToolStripMenuItem";
            this.showCopyReservationsHistoryToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.showCopyReservationsHistoryToolStripMenuItem.Text = "Show Copy Reservation History";
            this.showCopyReservationsHistoryToolStripMenuItem.Click += new System.EventHandler(this.showCopyReservationsHistoryToolStripMenuItem_Click);
            // 
            // frmShowBookCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 800);
            this.Controls.Add(this.ucBookCard1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowBookCopies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Copies";
            this.Load += new System.EventHandler(this.frmShowBookCopies_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopiesList)).EndInit();
            this.cmsBookCopies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBookCopiesList;
        private System.Windows.Forms.ContextMenuStrip cmsBookCopies;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private UserControls.ucBookCard ucBookCard1;
        private System.Windows.Forms.ToolStripMenuItem showCopyBorrowingsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCopyReservationsHistoryToolStripMenuItem;
    }
}