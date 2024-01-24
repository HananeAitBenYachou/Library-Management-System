namespace LibraryManagementSystem.People
{
    partial class frmAddUpdatePerson
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
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.iconPassword = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.llbRemoveImage = new System.Windows.Forms.LinkLabel();
            this.guna2ImageButton9 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton8 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton7 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.llbUploadImage = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbMale = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbFemale = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPhoneNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNationalNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2ImageButton10 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblPersonID.ForeColor = System.Drawing.Color.Red;
            this.lblPersonID.Location = new System.Drawing.Point(198, 57);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(83, 37);
            this.lblPersonID.TabIndex = 163;
            this.lblPersonID.Text = "[????]";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.lblTitle.Location = new System.Drawing.Point(377, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 46);
            this.lblTitle.TabIndex = 162;
            this.lblTitle.Text = "Add New Person";
            this.lblTitle.TextChanged += new System.EventHandler(this.lblTitle_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.guna2GroupBox1.Controls.Add(this.iconPassword);
            this.guna2GroupBox1.Controls.Add(this.lblPassword);
            this.guna2GroupBox1.Controls.Add(this.txtPassword);
            this.guna2GroupBox1.Controls.Add(this.btnSave);
            this.guna2GroupBox1.Controls.Add(this.btnClose);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.pbPersonImage);
            this.guna2GroupBox1.Controls.Add(this.llbRemoveImage);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton9);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton8);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton7);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton6);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton5);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton4);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton3);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton2);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton1);
            this.guna2GroupBox1.Controls.Add(this.txtAddress);
            this.guna2GroupBox1.Controls.Add(this.dtpBirthDate);
            this.guna2GroupBox1.Controls.Add(this.llbUploadImage);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.rbMale);
            this.guna2GroupBox1.Controls.Add(this.rbFemale);
            this.guna2GroupBox1.Controls.Add(this.cbCountries);
            this.guna2GroupBox1.Controls.Add(this.txtPhoneNo);
            this.guna2GroupBox1.Controls.Add(this.txtLastName);
            this.guna2GroupBox1.Controls.Add(this.txtEmail);
            this.guna2GroupBox1.Controls.Add(this.txtNationalNo);
            this.guna2GroupBox1.Controls.Add(this.txtFirstName);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 102);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1008, 492);
            this.guna2GroupBox1.TabIndex = 161;
            // 
            // iconPassword
            // 
            this.iconPassword.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.iconPassword.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.iconPassword.Image = global::LibraryManagementSystem.Properties.Resources.password;
            this.iconPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.iconPassword.ImageRotate = 0F;
            this.iconPassword.ImageSize = new System.Drawing.Size(28, 28);
            this.iconPassword.Location = new System.Drawing.Point(509, 311);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(30, 30);
            this.iconPassword.TabIndex = 162;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(411, 315);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 20);
            this.lblPassword.TabIndex = 161;
            this.lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 22;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(553, 306);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(223, 46);
            this.txtPassword.TabIndex = 160;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
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
            this.btnSave.Location = new System.Drawing.Point(570, 394);
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
            this.btnClose.Location = new System.Drawing.Point(370, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 54);
            this.btnClose.TabIndex = 158;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(230, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 157;
            this.label12.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(628, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 156;
            this.label11.Text = "Last Name ";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::LibraryManagementSystem.Properties.Resources.man;
            this.pbPersonImage.Location = new System.Drawing.Point(801, 71);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(190, 241);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 154;
            this.pbPersonImage.TabStop = false;
            // 
            // llbRemoveImage
            // 
            this.llbRemoveImage.AutoSize = true;
            this.llbRemoveImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbRemoveImage.Location = new System.Drawing.Point(837, 355);
            this.llbRemoveImage.Name = "llbRemoveImage";
            this.llbRemoveImage.Size = new System.Drawing.Size(126, 23);
            this.llbRemoveImage.TabIndex = 155;
            this.llbRemoveImage.TabStop = true;
            this.llbRemoveImage.Text = "Remove Image";
            this.llbRemoveImage.Visible = false;
            this.llbRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRemoveImage_LinkClicked);
            // 
            // guna2ImageButton9
            // 
            this.guna2ImageButton9.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton9.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton9.Image = global::LibraryManagementSystem.Properties.Resources.female;
            this.guna2ImageButton9.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton9.ImageRotate = 0F;
            this.guna2ImageButton9.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton9.Location = new System.Drawing.Point(254, 128);
            this.guna2ImageButton9.Name = "guna2ImageButton9";
            this.guna2ImageButton9.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton9.TabIndex = 153;
            // 
            // guna2ImageButton8
            // 
            this.guna2ImageButton8.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton8.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton8.Image = global::LibraryManagementSystem.Properties.Resources._3d_calendar;
            this.guna2ImageButton8.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton8.ImageRotate = 0F;
            this.guna2ImageButton8.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton8.Location = new System.Drawing.Point(509, 129);
            this.guna2ImageButton8.Name = "guna2ImageButton8";
            this.guna2ImageButton8.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton8.TabIndex = 152;
            // 
            // guna2ImageButton7
            // 
            this.guna2ImageButton7.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton7.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton7.Image = global::LibraryManagementSystem.Properties.Resources.phone;
            this.guna2ImageButton7.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton7.ImageRotate = 0F;
            this.guna2ImageButton7.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton7.Location = new System.Drawing.Point(509, 184);
            this.guna2ImageButton7.Name = "guna2ImageButton7";
            this.guna2ImageButton7.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton7.TabIndex = 151;
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton6.Image = global::LibraryManagementSystem.Properties.Resources.navigation;
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton6.Location = new System.Drawing.Point(509, 246);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton6.TabIndex = 150;
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton5.Image = global::LibraryManagementSystem.Properties.Resources._3d_map;
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton5.Location = new System.Drawing.Point(123, 311);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.TabIndex = 149;
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.Image = global::LibraryManagementSystem.Properties.Resources.gmail;
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.Location = new System.Drawing.Point(123, 184);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton4.TabIndex = 125;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton3.Image = global::LibraryManagementSystem.Properties.Resources.male;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton3.Location = new System.Drawing.Point(123, 129);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.TabIndex = 148;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.Image = global::LibraryManagementSystem.Properties.Resources.id_card1;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.Location = new System.Drawing.Point(123, 243);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.TabIndex = 147;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::LibraryManagementSystem.Properties.Resources.user;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(123, 71);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 146;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.BorderRadius = 22;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(163, 306);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(223, 46);
            this.txtAddress.TabIndex = 145;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.dtpBirthDate.BorderRadius = 20;
            this.dtpBirthDate.BorderThickness = 1;
            this.dtpBirthDate.Checked = true;
            this.dtpBirthDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dtpBirthDate.ForeColor = System.Drawing.Color.White;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthDate.Location = new System.Drawing.Point(553, 119);
            this.dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(223, 46);
            this.dtpBirthDate.TabIndex = 144;
            this.dtpBirthDate.Value = new System.DateTime(2023, 11, 17, 0, 0, 0, 0);
            // 
            // llbUploadImage
            // 
            this.llbUploadImage.AutoSize = true;
            this.llbUploadImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbUploadImage.Location = new System.Drawing.Point(841, 325);
            this.llbUploadImage.Name = "llbUploadImage";
            this.llbUploadImage.Size = new System.Drawing.Size(118, 23);
            this.llbUploadImage.TabIndex = 143;
            this.llbUploadImage.TabStop = true;
            this.llbUploadImage.Text = "Upload Image";
            this.llbUploadImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUploadImage_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(318, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 142;
            this.label10.Text = "Female";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(198, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 141;
            this.label9.Text = "Male";
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.CheckedState.BorderColor = System.Drawing.Color.SandyBrown;
            this.rbMale.CheckedState.BorderThickness = 0;
            this.rbMale.CheckedState.FillColor = System.Drawing.Color.SandyBrown;
            this.rbMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(170, 133);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(31, 24);
            this.rbMale.TabIndex = 140;
            this.rbMale.Text = "guna2CustomRadioButton2";
            this.rbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.rbMale.UncheckedState.BorderThickness = 2;
            this.rbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.CheckedState.BorderColor = System.Drawing.Color.SandyBrown;
            this.rbFemale.CheckedState.BorderThickness = 0;
            this.rbFemale.CheckedState.FillColor = System.Drawing.Color.SandyBrown;
            this.rbFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(290, 133);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(31, 24);
            this.rbFemale.TabIndex = 139;
            this.rbFemale.Text = "guna2CustomRadioButton1";
            this.rbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.rbFemale.UncheckedState.BorderThickness = 2;
            this.rbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
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
            this.cbCountries.Location = new System.Drawing.Point(553, 242);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(223, 46);
            this.cbCountries.TabIndex = 138;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderColor = System.Drawing.Color.Silver;
            this.txtPhoneNo.BorderRadius = 20;
            this.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNo.DefaultText = "";
            this.txtPhoneNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNo.Location = new System.Drawing.Point(553, 178);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPhoneNo.Multiline = true;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PasswordChar = '\0';
            this.txtPhoneNo.PlaceholderText = "";
            this.txtPhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPhoneNo.SelectedText = "";
            this.txtPhoneNo.Size = new System.Drawing.Size(223, 46);
            this.txtPhoneNo.TabIndex = 137;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            this.txtPhoneNo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderColor = System.Drawing.Color.Silver;
            this.txtLastName.BorderRadius = 20;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(553, 65);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(223, 46);
            this.txtLastName.TabIndex = 136;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 20;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(163, 178);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(223, 46);
            this.txtEmail.TabIndex = 135;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.BorderColor = System.Drawing.Color.Silver;
            this.txtNationalNo.BorderRadius = 20;
            this.txtNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalNo.DefaultText = "";
            this.txtNationalNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationalNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationalNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNationalNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.Location = new System.Drawing.Point(163, 242);
            this.txtNationalNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNationalNo.Multiline = true;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.PasswordChar = '\0';
            this.txtNationalNo.PlaceholderText = "";
            this.txtNationalNo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNationalNo.SelectedText = "";
            this.txtNationalNo.Size = new System.Drawing.Size(223, 46);
            this.txtNationalNo.TabIndex = 133;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderColor = System.Drawing.Color.Silver;
            this.txtFirstName.BorderRadius = 20;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(163, 65);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(223, 46);
            this.txtFirstName.TabIndex = 134;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(411, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 132;
            this.label8.Text = "Country :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(411, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 131;
            this.label7.Text = "Phone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(411, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 130;
            this.label6.Text = "Birth Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 128;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 127;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "National No : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "Name : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(28, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 164;
            this.label14.Text = "Person ID :";
            // 
            // guna2ImageButton10
            // 
            this.guna2ImageButton10.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton10.Image = global::LibraryManagementSystem.Properties.Resources.id;
            this.guna2ImageButton10.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton10.ImageRotate = 0F;
            this.guna2ImageButton10.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.Location = new System.Drawing.Point(137, 62);
            this.guna2ImageButton10.Name = "guna2ImageButton10";
            this.guna2ImageButton10.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.TabIndex = 165;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 606);
            this.Controls.Add(this.guna2ImageButton10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person Info";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.LinkLabel llbRemoveImage;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton9;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton8;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton7;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private System.Windows.Forms.LinkLabel llbUploadImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbMale;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbFemale;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNo;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalNo;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ImageButton iconPassword;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}