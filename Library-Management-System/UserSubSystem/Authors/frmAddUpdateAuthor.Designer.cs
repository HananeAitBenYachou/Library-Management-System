namespace LibraryManagementSystem.Authors
{
    partial class frmAddUpdateAuthor
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
            this.label = new System.Windows.Forms.Label();
            this.txtBiography = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ImageButton7 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ImageButton10 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(13, 249);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 20);
            this.label.TabIndex = 161;
            this.label.Text = "Biography :";
            // 
            // txtBiography
            // 
            this.txtBiography.BorderColor = System.Drawing.Color.Silver;
            this.txtBiography.BorderRadius = 22;
            this.txtBiography.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBiography.DefaultText = "";
            this.txtBiography.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBiography.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBiography.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBiography.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBiography.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBiography.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiography.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBiography.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBiography.Location = new System.Drawing.Point(177, 234);
            this.txtBiography.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBiography.Multiline = true;
            this.txtBiography.Name = "txtBiography";
            this.txtBiography.PasswordChar = '\0';
            this.txtBiography.PlaceholderText = "";
            this.txtBiography.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBiography.SelectedText = "";
            this.txtBiography.Size = new System.Drawing.Size(571, 82);
            this.txtBiography.TabIndex = 160;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(26, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 169;
            this.label14.Text = "Author ID :";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblAuthorID.ForeColor = System.Drawing.Color.Red;
            this.lblAuthorID.Location = new System.Drawing.Point(178, 59);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(67, 30);
            this.lblAuthorID.TabIndex = 168;
            this.lblAuthorID.Text = "[????]";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.lblTitle.Location = new System.Drawing.Point(260, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 46);
            this.lblTitle.TabIndex = 167;
            this.lblTitle.Text = "Add New Author";
            this.lblTitle.TextChanged += new System.EventHandler(this.lblTitle_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton7);
            this.guna2GroupBox1.Controls.Add(this.label);
            this.guna2GroupBox1.Controls.Add(this.txtBiography);
            this.guna2GroupBox1.Controls.Add(this.btnSave);
            this.guna2GroupBox1.Controls.Add(this.btnClose);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton6);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton1);
            this.guna2GroupBox1.Controls.Add(this.cbCountries);
            this.guna2GroupBox1.Controls.Add(this.txtFullName);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 99);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(789, 439);
            this.guna2GroupBox1.TabIndex = 166;
            // 
            // guna2ImageButton7
            // 
            this.guna2ImageButton7.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton7.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton7.Image = global::LibraryManagementSystem.Properties.Resources.biography;
            this.guna2ImageButton7.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton7.ImageRotate = 0F;
            this.guna2ImageButton7.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton7.Location = new System.Drawing.Point(117, 244);
            this.guna2ImageButton7.Name = "guna2ImageButton7";
            this.guna2ImageButton7.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton7.TabIndex = 162;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 22;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.btnSave.FillColor2 = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::LibraryManagementSystem.Properties.Resources.folder;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(571, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 54);
            this.btnSave.TabIndex = 159;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(371, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 54);
            this.btnClose.TabIndex = 158;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton6.Image = global::LibraryManagementSystem.Properties.Resources.navigation;
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton6.Location = new System.Drawing.Point(117, 159);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton6.TabIndex = 150;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::LibraryManagementSystem.Properties.Resources.user;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(117, 81);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 146;
            // 
            // cbCountries
            // 
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.BorderColor = System.Drawing.Color.Silver;
            this.cbCountries.BorderRadius = 22;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCountries.ItemHeight = 40;
            this.cbCountries.Location = new System.Drawing.Point(177, 154);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(223, 46);
            this.cbCountries.TabIndex = 138;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderColor = System.Drawing.Color.Silver;
            this.txtFullName.BorderRadius = 20;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(177, 70);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(355, 58);
            this.txtFullName.TabIndex = 134;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFullName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(13, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 132;
            this.label8.Text = "Country :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "Full Name : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2ImageButton10
            // 
            this.guna2ImageButton10.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton10.Image = global::LibraryManagementSystem.Properties.Resources.id;
            this.guna2ImageButton10.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton10.ImageRotate = 0F;
            this.guna2ImageButton10.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.Location = new System.Drawing.Point(135, 59);
            this.guna2ImageButton10.Name = "guna2ImageButton10";
            this.guna2ImageButton10.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.TabIndex = 170;
            // 
            // frmAddUpdateAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 556);
            this.Controls.Add(this.guna2ImageButton10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update Author";
            this.Load += new System.EventHandler(this.frmAddEditAuthor_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton7;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2TextBox txtBiography;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}