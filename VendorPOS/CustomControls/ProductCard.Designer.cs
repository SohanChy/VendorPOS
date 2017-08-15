namespace VendorPOS
{
    partial class ProductCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.ActionButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(173, 176);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(182, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 62);
            this.name.TabIndex = 1;
            this.name.Text = "Orange Juice with 4GB Ram, RGB LED, Corsair REX BLEX Gamer Gunk";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // desc
            // 
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.Location = new System.Drawing.Point(182, 74);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(197, 78);
            this.desc.TabIndex = 2;
            this.desc.Text = "Orange Juice with 4GB Ram, RGB LED, Corsair REX BLEX Gamer Gunk";
            // 
            // ActionButton
            // 
            this.ActionButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ActionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ActionButton.BorderRadius = 0;
            this.ActionButton.ButtonText = "Action";
            this.ActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionButton.DisabledColor = System.Drawing.Color.Gray;
            this.ActionButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ActionButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ActionButton.Iconimage")));
            this.ActionButton.Iconimage_right = null;
            this.ActionButton.Iconimage_right_Selected = null;
            this.ActionButton.Iconimage_Selected = null;
            this.ActionButton.IconMarginLeft = 0;
            this.ActionButton.IconMarginRight = 0;
            this.ActionButton.IconRightVisible = true;
            this.ActionButton.IconRightZoom = 0D;
            this.ActionButton.IconVisible = true;
            this.ActionButton.IconZoom = 90D;
            this.ActionButton.IsTab = false;
            this.ActionButton.Location = new System.Drawing.Point(286, 156);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ActionButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ActionButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ActionButton.selected = false;
            this.ActionButton.Size = new System.Drawing.Size(92, 32);
            this.ActionButton.TabIndex = 3;
            this.ActionButton.Text = "Action";
            this.ActionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActionButton.Textcolor = System.Drawing.Color.White;
            this.ActionButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(181, 164);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(108, 18);
            this.price.TabIndex = 4;
            this.price.Text = "BDT 14500";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.price);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(384, 199);
            this.Load += new System.EventHandler(this.ProductCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label desc;
        private Bunifu.Framework.UI.BunifuFlatButton ActionButton;
        private System.Windows.Forms.Label price;



    }
}
