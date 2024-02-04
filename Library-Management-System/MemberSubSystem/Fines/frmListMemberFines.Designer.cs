namespace LibraryManagementSystem.MemberSubSystem.Fines
{
    partial class frmListMemberFines
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvFinesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsFines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbPaymentStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinesList)).BeginInit();
            this.cmsFines.SuspendLayout();
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
            "Fine ID\t",
            "Member ID",
            "Borrowing ID",
            "Number Of Late Days",
            "Payment Status"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(120, 325);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(231, 41);
            this.cbFilterByOptions.TabIndex = 82;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.cbFilterByOptions_SelectedIndexChanged);
            // 
            // dgvFinesList
            // 
            this.dgvFinesList.AllowUserToAddRows = false;
            this.dgvFinesList.AllowUserToDeleteRows = false;
            this.dgvFinesList.AllowUserToOrderColumns = true;
            this.dgvFinesList.AllowUserToResizeColumns = false;
            this.dgvFinesList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvFinesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFinesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFinesList.ColumnHeadersHeight = 45;
            this.dgvFinesList.ContextMenuStrip = this.cmsFines;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinesList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFinesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvFinesList.Location = new System.Drawing.Point(25, 393);
            this.dgvFinesList.MultiSelect = false;
            this.dgvFinesList.Name = "dgvFinesList";
            this.dgvFinesList.ReadOnly = true;
            this.dgvFinesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFinesList.RowHeadersVisible = false;
            this.dgvFinesList.RowHeadersWidth = 50;
            this.dgvFinesList.RowTemplate.Height = 35;
            this.dgvFinesList.Size = new System.Drawing.Size(1249, 329);
            this.dgvFinesList.TabIndex = 81;
            this.dgvFinesList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvFinesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvFinesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFinesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFinesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFinesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFinesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFinesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvFinesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvFinesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFinesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvFinesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFinesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFinesList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvFinesList.ThemeStyle.ReadOnly = true;
            this.dgvFinesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvFinesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFinesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvFinesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFinesList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvFinesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvFinesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFinesList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvFinesList_DataBindingComplete);
            // 
            // cmsFines
            // 
            this.cmsFines.BackColor = System.Drawing.Color.White;
            this.cmsFines.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cmsFines.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.cmsFines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.payFineToolStripMenuItem});
            this.cmsFines.Name = "contextMenuStrip1";
            this.cmsFines.Size = new System.Drawing.Size(213, 76);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.showDetailsToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.information_pamphlet;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.showDetailsToolStripMenuItem.Text = "&Show Fine Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // payFineToolStripMenuItem
            // 
            this.payFineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.payFineToolStripMenuItem.Image = global::LibraryManagementSystem.Properties.Resources.payment1;
            this.payFineToolStripMenuItem.Name = "payFineToolStripMenuItem";
            this.payFineToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.payFineToolStripMenuItem.Text = "&Pay";
            this.payFineToolStripMenuItem.Click += new System.EventHandler(this.payFineToolStripMenuItem_Click);
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbPaymentStatus.BorderRadius = 22;
            this.cbPaymentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPaymentStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cbPaymentStatus.ForeColor = System.Drawing.Color.Black;
            this.cbPaymentStatus.ItemHeight = 40;
            this.cbPaymentStatus.Items.AddRange(new object[] {
            "Paid",
            "Not Paid"});
            this.cbPaymentStatus.Location = new System.Drawing.Point(382, 321);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(231, 46);
            this.cbPaymentStatus.TabIndex = 85;
            this.cbPaymentStatus.Visible = false;
            this.cbPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cbPaymentStatus_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 84;
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
            this.txtFilterValue.Location = new System.Drawing.Point(382, 319);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(295, 49);
            this.txtFilterValue.TabIndex = 83;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(520, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 46);
            this.label1.TabIndex = 79;
            this.label1.Text = "Manage Fines";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.fine1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(508, 33);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(241, 131);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 80;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmListMemberFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 743);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.dgvFinesList);
            this.Controls.Add(this.cbPaymentStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListMemberFines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Member Fines";
            this.Load += new System.EventHandler(this.frmListFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinesList)).EndInit();
            this.cmsFines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFinesList;
        private System.Windows.Forms.ContextMenuStrip cmsFines;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payFineToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbPaymentStatus;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}