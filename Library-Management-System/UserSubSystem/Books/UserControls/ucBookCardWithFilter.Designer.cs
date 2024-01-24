namespace LibraryManagementSystem.Books.UserControls
{
    partial class ucBookCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewBook = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearchForBook = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucBookCard1 = new LibraryManagementSystem.Books.UserControls.ucBookCard();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.gbFilter.BorderRadius = 25;
            this.gbFilter.Controls.Add(this.cbFilterByOptions);
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Controls.Add(this.btnAddNewBook);
            this.gbFilter.Controls.Add(this.btnSearchForBook);
            this.gbFilter.Controls.Add(this.label14);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(139)))), ((int)(((byte)(127)))));
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbFilter.ForeColor = System.Drawing.Color.Black;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(983, 122);
            this.gbFilter.TabIndex = 203;
            this.gbFilter.Text = "Filter";
            // 
            // cbFilterByOptions
            // 
            this.cbFilterByOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByOptions.BorderColor = System.Drawing.Color.Silver;
            this.cbFilterByOptions.BorderRadius = 22;
            this.cbFilterByOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbFilterByOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFilterByOptions.ItemHeight = 40;
            this.cbFilterByOptions.Items.AddRange(new object[] {
            "Book ID",
            "ISBN"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(154, 56);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(223, 46);
            this.cbFilterByOptions.StartIndex = 0;
            this.cbFilterByOptions.TabIndex = 194;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderColor = System.Drawing.Color.Silver;
            this.txtFilterValue.BorderRadius = 20;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(398, 56);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(304, 46);
            this.txtFilterValue.TabIndex = 193;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewBook.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddNewBook.Image = global::LibraryManagementSystem.Properties.Resources.book__1_2;
            this.btnAddNewBook.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddNewBook.ImageRotate = 0F;
            this.btnAddNewBook.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewBook.Location = new System.Drawing.Point(802, 52);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewBook.ShadowDecoration.Depth = 10;
            this.btnAddNewBook.Size = new System.Drawing.Size(50, 50);
            this.btnAddNewBook.TabIndex = 192;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnSearchForBook
            // 
            this.btnSearchForBook.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchForBook.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnSearchForBook.Image = global::LibraryManagementSystem.Properties.Resources.book__2_1;
            this.btnSearchForBook.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearchForBook.ImageRotate = 0F;
            this.btnSearchForBook.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchForBook.Location = new System.Drawing.Point(738, 52);
            this.btnSearchForBook.Name = "btnSearchForBook";
            this.btnSearchForBook.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchForBook.ShadowDecoration.Depth = 10;
            this.btnSearchForBook.Size = new System.Drawing.Size(50, 50);
            this.btnSearchForBook.TabIndex = 191;
            this.btnSearchForBook.Click += new System.EventHandler(this.btnSearchForBook_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(42, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 23);
            this.label14.TabIndex = 190;
            this.label14.Text = "Book ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucBookCard1
            // 
            this.ucBookCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucBookCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucBookCard1.Location = new System.Drawing.Point(0, 142);
            this.ucBookCard1.Name = "ucBookCard1";
            this.ucBookCard1.Size = new System.Drawing.Size(983, 375);
            this.ucBookCard1.TabIndex = 204;
            // 
            // ucBookCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ucBookCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ucBookCardWithFilter";
            this.Size = new System.Drawing.Size(983, 517);
            this.Load += new System.EventHandler(this.ucBookCardWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddNewBook;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearchForBook;
        private System.Windows.Forms.Label label14;
        private ucBookCard ucBookCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
