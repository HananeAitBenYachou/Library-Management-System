namespace LibraryManagementSystem.Books.BookCopies
{
    partial class ucBookCopyCard
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
            this.ucBookCard1 = new LibraryManagementSystem.Books.UserControls.ucBookCard();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton7 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBookCopyID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucBookCard1
            // 
            this.ucBookCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucBookCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucBookCard1.Location = new System.Drawing.Point(0, 0);
            this.ucBookCard1.Name = "ucBookCard1";
            this.ucBookCard1.Size = new System.Drawing.Size(983, 373);
            this.ucBookCard1.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.guna2GroupBox1.BorderRadius = 25;
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton1);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton7);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.lblBookCopyID);
            this.guna2GroupBox1.Controls.Add(this.lblStatus);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 388);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(983, 140);
            this.guna2GroupBox1.TabIndex = 205;
            this.guna2GroupBox1.Text = "BookCopy Information";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::LibraryManagementSystem.Properties.Resources.yes_or_no;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Location = new System.Drawing.Point(617, 74);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 211;
            // 
            // guna2ImageButton7
            // 
            this.guna2ImageButton7.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton7.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton7.Image = global::LibraryManagementSystem.Properties.Resources.id;
            this.guna2ImageButton7.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton7.ImageRotate = 0F;
            this.guna2ImageButton7.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton7.Location = new System.Drawing.Point(317, 74);
            this.guna2ImageButton7.Name = "guna2ImageButton7";
            this.guna2ImageButton7.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton7.TabIndex = 210;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(220, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 168;
            this.label12.Text = "Copy ID :";
            // 
            // lblBookCopyID
            // 
            this.lblBookCopyID.AutoSize = true;
            this.lblBookCopyID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblBookCopyID.Location = new System.Drawing.Point(355, 77);
            this.lblBookCopyID.Name = "lblBookCopyID";
            this.lblBookCopyID.Size = new System.Drawing.Size(50, 23);
            this.lblBookCopyID.TabIndex = 169;
            this.lblBookCopyID.Text = "[????]";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(654, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 23);
            this.lblStatus.TabIndex = 171;
            this.lblStatus.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 170;
            this.label2.Text = "Status :";
            // 
            // ucBookCopyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.ucBookCard1);
            this.Name = "ucBookCopyCard";
            this.Size = new System.Drawing.Size(983, 528);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucBookCard ucBookCard1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBookCopyID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
    }
}
