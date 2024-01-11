namespace LibraryManagementSystem.Books
{
    partial class frmAddUpdateBook
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
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.llbRemoveImage = new System.Windows.Forms.LinkLabel();
            this.txtAdditionalDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpPublicationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ImageButton8 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAddNewAuthor = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbAuthors = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddNewGenre = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbGenres = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISBN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.llbUploadImage = new System.Windows.Forms.LinkLabel();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(570, 411);
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
            this.btnClose.Location = new System.Drawing.Point(370, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 54);
            this.btnClose.TabIndex = 158;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbBookImage
            // 
            this.pbBookImage.Image = global::LibraryManagementSystem.Properties.Resources.book__2_;
            this.pbBookImage.Location = new System.Drawing.Point(903, 91);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(163, 241);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 154;
            this.pbBookImage.TabStop = false;
            // 
            // llbRemoveImage
            // 
            this.llbRemoveImage.AutoSize = true;
            this.llbRemoveImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbRemoveImage.Location = new System.Drawing.Point(928, 376);
            this.llbRemoveImage.Name = "llbRemoveImage";
            this.llbRemoveImage.Size = new System.Drawing.Size(126, 23);
            this.llbRemoveImage.TabIndex = 155;
            this.llbRemoveImage.TabStop = true;
            this.llbRemoveImage.Text = "Remove Image";
            this.llbRemoveImage.Visible = false;
            this.llbRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRemoveImage_LinkClicked);
            // 
            // txtAdditionalDetails
            // 
            this.txtAdditionalDetails.BorderColor = System.Drawing.Color.Silver;
            this.txtAdditionalDetails.BorderRadius = 22;
            this.txtAdditionalDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditionalDetails.DefaultText = "";
            this.txtAdditionalDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdditionalDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdditionalDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalDetails.Location = new System.Drawing.Point(157, 284);
            this.txtAdditionalDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAdditionalDetails.Multiline = true;
            this.txtAdditionalDetails.Name = "txtAdditionalDetails";
            this.txtAdditionalDetails.PasswordChar = '\0';
            this.txtAdditionalDetails.PlaceholderText = "";
            this.txtAdditionalDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdditionalDetails.SelectedText = "";
            this.txtAdditionalDetails.Size = new System.Drawing.Size(668, 102);
            this.txtAdditionalDetails.TabIndex = 145;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(32, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 169;
            this.label14.Text = "Book ID :";
            // 
            // dtpPublicationDate
            // 
            this.dtpPublicationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.dtpPublicationDate.BorderRadius = 20;
            this.dtpPublicationDate.BorderThickness = 1;
            this.dtpPublicationDate.Checked = true;
            this.dtpPublicationDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.dtpPublicationDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dtpPublicationDate.ForeColor = System.Drawing.Color.White;
            this.dtpPublicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpPublicationDate.Location = new System.Drawing.Point(157, 211);
            this.dtpPublicationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPublicationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPublicationDate.Name = "dtpPublicationDate";
            this.dtpPublicationDate.Size = new System.Drawing.Size(223, 46);
            this.dtpPublicationDate.TabIndex = 144;
            this.dtpPublicationDate.Value = new System.DateTime(2023, 11, 17, 0, 0, 0, 0);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblBookID.ForeColor = System.Drawing.Color.Red;
            this.lblBookID.Location = new System.Drawing.Point(178, 52);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(83, 37);
            this.lblBookID.TabIndex = 168;
            this.lblBookID.Text = "[????]";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.lblTitle.Location = new System.Drawing.Point(418, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 46);
            this.lblTitle.TabIndex = 167;
            this.lblTitle.Text = "Add New Book";
            this.lblTitle.TextChanged += new System.EventHandler(this.lblTitle_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton8);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton4);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton5);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton3);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton2);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton6);
            this.guna2GroupBox1.Controls.Add(this.btnAddNewAuthor);
            this.guna2GroupBox1.Controls.Add(this.cbAuthors);
            this.guna2GroupBox1.Controls.Add(this.btnAddNewGenre);
            this.guna2GroupBox1.Controls.Add(this.cbGenres);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txtISBN);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.btnSave);
            this.guna2GroupBox1.Controls.Add(this.btnClose);
            this.guna2GroupBox1.Controls.Add(this.pbBookImage);
            this.guna2GroupBox1.Controls.Add(this.llbRemoveImage);
            this.guna2GroupBox1.Controls.Add(this.txtAdditionalDetails);
            this.guna2GroupBox1.Controls.Add(this.dtpPublicationDate);
            this.guna2GroupBox1.Controls.Add(this.llbUploadImage);
            this.guna2GroupBox1.Controls.Add(this.txtTitle);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(22, 99);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1087, 485);
            this.guna2GroupBox1.TabIndex = 166;
            // 
            // guna2ImageButton8
            // 
            this.guna2ImageButton8.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton8.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton8.Image = global::LibraryManagementSystem.Properties.Resources._3d_calendar;
            this.guna2ImageButton8.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton8.ImageRotate = 0F;
            this.guna2ImageButton8.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton8.Location = new System.Drawing.Point(111, 217);
            this.guna2ImageButton8.Name = "guna2ImageButton8";
            this.guna2ImageButton8.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton8.TabIndex = 221;
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.Image = global::LibraryManagementSystem.Properties.Resources._3d_notes;
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton4.Location = new System.Drawing.Point(111, 305);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton4.TabIndex = 220;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton5.Image = global::LibraryManagementSystem.Properties.Resources.editor;
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton5.Location = new System.Drawing.Point(478, 217);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.TabIndex = 218;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton3.Image = global::LibraryManagementSystem.Properties.Resources.barcode;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton3.Location = new System.Drawing.Point(111, 140);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.TabIndex = 217;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.Image = global::LibraryManagementSystem.Properties.Resources.info;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton2.Location = new System.Drawing.Point(478, 140);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.TabIndex = 216;
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton6.Image = global::LibraryManagementSystem.Properties.Resources.title;
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton6.Location = new System.Drawing.Point(111, 65);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton6.TabIndex = 215;
            // 
            // btnAddNewAuthor
            // 
            this.btnAddNewAuthor.BorderRadius = 22;
            this.btnAddNewAuthor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewAuthor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewAuthor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewAuthor.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewAuthor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.btnAddNewAuthor.FillColor2 = System.Drawing.Color.SandyBrown;
            this.btnAddNewAuthor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddNewAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddNewAuthor.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddNewAuthor.Location = new System.Drawing.Point(704, 205);
            this.btnAddNewAuthor.Name = "btnAddNewAuthor";
            this.btnAddNewAuthor.Size = new System.Drawing.Size(136, 55);
            this.btnAddNewAuthor.TabIndex = 170;
            this.btnAddNewAuthor.Text = "Add New Author";
            this.btnAddNewAuthor.Click += new System.EventHandler(this.btnAddNewAuthor_Click);
            // 
            // cbAuthors
            // 
            this.cbAuthors.BackColor = System.Drawing.Color.Transparent;
            this.cbAuthors.BorderColor = System.Drawing.Color.Silver;
            this.cbAuthors.BorderRadius = 22;
            this.cbAuthors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthors.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAuthors.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAuthors.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbAuthors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbAuthors.ItemHeight = 40;
            this.cbAuthors.Location = new System.Drawing.Point(519, 211);
            this.cbAuthors.Name = "cbAuthors";
            this.cbAuthors.Size = new System.Drawing.Size(173, 46);
            this.cbAuthors.TabIndex = 169;
            // 
            // btnAddNewGenre
            // 
            this.btnAddNewGenre.BorderRadius = 22;
            this.btnAddNewGenre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewGenre.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewGenre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.btnAddNewGenre.FillColor2 = System.Drawing.Color.SandyBrown;
            this.btnAddNewGenre.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddNewGenre.ForeColor = System.Drawing.Color.White;
            this.btnAddNewGenre.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddNewGenre.Location = new System.Drawing.Point(704, 131);
            this.btnAddNewGenre.Name = "btnAddNewGenre";
            this.btnAddNewGenre.Size = new System.Drawing.Size(136, 55);
            this.btnAddNewGenre.TabIndex = 168;
            this.btnAddNewGenre.Text = "Add New Genre";
            this.btnAddNewGenre.Click += new System.EventHandler(this.btnAddNewGenre_Click);
            // 
            // cbGenres
            // 
            this.cbGenres.BackColor = System.Drawing.Color.Transparent;
            this.cbGenres.BorderColor = System.Drawing.Color.Silver;
            this.cbGenres.BorderRadius = 22;
            this.cbGenres.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenres.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGenres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGenres.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbGenres.ItemHeight = 40;
            this.cbGenres.Location = new System.Drawing.Point(519, 138);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(173, 46);
            this.cbGenres.TabIndex = 167;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(405, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 166;
            this.label2.Text = "Genre : ";
            // 
            // txtISBN
            // 
            this.txtISBN.BorderColor = System.Drawing.Color.Silver;
            this.txtISBN.BorderRadius = 20;
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN.DefaultText = "";
            this.txtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.Location = new System.Drawing.Point(157, 138);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.PlaceholderText = "";
            this.txtISBN.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtISBN.SelectedText = "";
            this.txtISBN.Size = new System.Drawing.Size(223, 46);
            this.txtISBN.TabIndex = 165;
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txtISBN_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 164;
            this.label3.Text = "ISBN :";
            // 
            // llbUploadImage
            // 
            this.llbUploadImage.AutoSize = true;
            this.llbUploadImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbUploadImage.Location = new System.Drawing.Point(932, 346);
            this.llbUploadImage.Name = "llbUploadImage";
            this.llbUploadImage.Size = new System.Drawing.Size(118, 23);
            this.llbUploadImage.TabIndex = 143;
            this.llbUploadImage.TabStop = true;
            this.llbUploadImage.Text = "Upload Image";
            this.llbUploadImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUploadImage_LinkClicked);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderColor = System.Drawing.Color.Silver;
            this.txtTitle.BorderRadius = 20;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(157, 59);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(535, 46);
            this.txtTitle.TabIndex = 134;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(405, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 132;
            this.label8.Text = "Author :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 47);
            this.label6.TabIndex = 130;
            this.label6.Text = "Publication Date :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 61);
            this.label5.TabIndex = 129;
            this.label5.Text = "Additional Details :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "Title :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::LibraryManagementSystem.Properties.Resources.library_card;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton1.Location = new System.Drawing.Point(133, 59);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 219;
            // 
            // frmAddUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 598);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update Book";
            this.Load += new System.EventHandler(this.frmAddEditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.PictureBox pbBookImage;
        private System.Windows.Forms.LinkLabel llbRemoveImage;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalDetails;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPublicationDate;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.LinkLabel llbUploadImage;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNewAuthor;
        private Guna.UI2.WinForms.Guna2ComboBox cbAuthors;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddNewGenre;
        private Guna.UI2.WinForms.Guna2ComboBox cbGenres;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton8;
    }
}