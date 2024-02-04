namespace LibraryManagementSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.pnlContainer = new Sipaa.Framework.SPanel();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnShowUserProfile = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnFines = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnReservations = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrowings = new Guna.UI2.WinForms.Guna2Button();
            this.btnMembers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAuthors = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenres = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 90;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.sPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.sPanel1.BorderRadius = 80;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.Controls.Add(this.btnFines);
            this.sPanel1.Controls.Add(this.btnUsers);
            this.sPanel1.Controls.Add(this.btnReservations);
            this.sPanel1.Controls.Add(this.btnBorrowings);
            this.sPanel1.Controls.Add(this.btnMembers);
            this.sPanel1.Controls.Add(this.btnAuthors);
            this.sPanel1.Controls.Add(this.btnGenres);
            this.sPanel1.Controls.Add(this.btnBooks);
            this.sPanel1.Controls.Add(this.btnDashboard);
            this.sPanel1.Controls.Add(this.guna2PictureBox1);
            this.sPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.sPanel1.Location = new System.Drawing.Point(-71, 100);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(350, 883);
            this.sPanel1.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlContainer.BorderRadius = 6;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.ForeColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(296, 125);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1286, 743);
            this.pnlContainer.TabIndex = 3;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblUserFullName.Location = new System.Drawing.Point(1297, 19);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(76, 21);
            this.lblUserFullName.TabIndex = 5;
            this.lblUserFullName.Text = "Jone Doe";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.lblUserRole.Location = new System.Drawing.Point(1297, 42);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(56, 21);
            this.lblUserRole.TabIndex = 6;
            this.lblUserRole.Text = "Admin";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(1483, 19);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 48);
            this.guna2VSeparator1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::LibraryManagementSystem.Properties.Resources.logout__1_1;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(1553, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 9;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowUserProfile
            // 
            this.btnShowUserProfile.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowUserProfile.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowUserProfile.Image = global::LibraryManagementSystem.Properties.Resources.user_avatar__1_;
            this.btnShowUserProfile.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowUserProfile.ImageRotate = 0F;
            this.btnShowUserProfile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowUserProfile.Location = new System.Drawing.Point(1515, 33);
            this.btnShowUserProfile.Name = "btnShowUserProfile";
            this.btnShowUserProfile.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowUserProfile.Size = new System.Drawing.Size(25, 25);
            this.btnShowUserProfile.TabIndex = 8;
            this.btnShowUserProfile.Click += new System.EventHandler(this.btnShowUserProfile_Click);
            // 
            // pbUserImage
            // 
            this.pbUserImage.Image = global::LibraryManagementSystem.Properties.Resources.man1;
            this.pbUserImage.ImageRotate = 0F;
            this.pbUserImage.Location = new System.Drawing.Point(1401, 9);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserImage.Size = new System.Drawing.Size(64, 64);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserImage.TabIndex = 4;
            this.pbUserImage.TabStop = false;
            // 
            // btnFines
            // 
            this.btnFines.BorderRadius = 23;
            this.btnFines.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFines.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnFines.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.penalty;
            this.btnFines.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFines.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFines.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFines.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFines.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnFines.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFines.ForeColor = System.Drawing.Color.White;
            this.btnFines.HoverState.FillColor = System.Drawing.Color.White;
            this.btnFines.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnFines.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.penalty;
            this.btnFines.Image = global::LibraryManagementSystem.Properties.Resources.penalty__1_;
            this.btnFines.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFines.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnFines.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFines.Location = new System.Drawing.Point(83, 469);
            this.btnFines.Name = "btnFines";
            this.btnFines.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnFines.Size = new System.Drawing.Size(219, 52);
            this.btnFines.TabIndex = 16;
            this.btnFines.Text = "Fines";
            this.btnFines.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFines.TextOffset = new System.Drawing.Point(25, 0);
            this.btnFines.Click += new System.EventHandler(this.btnFines_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BorderRadius = 23;
            this.btnUsers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUsers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnUsers.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.profile;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnUsers.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.profile;
            this.btnUsers.Image = global::LibraryManagementSystem.Properties.Resources.profile__1_;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnUsers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUsers.Location = new System.Drawing.Point(83, 531);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnUsers.Size = new System.Drawing.Size(219, 52);
            this.btnUsers.TabIndex = 14;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.TextOffset = new System.Drawing.Point(40, 0);
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BorderRadius = 23;
            this.btnReservations.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnReservations.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnReservations.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.time_management__1_;
            this.btnReservations.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReservations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReservations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReservations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReservations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.HoverState.FillColor = System.Drawing.Color.White;
            this.btnReservations.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnReservations.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.time_management__1_;
            this.btnReservations.Image = global::LibraryManagementSystem.Properties.Resources.time_management;
            this.btnReservations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReservations.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnReservations.ImageSize = new System.Drawing.Size(26, 26);
            this.btnReservations.Location = new System.Drawing.Point(83, 406);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnReservations.Size = new System.Drawing.Size(219, 52);
            this.btnReservations.TabIndex = 11;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReservations.TextOffset = new System.Drawing.Point(40, 0);
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnBorrowings
            // 
            this.btnBorrowings.BorderRadius = 23;
            this.btnBorrowings.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBorrowings.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnBorrowings.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.book;
            this.btnBorrowings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrowings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrowings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnBorrowings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBorrowings.ForeColor = System.Drawing.Color.White;
            this.btnBorrowings.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBorrowings.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnBorrowings.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.book;
            this.btnBorrowings.Image = global::LibraryManagementSystem.Properties.Resources.book__1_;
            this.btnBorrowings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBorrowings.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnBorrowings.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBorrowings.Location = new System.Drawing.Point(83, 343);
            this.btnBorrowings.Name = "btnBorrowings";
            this.btnBorrowings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnBorrowings.Size = new System.Drawing.Size(219, 52);
            this.btnBorrowings.TabIndex = 10;
            this.btnBorrowings.Text = "Borrowings";
            this.btnBorrowings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBorrowings.TextOffset = new System.Drawing.Point(40, 0);
            this.btnBorrowings.Click += new System.EventHandler(this.btnBorrowings_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BorderRadius = 23;
            this.btnMembers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMembers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnMembers.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.study;
            this.btnMembers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMembers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMembers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMembers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMembers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.HoverState.FillColor = System.Drawing.Color.White;
            this.btnMembers.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnMembers.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.study;
            this.btnMembers.Image = global::LibraryManagementSystem.Properties.Resources.study__1_;
            this.btnMembers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembers.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnMembers.ImageSize = new System.Drawing.Size(26, 26);
            this.btnMembers.Location = new System.Drawing.Point(83, 280);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnMembers.Size = new System.Drawing.Size(219, 52);
            this.btnMembers.TabIndex = 9;
            this.btnMembers.Text = "Members";
            this.btnMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembers.TextOffset = new System.Drawing.Point(40, 0);
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.BorderRadius = 23;
            this.btnAuthors.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAuthors.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnAuthors.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.quill_pen;
            this.btnAuthors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAuthors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAuthors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAuthors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAuthors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnAuthors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAuthors.ForeColor = System.Drawing.Color.White;
            this.btnAuthors.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAuthors.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnAuthors.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.quill_pen;
            this.btnAuthors.Image = global::LibraryManagementSystem.Properties.Resources.quill_pen__1_;
            this.btnAuthors.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAuthors.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnAuthors.ImageSize = new System.Drawing.Size(26, 26);
            this.btnAuthors.Location = new System.Drawing.Point(83, 217);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnAuthors.Size = new System.Drawing.Size(219, 52);
            this.btnAuthors.TabIndex = 8;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAuthors.TextOffset = new System.Drawing.Point(40, 0);
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnGenres
            // 
            this.btnGenres.BorderRadius = 23;
            this.btnGenres.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGenres.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnGenres.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.menu__1_;
            this.btnGenres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenres.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnGenres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenres.ForeColor = System.Drawing.Color.White;
            this.btnGenres.HoverState.FillColor = System.Drawing.Color.White;
            this.btnGenres.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnGenres.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.menu__1_;
            this.btnGenres.Image = global::LibraryManagementSystem.Properties.Resources.menu;
            this.btnGenres.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenres.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnGenres.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGenres.Location = new System.Drawing.Point(83, 154);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnGenres.Size = new System.Drawing.Size(219, 52);
            this.btnGenres.TabIndex = 7;
            this.btnGenres.Text = "Genres";
            this.btnGenres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenres.TextOffset = new System.Drawing.Point(40, 0);
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BorderRadius = 23;
            this.btnBooks.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBooks.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnBooks.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.open_book;
            this.btnBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBooks.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnBooks.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.open_book;
            this.btnBooks.Image = global::LibraryManagementSystem.Properties.Resources.open_book__1_;
            this.btnBooks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooks.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnBooks.ImageSize = new System.Drawing.Size(26, 26);
            this.btnBooks.Location = new System.Drawing.Point(83, 91);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnBooks.Size = new System.Drawing.Size(219, 52);
            this.btnBooks.TabIndex = 6;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooks.TextOffset = new System.Drawing.Point(40, 0);
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 23;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnDashboard.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.dashboard;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnDashboard.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.dashboard;
            this.btnDashboard.Image = global::LibraryManagementSystem.Properties.Resources.dashboard__1_;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.Location = new System.Drawing.Point(83, 28);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnDashboard.Size = new System.Drawing.Size(219, 52);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(40, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.bookworm_high_resolution_logo_transparent__1_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(51, 596);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(307, 225);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1605, 917);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowUserProfile);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblUserFullName);
            this.Controls.Add(this.pbUserImage);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.sPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Sipaa.Framework.SPanel sPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnReservations;
        private Guna.UI2.WinForms.Guna2Button btnBorrowings;
        private Guna.UI2.WinForms.Guna2Button btnMembers;
        private Guna.UI2.WinForms.Guna2Button btnAuthors;
        private Guna.UI2.WinForms.Guna2Button btnGenres;
        private Guna.UI2.WinForms.Guna2Button btnBooks;
        private Sipaa.Framework.SPanel pnlContainer;
        private Guna.UI2.WinForms.Guna2Button btnFines;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserImage;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserFullName;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowUserProfile;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

