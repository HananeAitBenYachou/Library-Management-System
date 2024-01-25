namespace LibraryManagementSystem.Users
{
    partial class frmAddUpdateUser
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.chbIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.ucPersonCardWithFilter1 = new LibraryManagementSystem.People.UserControls.ucPersonCardWithFilter();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tpAccountInfo = new System.Windows.Forms.TabPage();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPermissions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPermissions = new System.Windows.Forms.Panel();
            this.tsManageUsers = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManageMembers = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsAll = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManageBooks = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManageBorrowings = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManageFines = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tsManageReturns = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcUserInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPersonalInfo.SuspendLayout();
            this.tpAccountInfo.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            this.pnlPermissions.SuspendLayout();
            this.tcUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.lblTitle.Location = new System.Drawing.Point(382, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 46);
            this.lblTitle.TabIndex = 164;
            this.lblTitle.Text = "Add New User";
            this.lblTitle.TextChanged += new System.EventHandler(this.lblTitle_TextChanged);
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Checked = true;
            this.chbIsActive.CheckedState.BorderColor = System.Drawing.Color.SandyBrown;
            this.chbIsActive.CheckedState.BorderRadius = 0;
            this.chbIsActive.CheckedState.BorderThickness = 0;
            this.chbIsActive.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.chbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chbIsActive.Location = new System.Drawing.Point(556, 139);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(115, 32);
            this.chbIsActive.TabIndex = 183;
            this.chbIsActive.Text = "Is Active";
            this.chbIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbIsActive.UncheckedState.BorderRadius = 0;
            this.chbIsActive.UncheckedState.BorderThickness = 0;
            this.chbIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.Color.Red;
            this.lblUserID.Location = new System.Drawing.Point(574, 22);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(62, 28);
            this.lblUserID.TabIndex = 173;
            this.lblUserID.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(297, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 171;
            this.label2.Text = "User ID :";
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonalInfo.Controls.Add(this.ucPersonCardWithFilter1);
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 54);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(1007, 549);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            // 
            // ucPersonCardWithFilter1
            // 
            this.ucPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ucPersonCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ucPersonCardWithFilter1.FilterEnabled = true;
            this.ucPersonCardWithFilter1.Location = new System.Drawing.Point(11, 13);
            this.ucPersonCardWithFilter1.Name = "ucPersonCardWithFilter1";
            this.ucPersonCardWithFilter1.Size = new System.Drawing.Size(983, 467);
            this.ucPersonCardWithFilter1.TabIndex = 167;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 22;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.btnNext.FillColor2 = System.Drawing.Color.SandyBrown;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::LibraryManagementSystem.Properties.Resources.right_arrow;
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNext.Location = new System.Drawing.Point(817, 486);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(177, 54);
            this.btnNext.TabIndex = 166;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpAccountInfo
            // 
            this.tpAccountInfo.BackColor = System.Drawing.Color.White;
            this.tpAccountInfo.Controls.Add(this.guna2ImageButton2);
            this.tpAccountInfo.Controls.Add(this.label3);
            this.tpAccountInfo.Controls.Add(this.gbPermissions);
            this.tpAccountInfo.Controls.Add(this.guna2ImageButton1);
            this.tpAccountInfo.Controls.Add(this.guna2ImageButton3);
            this.tpAccountInfo.Controls.Add(this.txtUserName);
            this.tpAccountInfo.Controls.Add(this.chbIsActive);
            this.tpAccountInfo.Controls.Add(this.label1);
            this.tpAccountInfo.Controls.Add(this.lblUserID);
            this.tpAccountInfo.Controls.Add(this.label2);
            this.tpAccountInfo.Location = new System.Drawing.Point(4, 54);
            this.tpAccountInfo.Name = "tpAccountInfo";
            this.tpAccountInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountInfo.Size = new System.Drawing.Size(1007, 549);
            this.tpAccountInfo.TabIndex = 1;
            this.tpAccountInfo.Text = "Account Info";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.Image = global::LibraryManagementSystem.Properties.Resources.yes_or_no;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.Location = new System.Drawing.Point(477, 131);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.TabIndex = 191;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(297, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 190;
            this.label3.Text = "Account Status :";
            // 
            // gbPermissions
            // 
            this.gbPermissions.BorderRadius = 23;
            this.gbPermissions.Controls.Add(this.label10);
            this.gbPermissions.Controls.Add(this.label9);
            this.gbPermissions.Controls.Add(this.label8);
            this.gbPermissions.Controls.Add(this.label7);
            this.gbPermissions.Controls.Add(this.label6);
            this.gbPermissions.Controls.Add(this.label5);
            this.gbPermissions.Controls.Add(this.label4);
            this.gbPermissions.Controls.Add(this.pnlPermissions);
            this.gbPermissions.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.gbPermissions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbPermissions.ForeColor = System.Drawing.Color.Black;
            this.gbPermissions.Location = new System.Drawing.Point(343, 188);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(352, 348);
            this.gbPermissions.TabIndex = 189;
            this.gbPermissions.Text = "Permissions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(38, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 23);
            this.label10.TabIndex = 206;
            this.label10.Text = "All";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(38, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 204;
            this.label9.Text = "Manage Fines";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 23);
            this.label8.TabIndex = 202;
            this.label8.Text = "Manage Reservations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 23);
            this.label7.TabIndex = 200;
            this.label7.Text = "Manage Borrowings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 198;
            this.label6.Text = "Manage Books";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 196;
            this.label5.Text = "Manage Members";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 194;
            this.label4.Text = "Manage Users";
            // 
            // pnlPermissions
            // 
            this.pnlPermissions.Controls.Add(this.tsManageUsers);
            this.pnlPermissions.Controls.Add(this.tsManageMembers);
            this.pnlPermissions.Controls.Add(this.tsAll);
            this.pnlPermissions.Controls.Add(this.tsManageBooks);
            this.pnlPermissions.Controls.Add(this.tsManageBorrowings);
            this.pnlPermissions.Controls.Add(this.tsManageFines);
            this.pnlPermissions.Controls.Add(this.tsManageReturns);
            this.pnlPermissions.Location = new System.Drawing.Point(236, 44);
            this.pnlPermissions.Name = "pnlPermissions";
            this.pnlPermissions.Size = new System.Drawing.Size(105, 288);
            this.pnlPermissions.TabIndex = 207;
            // 
            // tsManageUsers
            // 
            this.tsManageUsers.CheckedState.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tsManageUsers.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.tsManageUsers.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageUsers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageUsers.Location = new System.Drawing.Point(27, 12);
            this.tsManageUsers.Name = "tsManageUsers";
            this.tsManageUsers.Size = new System.Drawing.Size(57, 23);
            this.tsManageUsers.TabIndex = 193;
            this.tsManageUsers.Tag = "1";
            this.tsManageUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageUsers.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageUsers.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManageMembers
            // 
            this.tsManageMembers.CheckedState.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tsManageMembers.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.tsManageMembers.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageMembers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageMembers.Location = new System.Drawing.Point(27, 53);
            this.tsManageMembers.Name = "tsManageMembers";
            this.tsManageMembers.Size = new System.Drawing.Size(57, 23);
            this.tsManageMembers.TabIndex = 195;
            this.tsManageMembers.Tag = "2";
            this.tsManageMembers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageMembers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageMembers.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageMembers.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsAll
            // 
            this.tsAll.CheckedState.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tsAll.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.tsAll.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsAll.Location = new System.Drawing.Point(27, 257);
            this.tsAll.Name = "tsAll";
            this.tsAll.Size = new System.Drawing.Size(57, 23);
            this.tsAll.TabIndex = 205;
            this.tsAll.Tag = "-1";
            this.tsAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsAll.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsAll.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsAll.CheckedChanged += new System.EventHandler(this.tsAll_CheckedChanged);
            // 
            // tsManageBooks
            // 
            this.tsManageBooks.CheckedState.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tsManageBooks.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.tsManageBooks.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageBooks.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageBooks.Location = new System.Drawing.Point(27, 96);
            this.tsManageBooks.Name = "tsManageBooks";
            this.tsManageBooks.Size = new System.Drawing.Size(57, 23);
            this.tsManageBooks.TabIndex = 197;
            this.tsManageBooks.Tag = "4";
            this.tsManageBooks.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageBooks.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageBooks.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageBooks.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManageBorrowings
            // 
            this.tsManageBorrowings.CheckedState.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tsManageBorrowings.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.tsManageBorrowings.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageBorrowings.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageBorrowings.Location = new System.Drawing.Point(27, 134);
            this.tsManageBorrowings.Name = "tsManageBorrowings";
            this.tsManageBorrowings.Size = new System.Drawing.Size(57, 23);
            this.tsManageBorrowings.TabIndex = 199;
            this.tsManageBorrowings.Tag = "8";
            this.tsManageBorrowings.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageBorrowings.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageBorrowings.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageBorrowings.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManageFines
            // 
            this.tsManageFines.CheckedState.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tsManageFines.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.tsManageFines.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageFines.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageFines.Location = new System.Drawing.Point(27, 215);
            this.tsManageFines.Name = "tsManageFines";
            this.tsManageFines.Size = new System.Drawing.Size(57, 23);
            this.tsManageFines.TabIndex = 203;
            this.tsManageFines.Tag = "32";
            this.tsManageFines.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageFines.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageFines.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageFines.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tsManageReturns
            // 
            this.tsManageReturns.CheckedState.BorderColor = System.Drawing.SystemColors.Highlight;
            this.tsManageReturns.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.tsManageReturns.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageReturns.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageReturns.Location = new System.Drawing.Point(27, 176);
            this.tsManageReturns.Name = "tsManageReturns";
            this.tsManageReturns.Size = new System.Drawing.Size(57, 23);
            this.tsManageReturns.TabIndex = 201;
            this.tsManageReturns.Tag = "16";
            this.tsManageReturns.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageReturns.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageReturns.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageReturns.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::LibraryManagementSystem.Properties.Resources.id;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(477, 18);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 186;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton3.Image = global::LibraryManagementSystem.Properties.Resources.student_card;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.Location = new System.Drawing.Point(477, 73);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.TabIndex = 185;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.BorderRadius = 20;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(521, 69);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(223, 46);
            this.txtUserName.TabIndex = 184;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(297, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 174;
            this.label1.Text = "User Name :";
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tpPersonalInfo);
            this.tcUserInfo.Controls.Add(this.tpAccountInfo);
            this.tcUserInfo.ItemSize = new System.Drawing.Size(180, 50);
            this.tcUserInfo.Location = new System.Drawing.Point(10, 64);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(1015, 607);
            this.tcUserInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcUserInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcUserInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcUserInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcUserInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcUserInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.tcUserInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcUserInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.SandyBrown;
            this.tcUserInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcUserInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcUserInfo.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcUserInfo.TabIndex = 163;
            this.tcUserInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcUserInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
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
            this.btnSave.Location = new System.Drawing.Point(844, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 54);
            this.btnSave.TabIndex = 166;
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
            this.btnClose.Location = new System.Drawing.Point(644, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 54);
            this.btnClose.TabIndex = 165;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 747);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tcUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update User";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpAccountInfo.ResumeLayout(false);
            this.tpAccountInfo.PerformLayout();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.pnlPermissions.ResumeLayout(false);
            this.tcUserInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpAccountInfo;
        private Guna.UI2.WinForms.Guna2CheckBox chbIsActive;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2GroupBox gbPermissions;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageUsers;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsAll;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageFines;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageReturns;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageBorrowings;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageBooks;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPermissions;
        private People.UserControls.ucPersonCardWithFilter ucPersonCardWithFilter1;
    }
}