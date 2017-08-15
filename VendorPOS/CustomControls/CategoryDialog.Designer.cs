namespace VendorPOS.CustomControls
{
    partial class CategoryDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryDialog));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconHolderBox = new System.Windows.Forms.PictureBox();
            this.chooseImageButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconHolderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(117, 26);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(336, 20);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category Icon";
            // 
            // iconHolderBox
            // 
            this.iconHolderBox.Location = new System.Drawing.Point(280, 61);
            this.iconHolderBox.Name = "iconHolderBox";
            this.iconHolderBox.Size = new System.Drawing.Size(62, 59);
            this.iconHolderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHolderBox.TabIndex = 3;
            this.iconHolderBox.TabStop = false;
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
            this.chooseImageButton.Location = new System.Drawing.Point(126, 78);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chooseImageButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.chooseImageButton.OnHoverTextColor = System.Drawing.Color.White;
            this.chooseImageButton.selected = false;
            this.chooseImageButton.Size = new System.Drawing.Size(133, 23);
            this.chooseImageButton.TabIndex = 4;
            this.chooseImageButton.Text = "Choose Image";
            this.chooseImageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseImageButton.Textcolor = System.Drawing.Color.White;
            this.chooseImageButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
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
            this.saveButton.Location = new System.Drawing.Point(347, 136);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(124, 48);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CategoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.chooseImageButton);
            this.Controls.Add(this.iconHolderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "CategoryDialog";
            this.Size = new System.Drawing.Size(490, 201);
            this.Load += new System.EventHandler(this.CategoryDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconHolderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox iconHolderBox;
        private Bunifu.Framework.UI.BunifuFlatButton chooseImageButton;
        private Bunifu.Framework.UI.BunifuFlatButton saveButton;
    }
}
