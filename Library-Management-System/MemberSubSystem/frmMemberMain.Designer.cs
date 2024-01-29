namespace LibraryManagementSystem
{
    partial class frmMemberMain
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.btnFines = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnReservations = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrowings = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContainer = new Sipaa.Framework.SPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.sPanel1.Controls.Add(this.btnLogout);
            this.sPanel1.Controls.Add(this.btnReservations);
            this.sPanel1.Controls.Add(this.btnBorrowings);
            this.sPanel1.Controls.Add(this.btnBooks);
            this.sPanel1.Controls.Add(this.btnDashboard);
            this.sPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.sPanel1.Location = new System.Drawing.Point(-71, 102);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(350, 868);
            this.sPanel1.TabIndex = 4;
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
            this.btnFines.Location = new System.Drawing.Point(83, 296);
            this.btnFines.Name = "btnFines";
            this.btnFines.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnFines.Size = new System.Drawing.Size(219, 52);
            this.btnFines.TabIndex = 16;
            this.btnFines.Text = "Fines";
            this.btnFines.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFines.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 23;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnLogout.CheckedState.Image = global::LibraryManagementSystem.Properties.Resources.logout__1_;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnLogout.HoverState.Image = global::LibraryManagementSystem.Properties.Resources.logout__1_;
            this.btnLogout.Image = global::LibraryManagementSystem.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(83, 739);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnLogout.Size = new System.Drawing.Size(219, 52);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(40, 0);
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
            this.btnReservations.Location = new System.Drawing.Point(80, 234);
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
            this.btnBorrowings.Location = new System.Drawing.Point(80, 172);
            this.btnBorrowings.Name = "btnBorrowings";
            this.btnBorrowings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnBorrowings.Size = new System.Drawing.Size(219, 52);
            this.btnBorrowings.TabIndex = 10;
            this.btnBorrowings.Text = "Borrowings";
            this.btnBorrowings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBorrowings.TextOffset = new System.Drawing.Point(40, 0);
            this.btnBorrowings.Click += new System.EventHandler(this.btnBorrowings_Click);
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
            this.btnBooks.Location = new System.Drawing.Point(80, 110);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnBooks.Size = new System.Drawing.Size(219, 52);
            this.btnBooks.TabIndex = 6;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooks.TextOffset = new System.Drawing.Point(40, 0);
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
            this.btnDashboard.Location = new System.Drawing.Point(80, 48);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(187)))));
            this.btnDashboard.Size = new System.Drawing.Size(219, 52);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlContainer.BorderRadius = 6;
            this.pnlContainer.BorderSize = 0;
            this.pnlContainer.ForeColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(296, 150);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1286, 743);
            this.pnlContainer.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.bookworm_high_resolution_logo_transparent__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMemberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1605, 917);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemberMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2Button btnFines;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnReservations;
        private Guna.UI2.WinForms.Guna2Button btnBorrowings;
        private Guna.UI2.WinForms.Guna2Button btnBooks;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Sipaa.Framework.SPanel pnlContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}