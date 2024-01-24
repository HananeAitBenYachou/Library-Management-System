namespace LibraryManagementSystem.Reservations
{
    partial class frmAddUpdateReservation
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
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcReservationInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpBookInfo = new System.Windows.Forms.TabPage();
            this.ucBookCardWithFilter1 = new LibraryManagementSystem.Books.UserControls.ucBookCardWithFilter();
            this.btnToSecondPage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tpMemberInfo = new System.Windows.Forms.TabPage();
            this.ucMemberCardWithFilter1 = new LibraryManagementSystem.Members.UserControls.ucMemberCardWithFilter();
            this.btnToLastPage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tpReservationInfo = new System.Windows.Forms.TabPage();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReservationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tcReservationInfo.SuspendLayout();
            this.tpBookInfo.SuspendLayout();
            this.tpMemberInfo.SuspendLayout();
            this.tpReservationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnClose.Location = new System.Drawing.Point(629, 831);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 54);
            this.btnClose.TabIndex = 173;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(829, 831);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 54);
            this.btnSave.TabIndex = 174;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.lblTitle.Location = new System.Drawing.Point(330, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(372, 46);
            this.lblTitle.TabIndex = 172;
            this.lblTitle.Text = "Add New Reservation ";
            // 
            // tcReservationInfo
            // 
            this.tcReservationInfo.Controls.Add(this.tpBookInfo);
            this.tcReservationInfo.Controls.Add(this.tpMemberInfo);
            this.tcReservationInfo.Controls.Add(this.tpReservationInfo);
            this.tcReservationInfo.ItemSize = new System.Drawing.Size(180, 50);
            this.tcReservationInfo.Location = new System.Drawing.Point(12, 62);
            this.tcReservationInfo.Name = "tcReservationInfo";
            this.tcReservationInfo.SelectedIndex = 0;
            this.tcReservationInfo.Size = new System.Drawing.Size(1015, 765);
            this.tcReservationInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservationInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcReservationInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcReservationInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcReservationInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcReservationInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservationInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcReservationInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReservationInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.tcReservationInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcReservationInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservationInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.SandyBrown;
            this.tcReservationInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReservationInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcReservationInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcReservationInfo.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcReservationInfo.TabIndex = 175;
            this.tcReservationInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.tcReservationInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpBookInfo
            // 
            this.tpBookInfo.BackColor = System.Drawing.Color.White;
            this.tpBookInfo.Controls.Add(this.ucBookCardWithFilter1);
            this.tpBookInfo.Controls.Add(this.btnToSecondPage);
            this.tpBookInfo.Location = new System.Drawing.Point(4, 54);
            this.tpBookInfo.Name = "tpBookInfo";
            this.tpBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookInfo.Size = new System.Drawing.Size(1007, 707);
            this.tpBookInfo.TabIndex = 0;
            this.tpBookInfo.Text = "Book Info";
            // 
            // ucBookCardWithFilter1
            // 
            this.ucBookCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ucBookCardWithFilter1.FilterEnabled = true;
            this.ucBookCardWithFilter1.Location = new System.Drawing.Point(11, 74);
            this.ucBookCardWithFilter1.Name = "ucBookCardWithFilter1";
            this.ucBookCardWithFilter1.Size = new System.Drawing.Size(983, 517);
            this.ucBookCardWithFilter1.TabIndex = 167;
            // 
            // btnToSecondPage
            // 
            this.btnToSecondPage.BorderRadius = 22;
            this.btnToSecondPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToSecondPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToSecondPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToSecondPage.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToSecondPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToSecondPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.btnToSecondPage.FillColor2 = System.Drawing.Color.SandyBrown;
            this.btnToSecondPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToSecondPage.ForeColor = System.Drawing.Color.White;
            this.btnToSecondPage.Image = global::LibraryManagementSystem.Properties.Resources.right_arrow;
            this.btnToSecondPage.ImageSize = new System.Drawing.Size(25, 25);
            this.btnToSecondPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnToSecondPage.Location = new System.Drawing.Point(813, 641);
            this.btnToSecondPage.Name = "btnToSecondPage";
            this.btnToSecondPage.Size = new System.Drawing.Size(177, 54);
            this.btnToSecondPage.TabIndex = 166;
            this.btnToSecondPage.Text = "Next";
            this.btnToSecondPage.Click += new System.EventHandler(this.btnToSecondPage_Click);
            // 
            // tpMemberInfo
            // 
            this.tpMemberInfo.BackColor = System.Drawing.Color.White;
            this.tpMemberInfo.Controls.Add(this.ucMemberCardWithFilter1);
            this.tpMemberInfo.Controls.Add(this.btnToLastPage);
            this.tpMemberInfo.Location = new System.Drawing.Point(4, 54);
            this.tpMemberInfo.Name = "tpMemberInfo";
            this.tpMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemberInfo.Size = new System.Drawing.Size(1007, 707);
            this.tpMemberInfo.TabIndex = 1;
            this.tpMemberInfo.Text = "Member Info";
            // 
            // ucMemberCardWithFilter1
            // 
            this.ucMemberCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ucMemberCardWithFilter1.FilterEnabled = true;
            this.ucMemberCardWithFilter1.Location = new System.Drawing.Point(12, 11);
            this.ucMemberCardWithFilter1.Name = "ucMemberCardWithFilter1";
            this.ucMemberCardWithFilter1.Size = new System.Drawing.Size(984, 624);
            this.ucMemberCardWithFilter1.TabIndex = 168;
            // 
            // btnToLastPage
            // 
            this.btnToLastPage.BorderRadius = 22;
            this.btnToLastPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToLastPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToLastPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToLastPage.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToLastPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToLastPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.btnToLastPage.FillColor2 = System.Drawing.Color.SandyBrown;
            this.btnToLastPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLastPage.ForeColor = System.Drawing.Color.White;
            this.btnToLastPage.Image = global::LibraryManagementSystem.Properties.Resources.right_arrow;
            this.btnToLastPage.ImageSize = new System.Drawing.Size(25, 25);
            this.btnToLastPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnToLastPage.Location = new System.Drawing.Point(813, 644);
            this.btnToLastPage.Name = "btnToLastPage";
            this.btnToLastPage.Size = new System.Drawing.Size(177, 54);
            this.btnToLastPage.TabIndex = 167;
            this.btnToLastPage.Text = "Next";
            this.btnToLastPage.Click += new System.EventHandler(this.btnToLastPage_Click);
            // 
            // tpReservationInfo
            // 
            this.tpReservationInfo.Controls.Add(this.guna2ImageButton1);
            this.tpReservationInfo.Controls.Add(this.label1);
            this.tpReservationInfo.Controls.Add(this.dtpReservationDate);
            this.tpReservationInfo.Controls.Add(this.guna2ImageButton5);
            this.tpReservationInfo.Controls.Add(this.lblReservationID);
            this.tpReservationInfo.Controls.Add(this.label7);
            this.tpReservationInfo.Location = new System.Drawing.Point(4, 54);
            this.tpReservationInfo.Name = "tpReservationInfo";
            this.tpReservationInfo.Size = new System.Drawing.Size(1007, 707);
            this.tpReservationInfo.TabIndex = 2;
            this.tpReservationInfo.Text = "Reservation Info";
            this.tpReservationInfo.UseVisualStyleBackColor = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::LibraryManagementSystem.Properties.Resources._3d_calendar;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(476, 189);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 201;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(288, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 200;
            this.label1.Text = "Reservation Date :";
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.dtpReservationDate.BorderRadius = 20;
            this.dtpReservationDate.BorderThickness = 1;
            this.dtpReservationDate.Checked = true;
            this.dtpReservationDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.dtpReservationDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dtpReservationDate.ForeColor = System.Drawing.Color.White;
            this.dtpReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpReservationDate.Location = new System.Drawing.Point(538, 185);
            this.dtpReservationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpReservationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.Size = new System.Drawing.Size(223, 46);
            this.dtpReservationDate.TabIndex = 199;
            this.dtpReservationDate.Value = new System.DateTime(2023, 11, 17, 0, 0, 0, 0);
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton5.Image = global::LibraryManagementSystem.Properties.Resources.id;
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.Location = new System.Drawing.Point(476, 105);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.TabIndex = 198;
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservationID.ForeColor = System.Drawing.Color.Red;
            this.lblReservationID.Location = new System.Drawing.Point(591, 104);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(62, 28);
            this.lblReservationID.TabIndex = 193;
            this.lblReservationID.Text = "[????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(288, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 192;
            this.label7.Text = "Reservation ID :";
            // 
            // frmAddUpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 896);
            this.Controls.Add(this.tcReservationInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update Reservation";
            this.Load += new System.EventHandler(this.frmAddUpdateReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tcReservationInfo.ResumeLayout(false);
            this.tpBookInfo.ResumeLayout(false);
            this.tpMemberInfo.ResumeLayout(false);
            this.tpReservationInfo.ResumeLayout(false);
            this.tpReservationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcReservationInfo;
        private System.Windows.Forms.TabPage tpBookInfo;
        private Books.UserControls.ucBookCardWithFilter ucBookCardWithFilter1;
        private Guna.UI2.WinForms.Guna2GradientButton btnToSecondPage;
        private System.Windows.Forms.TabPage tpMemberInfo;
        private Members.UserControls.ucMemberCardWithFilter ucMemberCardWithFilter1;
        private Guna.UI2.WinForms.Guna2GradientButton btnToLastPage;
        private System.Windows.Forms.TabPage tpReservationInfo;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReservationDate;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label label7;
    }
}