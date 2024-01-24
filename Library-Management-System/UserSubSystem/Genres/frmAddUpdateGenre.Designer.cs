namespace LibraryManagementSystem.Genres
{
    partial class frmAddUpdateGenre
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
            this.guna2ImageButton10 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ImageButton7 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtGenreName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ImageButton10
            // 
            this.guna2ImageButton10.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton10.Image = global::LibraryManagementSystem.Properties.Resources.id;
            this.guna2ImageButton10.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton10.ImageRotate = 0F;
            this.guna2ImageButton10.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.Location = new System.Drawing.Point(137, 63);
            this.guna2ImageButton10.Name = "guna2ImageButton10";
            this.guna2ImageButton10.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.TabIndex = 175;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2ImageButton7
            // 
            this.guna2ImageButton7.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton7.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton7.Image = global::LibraryManagementSystem.Properties.Resources._3d_notes;
            this.guna2ImageButton7.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton7.ImageRotate = 0F;
            this.guna2ImageButton7.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton7.Location = new System.Drawing.Point(127, 158);
            this.guna2ImageButton7.Name = "guna2ImageButton7";
            this.guna2ImageButton7.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton7.TabIndex = 162;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton7);
            this.guna2GroupBox1.Controls.Add(this.label);
            this.guna2GroupBox1.Controls.Add(this.txtDescription);
            this.guna2GroupBox1.Controls.Add(this.btnSave);
            this.guna2GroupBox1.Controls.Add(this.btnClose);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton1);
            this.guna2GroupBox1.Controls.Add(this.txtGenreName);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 103);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(789, 381);
            this.guna2GroupBox1.TabIndex = 171;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(13, 163);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 20);
            this.label.TabIndex = 161;
            this.label.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.Silver;
            this.txtDescription.BorderRadius = 22;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(177, 159);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(571, 82);
            this.txtDescription.TabIndex = 160;
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
            this.btnSave.Location = new System.Drawing.Point(406, 284);
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
            this.btnClose.Location = new System.Drawing.Point(206, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 54);
            this.btnClose.TabIndex = 158;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::LibraryManagementSystem.Properties.Resources.title;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(127, 68);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 146;
            // 
            // txtGenreName
            // 
            this.txtGenreName.BorderColor = System.Drawing.Color.Silver;
            this.txtGenreName.BorderRadius = 20;
            this.txtGenreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenreName.DefaultText = "";
            this.txtGenreName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenreName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenreName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenreName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenreName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenreName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGenreName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenreName.Location = new System.Drawing.Point(177, 70);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtGenreName.Multiline = true;
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.PasswordChar = '\0';
            this.txtGenreName.PlaceholderText = "";
            this.txtGenreName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtGenreName.SelectedText = "";
            this.txtGenreName.Size = new System.Drawing.Size(355, 58);
            this.txtGenreName.TabIndex = 134;
            this.txtGenreName.Validating += new System.ComponentModel.CancelEventHandler(this.txtGenreName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "Genre Name :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(28, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 174;
            this.label14.Text = "Genre ID :";
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblGenreID.ForeColor = System.Drawing.Color.Red;
            this.lblGenreID.Location = new System.Drawing.Point(180, 63);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(67, 30);
            this.lblGenreID.TabIndex = 173;
            this.lblGenreID.Text = "[????]";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.lblTitle.Location = new System.Drawing.Point(262, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 46);
            this.lblTitle.TabIndex = 172;
            this.lblTitle.Text = "Add New Genre";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_TextChanged);
            // 
            // frmAddUpdateGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 503);
            this.Controls.Add(this.guna2ImageButton10);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblGenreID);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update Genre";
            this.Load += new System.EventHandler(this.frmAddEditGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton7;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtGenreName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.Label lblTitle;
    }
}