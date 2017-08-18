namespace VendorPOS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ApplicationName = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Products = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Category = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Invoices = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_New = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_History = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Report = new Bunifu.Framework.UI.BunifuFlatButton();
            this.containerPane = new System.Windows.Forms.Panel();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.containerPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 89);
            this.panel1.TabIndex = 103;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label_ApplicationName);
            this.panel3.Location = new System.Drawing.Point(356, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 83);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "A Point of Sale System for small electronic shops";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_ApplicationName
            // 
            this.label_ApplicationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ApplicationName.AutoSize = true;
            this.label_ApplicationName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ApplicationName.ForeColor = System.Drawing.Color.Black;
            this.label_ApplicationName.Location = new System.Drawing.Point(90, 10);
            this.label_ApplicationName.Name = "label_ApplicationName";
            this.label_ApplicationName.Size = new System.Drawing.Size(148, 29);
            this.label_ApplicationName.TabIndex = 7;
            this.label_ApplicationName.Text = "Vendor POS";
            this.label_ApplicationName.Click += new System.EventHandler(this.label_ApplicationName_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(139, 87);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton1);
            this.flowLayoutPanel1.Controls.Add(this.btn_Products);
            this.flowLayoutPanel1.Controls.Add(this.btn_Category);
            this.flowLayoutPanel1.Controls.Add(this.btn_Invoices);
            this.flowLayoutPanel1.Controls.Add(this.btn_New);
            this.flowLayoutPanel1.Controls.Add(this.btn_History);
            this.flowLayoutPanel1.Controls.Add(this.btn_Report);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 474);
            this.flowLayoutPanel1.TabIndex = 104;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 54);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "             Invoice";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 63);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(193, 48);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "             Invoice";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Products
            // 
            this.btn_Products.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Products.BorderRadius = 0;
            this.btn_Products.ButtonText = "     Products";
            this.btn_Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Products.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Products.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Products.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Products.Iconimage")));
            this.btn_Products.Iconimage_right = null;
            this.btn_Products.Iconimage_right_Selected = null;
            this.btn_Products.Iconimage_Selected = null;
            this.btn_Products.IconMarginLeft = 0;
            this.btn_Products.IconMarginRight = 0;
            this.btn_Products.IconRightVisible = true;
            this.btn_Products.IconRightZoom = 0D;
            this.btn_Products.IconVisible = true;
            this.btn_Products.IconZoom = 90D;
            this.btn_Products.IsTab = false;
            this.btn_Products.Location = new System.Drawing.Point(3, 117);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Products.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Products.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Products.selected = false;
            this.btn_Products.Size = new System.Drawing.Size(193, 48);
            this.btn_Products.TabIndex = 2;
            this.btn_Products.Text = "     Products";
            this.btn_Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Products.Textcolor = System.Drawing.Color.White;
            this.btn_Products.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Category.BorderRadius = 0;
            this.btn_Category.ButtonText = "     Category";
            this.btn_Category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Category.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Category.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Category.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Category.Iconimage")));
            this.btn_Category.Iconimage_right = null;
            this.btn_Category.Iconimage_right_Selected = null;
            this.btn_Category.Iconimage_Selected = null;
            this.btn_Category.IconMarginLeft = 0;
            this.btn_Category.IconMarginRight = 0;
            this.btn_Category.IconRightVisible = true;
            this.btn_Category.IconRightZoom = 0D;
            this.btn_Category.IconVisible = true;
            this.btn_Category.IconZoom = 90D;
            this.btn_Category.IsTab = false;
            this.btn_Category.Location = new System.Drawing.Point(3, 171);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Category.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Category.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Category.selected = false;
            this.btn_Category.Size = new System.Drawing.Size(193, 48);
            this.btn_Category.TabIndex = 3;
            this.btn_Category.Text = "     Category";
            this.btn_Category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Category.Textcolor = System.Drawing.Color.White;
            this.btn_Category.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Invoices
            // 
            this.btn_Invoices.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Invoices.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Invoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Invoices.BorderRadius = 0;
            this.btn_Invoices.ButtonText = "             Invoice";
            this.btn_Invoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Invoices.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Invoices.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Invoices.Iconimage = null;
            this.btn_Invoices.Iconimage_right = null;
            this.btn_Invoices.Iconimage_right_Selected = null;
            this.btn_Invoices.Iconimage_Selected = null;
            this.btn_Invoices.IconMarginLeft = 0;
            this.btn_Invoices.IconMarginRight = 0;
            this.btn_Invoices.IconRightVisible = true;
            this.btn_Invoices.IconRightZoom = 0D;
            this.btn_Invoices.IconVisible = true;
            this.btn_Invoices.IconZoom = 90D;
            this.btn_Invoices.IsTab = false;
            this.btn_Invoices.Location = new System.Drawing.Point(3, 225);
            this.btn_Invoices.Name = "btn_Invoices";
            this.btn_Invoices.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btn_Invoices.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btn_Invoices.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Invoices.selected = false;
            this.btn_Invoices.Size = new System.Drawing.Size(193, 48);
            this.btn_Invoices.TabIndex = 4;
            this.btn_Invoices.Text = "             Invoice";
            this.btn_Invoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Invoices.Textcolor = System.Drawing.Color.White;
            this.btn_Invoices.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_New
            // 
            this.btn_New.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_New.BorderRadius = 0;
            this.btn_New.ButtonText = "     New";
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.DisabledColor = System.Drawing.Color.Gray;
            this.btn_New.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_New.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_New.Iconimage")));
            this.btn_New.Iconimage_right = null;
            this.btn_New.Iconimage_right_Selected = null;
            this.btn_New.Iconimage_Selected = null;
            this.btn_New.IconMarginLeft = 0;
            this.btn_New.IconMarginRight = 0;
            this.btn_New.IconRightVisible = true;
            this.btn_New.IconRightZoom = 0D;
            this.btn_New.IconVisible = true;
            this.btn_New.IconZoom = 90D;
            this.btn_New.IsTab = false;
            this.btn_New.Location = new System.Drawing.Point(3, 279);
            this.btn_New.Name = "btn_New";
            this.btn_New.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_New.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_New.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_New.selected = false;
            this.btn_New.Size = new System.Drawing.Size(193, 48);
            this.btn_New.TabIndex = 5;
            this.btn_New.Text = "     New";
            this.btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New.Textcolor = System.Drawing.Color.White;
            this.btn_New.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_History
            // 
            this.btn_History.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_History.BorderRadius = 0;
            this.btn_History.ButtonText = "     History";
            this.btn_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_History.DisabledColor = System.Drawing.Color.Gray;
            this.btn_History.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_History.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_History.Iconimage")));
            this.btn_History.Iconimage_right = null;
            this.btn_History.Iconimage_right_Selected = null;
            this.btn_History.Iconimage_Selected = null;
            this.btn_History.IconMarginLeft = 0;
            this.btn_History.IconMarginRight = 0;
            this.btn_History.IconRightVisible = true;
            this.btn_History.IconRightZoom = 0D;
            this.btn_History.IconVisible = true;
            this.btn_History.IconZoom = 90D;
            this.btn_History.IsTab = false;
            this.btn_History.Location = new System.Drawing.Point(3, 333);
            this.btn_History.Name = "btn_History";
            this.btn_History.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_History.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_History.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_History.selected = false;
            this.btn_History.Size = new System.Drawing.Size(193, 48);
            this.btn_History.TabIndex = 6;
            this.btn_History.Text = "     History";
            this.btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.Textcolor = System.Drawing.Color.White;
            this.btn_History.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Report.BorderRadius = 0;
            this.btn_Report.ButtonText = "     Report";
            this.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Report.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Report.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Report.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Report.Iconimage")));
            this.btn_Report.Iconimage_right = null;
            this.btn_Report.Iconimage_right_Selected = null;
            this.btn_Report.Iconimage_Selected = null;
            this.btn_Report.IconMarginLeft = 0;
            this.btn_Report.IconMarginRight = 0;
            this.btn_Report.IconRightVisible = true;
            this.btn_Report.IconRightZoom = 0D;
            this.btn_Report.IconVisible = true;
            this.btn_Report.IconZoom = 90D;
            this.btn_Report.IsTab = false;
            this.btn_Report.Location = new System.Drawing.Point(3, 387);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Report.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Report.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Report.selected = false;
            this.btn_Report.Size = new System.Drawing.Size(193, 48);
            this.btn_Report.TabIndex = 7;
            this.btn_Report.Text = "     Report";
            this.btn_Report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Report.Textcolor = System.Drawing.Color.White;
            this.btn_Report.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // containerPane
            // 
            this.containerPane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerPane.Controls.Add(this.doubleBitmapControl1);
            this.containerPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPane.Location = new System.Drawing.Point(196, 89);
            this.containerPane.Name = "containerPane";
            this.containerPane.Size = new System.Drawing.Size(847, 474);
            this.containerPane.TabIndex = 105;
            this.containerPane.Paint += new System.Windows.Forms.PaintEventHandler(this.containerPane_Paint);
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(375, 216);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 563);
            this.Controls.Add(this.containerPane);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.containerPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Products;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Category;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ApplicationName;
        private System.Windows.Forms.Panel containerPane;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Invoices;
        private Bunifu.Framework.UI.BunifuFlatButton btn_New;
        private Bunifu.Framework.UI.BunifuFlatButton btn_History;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Report;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
    }
}

