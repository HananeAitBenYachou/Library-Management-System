namespace LibraryManagementSystem.MemberSubSystem.Books.UserControls
{
    partial class ucBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.btnViewBookDetails = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.btnBorrowBook = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBookTitle.Location = new System.Drawing.Point(132, 197);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(47, 24);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Title";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblAuthorName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAuthorName.Location = new System.Drawing.Point(28, 227);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(105, 21);
            this.lblAuthorName.TabIndex = 2;
            this.lblAuthorName.Text = "Author Name";
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.BorderRadius = 17;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.Controls.Add(this.btnViewBookDetails);
            this.sPanel1.Controls.Add(this.pbBookImage);
            this.sPanel1.Controls.Add(this.btnBorrowBook);
            this.sPanel1.Controls.Add(this.lblBookTitle);
            this.sPanel1.Controls.Add(this.lblAuthorName);
            this.sPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(0, 0);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(316, 328);
            this.sPanel1.TabIndex = 5;
            // 
            // btnViewBookDetails
            // 
            this.btnViewBookDetails.BorderRadius = 15;
            this.btnViewBookDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewBookDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewBookDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewBookDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewBookDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewBookDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnViewBookDetails.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnViewBookDetails.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBookDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewBookDetails.Image = global::LibraryManagementSystem.Properties.Resources.search_file;
            this.btnViewBookDetails.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewBookDetails.Location = new System.Drawing.Point(138, 263);
            this.btnViewBookDetails.Name = "btnViewBookDetails";
            this.btnViewBookDetails.Size = new System.Drawing.Size(165, 45);
            this.btnViewBookDetails.TabIndex = 4;
            this.btnViewBookDetails.Text = "View Details";
            this.btnViewBookDetails.Click += new System.EventHandler(this.btnViewBookDetails_Click);
            // 
            // pbBookImage
            // 
            this.pbBookImage.Image = global::LibraryManagementSystem.Properties.Resources.book1;
            this.pbBookImage.Location = new System.Drawing.Point(80, 8);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(154, 174);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookImage.TabIndex = 0;
            this.pbBookImage.TabStop = false;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BorderRadius = 15;
            this.btnBorrowBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrowBook.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrowBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrowBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnBorrowBook.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnBorrowBook.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.btnBorrowBook.Image = global::LibraryManagementSystem.Properties.Resources.book3;
            this.btnBorrowBook.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBorrowBook.Location = new System.Drawing.Point(16, 263);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(106, 45);
            this.btnBorrowBook.TabIndex = 3;
            this.btnBorrowBook.Text = "Borrow";
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // ucBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sPanel1);
            this.Name = "ucBook";
            this.Size = new System.Drawing.Size(316, 328);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBookImage;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthorName;
        private Guna.UI2.WinForms.Guna2GradientButton btnBorrowBook;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewBookDetails;
        private Sipaa.Framework.SPanel sPanel1;
    }
}
