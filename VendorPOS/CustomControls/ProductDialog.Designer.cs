namespace VendorPOS.CustomControls
{
    partial class ProductDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDialog));
            this.saveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.chooseImageButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.iconHolderBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.datePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.descBox = new System.Windows.Forms.TextBox();
            this.categoryDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.deleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconHolderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.BorderRadius = 0;
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveButton.Iconimage")));
            this.saveButton.Iconimage_right = null;
            this.saveButton.Iconimage_right_Selected = null;
            this.saveButton.Iconimage_Selected = null;
            this.saveButton.IconMarginLeft = 0;
            this.saveButton.IconMarginRight = 0;
            this.saveButton.IconRightVisible = true;
            this.saveButton.IconRightZoom = 0D;
            this.saveButton.IconVisible = true;
            this.saveButton.IconZoom = 90D;
            this.saveButton.IsTab = false;
            this.saveButton.Location = new System.Drawing.Point(440, 398);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(124, 48);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Name";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(186, 21);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(336, 20);
            this.nameBox.TabIndex = 7;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(70, 74);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(49, 13);
            this.lb2.TabIndex = 9;
            this.lb2.Text = "Category";
            this.lb2.UseWaitCursor = true;
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chooseImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chooseImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseImageButton.BorderRadius = 0;
            this.chooseImageButton.ButtonText = "Choose Image";
            this.chooseImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseImageButton.DisabledColor = System.Drawing.Color.Gray;
            this.chooseImageButton.Iconcolor = System.Drawing.Color.Transparent;
            this.chooseImageButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("chooseImageButton.Iconimage")));
            this.chooseImageButton.Iconimage_right = null;
            this.chooseImageButton.Iconimage_right_Selected = null;
            this.chooseImageButton.Iconimage_Selected = null;
            this.chooseImageButton.IconMarginLeft = 0;
            this.chooseImageButton.IconMarginRight = 0;
            this.chooseImageButton.IconRightVisible = true;
            this.chooseImageButton.IconRightZoom = 0D;
            this.chooseImageButton.IconVisible = true;
            this.chooseImageButton.IconZoom = 90D;
            this.chooseImageButton.IsTab = false;
            this.chooseImageButton.Location = new System.Drawing.Point(186, 128);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chooseImageButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.chooseImageButton.OnHoverTextColor = System.Drawing.Color.White;
            this.chooseImageButton.selected = false;
            this.chooseImageButton.Size = new System.Drawing.Size(133, 23);
            this.chooseImageButton.TabIndex = 13;
            this.chooseImageButton.Text = "Choose Image";
            this.chooseImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseImageButton.Textcolor = System.Drawing.Color.White;
            this.chooseImageButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // iconHolderBox
            // 
            this.iconHolderBox.Location = new System.Drawing.Point(429, 64);
            this.iconHolderBox.Name = "iconHolderBox";
            this.iconHolderBox.Size = new System.Drawing.Size(122, 105);
            this.iconHolderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHolderBox.TabIndex = 12;
            this.iconHolderBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Expiry";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(186, 177);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(92, 20);
            this.priceBox.TabIndex = 17;
            this.priceBox.UseWaitCursor = true;
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.datePicker.BorderRadius = 0;
            this.datePicker.ForeColor = System.Drawing.Color.White;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.FormatCustom = null;
            this.datePicker.Location = new System.Drawing.Point(186, 220);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(182, 36);
            this.datePicker.TabIndex = 18;
            this.datePicker.Value = new System.DateTime(2017, 8, 18, 11, 50, 50, 923);
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(185, 282);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(366, 105);
            this.descBox.TabIndex = 19;
            // 
            // categoryDropDown
            // 
            this.categoryDropDown.BackColor = System.Drawing.Color.Transparent;
            this.categoryDropDown.BorderRadius = 3;
            this.categoryDropDown.ForeColor = System.Drawing.Color.White;
            this.categoryDropDown.Items = new string[0];
            this.categoryDropDown.Location = new System.Drawing.Point(186, 64);
            this.categoryDropDown.Name = "categoryDropDown";
            this.categoryDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.categoryDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.categoryDropDown.selectedIndex = -1;
            this.categoryDropDown.Size = new System.Drawing.Size(217, 35);
            this.categoryDropDown.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.BorderRadius = 0;
            this.deleteButton.ButtonText = "Delete";
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DisabledColor = System.Drawing.Color.Gray;
            this.deleteButton.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteButton.Iconimage")));
            this.deleteButton.Iconimage_right = null;
            this.deleteButton.Iconimage_right_Selected = null;
            this.deleteButton.Iconimage_Selected = null;
            this.deleteButton.IconMarginLeft = 0;
            this.deleteButton.IconMarginRight = 0;
            this.deleteButton.IconRightVisible = true;
            this.deleteButton.IconRightZoom = 0D;
            this.deleteButton.IconVisible = true;
            this.deleteButton.IconZoom = 90D;
            this.deleteButton.IsTab = false;
            this.deleteButton.Location = new System.Drawing.Point(21, 398);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Normalcolor = System.Drawing.Color.DarkRed;
            this.deleteButton.OnHovercolor = System.Drawing.Color.Maroon;
            this.deleteButton.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteButton.selected = false;
            this.deleteButton.Size = new System.Drawing.Size(124, 48);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Textcolor = System.Drawing.Color.White;
            this.deleteButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseImageButton);
            this.Controls.Add(this.iconHolderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryDropDown);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.saveButton);
            this.Name = "ProductDialog";
            this.Size = new System.Drawing.Size(585, 464);
            this.Load += new System.EventHandler(this.ProductDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconHolderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label lb2;
        private Bunifu.Framework.UI.BunifuFlatButton chooseImageButton;
        private System.Windows.Forms.PictureBox iconHolderBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceBox;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker;
        private System.Windows.Forms.TextBox descBox;
        private Bunifu.Framework.UI.BunifuDropdown categoryDropDown;
        private Bunifu.Framework.UI.BunifuFlatButton deleteButton;
    }
}
