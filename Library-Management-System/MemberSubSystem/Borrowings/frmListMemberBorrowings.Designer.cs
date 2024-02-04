namespace LibraryManagementSystem.MemberSubSystem
{
    partial class frmListMemberBorrowings
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
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvBorrowingsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsBorrowings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddBorrowingtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbBorrowedCopyStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddBorrowing = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingsList)).BeginInit();
            this.cmsBorrowings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilterByOptions
            // 
            this.cbFilterByOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByOptions.BorderRadius = 22;
            this.cbFilterByOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cbFilterByOptions.ForeColor = System.Drawing.Color.Black;
            this.cbFilterByOptions.ItemHeight = 35;
            this.cbFilterByOptions.Items.AddRange(new object[] {
            "None",
            "Borrowing ID",
            "Book Title",
            "Borrowed Copy ID",
            "Book Copy Status"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(121, 309);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(231, 41);
            this.cbFilterByOptions.TabIndex = 74;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.cbFilterByOptions_SelectedIndexChanged);
            // 
            // dgvBorrowingsList
            // 
            this.dgvBorrowingsList.AllowUserToAddRows = false;
            this.dgvBorrowingsList.AllowUserToDeleteRows = false;
            this.dgvBorrowingsList.AllowUserToOrderColumns = true;
            this.dgvBorrowingsList.AllowUserToResizeColumns = false;
            this.dgvBorrowingsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvBorrowingsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrowingsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowingsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorrowingsList.ColumnHeadersHeight = 45;
            this.dgvBorrowingsList.ContextMenuStrip = this.cmsBorrowings;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowingsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBorrowingsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvBorrowingsList.Location = new System.Drawing.Point(12, 374);
            this.dgvBorrowingsList.MultiSelect = false;
            this.dgvBorrowingsList.Name = "dgvBorrowingsList";
            this.dgvBorrowingsList.ReadOnly = true;
            this.dgvBorrowingsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowingsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBorrowingsList.RowHeadersVisible = false;
            this.dgvBorrowingsList.RowHeadersWidth = 50;
            this.dgvBorrowingsList.RowTemplate.Height = 35;
            this.dgvBorrowingsList.Size = new System.Drawing.Size(1258, 351);
            this.dgvBorrowingsList.TabIndex = 73;
            this.dgvBorrowingsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvBorrowingsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvBorrowingsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBorrowingsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBorrowingsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBorrowingsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBorrowingsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBorrowingsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvBorrowingsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvBorrowingsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBorrowingsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvBorrowingsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBorrowingsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBorrowingsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvBorrowingsList.ThemeStyle.ReadOnly = true;
            this.dgvBorrowingsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvBorrowingsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBorrowingsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvBorrowingsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBorrowingsList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvBorrowingsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvBorrowingsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBorrowingsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBorrowingsList_DataBindingComplete);
            // 
            // cmsBorrowings
            // 
            this.cmsBorrowings.BackColor = System.Drawing.Color.White;
            this.cmsBorrowings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cmsBorrowings.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsBorrowings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBorrowingtoolStripMenuItem,
            this.showDetailsToolStripMenuItem});
            this.cmsBorrowings.Name = "contextMenuStrip1";
            this.cmsBorrowings.Size = new System.Drawing.Size(256, 76);
            // 
            // AddBorrowingtoolStripMenuItem
            // 
            this.AddBorrowingtoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.AddBorrowingtoolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.AddBorrowingtoolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.add2;
            this.AddBorrowingtoolStripMenuItem.Name = "AddBorrowingtoolStripMenuItem";
            this.AddBorrowingtoolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.AddBorrowingtoolStripMenuItem.Text = "&Borrow Book";
            this.AddBorrowingtoolStripMenuItem.Click += new System.EventHandler(this.AddBorrowingtoolStripMenuItem_Click);
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
            // cbBorrowedCopyStatus
            // 
            this.cbBorrowedCopyStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbBorrowedCopyStatus.BorderRadius = 22;
            this.cbBorrowedCopyStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBorrowedCopyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBorrowedCopyStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBorrowedCopyStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBorrowedCopyStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cbBorrowedCopyStatus.ForeColor = System.Drawing.Color.Black;
            this.cbBorrowedCopyStatus.ItemHeight = 40;
            this.cbBorrowedCopyStatus.Items.AddRange(new object[] {
            "Returned",
            "Borrowed"});
            this.cbBorrowedCopyStatus.Location = new System.Drawing.Point(383, 305);
            this.cbBorrowedCopyStatus.Name = "cbBorrowedCopyStatus";
            this.cbBorrowedCopyStatus.Size = new System.Drawing.Size(231, 46);
            this.cbBorrowedCopyStatus.TabIndex = 78;
            this.cbBorrowedCopyStatus.Visible = false;
            this.cbBorrowedCopyStatus.SelectedIndexChanged += new System.EventHandler(this.cbBorrowedCopyStatus_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 77;
            this.label3.Text = "Filter By :";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderRadius = 22;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(383, 303);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(295, 49);
            this.txtFilterValue.TabIndex = 76;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnAddBorrowing
            // 
            this.btnAddBorrowing.AnimatedGIF = true;
            this.btnAddBorrowing.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddBorrowing.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddBorrowing.Image = global::LibraryManagementSystem.Properties.Resources._10_borrow_book;
            this.btnAddBorrowing.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddBorrowing.ImageRotate = 0F;
            this.btnAddBorrowing.ImageSize = new System.Drawing.Size(75, 75);
            this.btnAddBorrowing.Location = new System.Drawing.Point(1199, 286);
            this.btnAddBorrowing.Name = "btnAddBorrowing";
            this.btnAddBorrowing.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddBorrowing.ShadowDecoration.BorderRadius = 0;
            this.btnAddBorrowing.ShadowDecoration.Depth = 0;
            this.btnAddBorrowing.ShadowDecoration.Enabled = true;
            this.btnAddBorrowing.Size = new System.Drawing.Size(65, 65);
            this.btnAddBorrowing.TabIndex = 75;
            this.btnAddBorrowing.Click += new System.EventHandler(this.btnAddBorrowing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(449, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 46);
            this.label1.TabIndex = 71;
            this.label1.Text = "Manage Borrowings";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::LibraryManagementSystem.Properties.Resources._13_delivering_books;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(508, 40);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(241, 131);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 72;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmListMemberBorrowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 743);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.dgvBorrowingsList);
            this.Controls.Add(this.cbBorrowedCopyStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.btnAddBorrowing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListMemberBorrowings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Member Borrowings";
            this.Load += new System.EventHandler(this.frmListMemberBorrowings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingsList)).EndInit();
            this.cmsBorrowings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBorrowingsList;
        private System.Windows.Forms.ContextMenuStrip cmsBorrowings;
        private System.Windows.Forms.ToolStripMenuItem AddBorrowingtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbBorrowedCopyStatus;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddBorrowing;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}