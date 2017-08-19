namespace VendorPOS.Pages
{
    partial class InvoicePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicePage));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.phoneNoBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.customerNameBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.remarksBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.generateInvoiceBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.onlySaveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.fileDBDataSet1 = new VendorPOS.Database.FileDBDataSet();
            this.moreProductsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(988, 484);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.91395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.08605F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.phoneNoBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.customerNameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.remarksBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.datePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomLabel4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 185);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(132, 20);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Customer Name :";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 42);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(85, 20);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Phone no :";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNoBox
            // 
            this.phoneNoBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.phoneNoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoBox.Location = new System.Drawing.Point(169, 45);
            this.phoneNoBox.Name = "phoneNoBox";
            this.phoneNoBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phoneNoBox.Size = new System.Drawing.Size(608, 26);
            this.phoneNoBox.TabIndex = 9;
            // 
            // customerNameBox
            // 
            this.customerNameBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.customerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameBox.Location = new System.Drawing.Point(169, 3);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerNameBox.Size = new System.Drawing.Size(608, 26);
            this.customerNameBox.TabIndex = 11;
            // 
            // remarksBox
            // 
            this.remarksBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.remarksBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarksBox.Location = new System.Drawing.Point(169, 132);
            this.remarksBox.Multiline = true;
            this.remarksBox.Name = "remarksBox";
            this.remarksBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.remarksBox.Size = new System.Drawing.Size(608, 50);
            this.remarksBox.TabIndex = 13;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 129);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(81, 20);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Remarks :";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.datePicker.BorderRadius = 0;
            this.datePicker.ForeColor = System.Drawing.Color.White;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.FormatCustom = null;
            this.datePicker.Location = new System.Drawing.Point(169, 87);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(290, 39);
            this.datePicker.TabIndex = 15;
            this.datePicker.Value = new System.DateTime(2017, 8, 19, 0, 18, 34, 907);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 84);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(48, 20);
            this.bunifuCustomLabel4.TabIndex = 14;
            this.bunifuCustomLabel4.Text = "Date:";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(3, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 197);
            this.dataGridView1.TabIndex = 11;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.generateInvoiceBtn);
            this.flowLayoutPanel3.Controls.Add(this.onlySaveButton);
            this.flowLayoutPanel3.Controls.Add(this.panel1);
            this.flowLayoutPanel3.Controls.Add(this.moreProductsButton);
            this.flowLayoutPanel3.Controls.Add(this.clearItems);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 397);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(982, 66);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // generateInvoiceBtn
            // 
            this.generateInvoiceBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.generateInvoiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.generateInvoiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateInvoiceBtn.BorderRadius = 0;
            this.generateInvoiceBtn.ButtonText = "    Generate And  Save";
            this.generateInvoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateInvoiceBtn.DisabledColor = System.Drawing.Color.Gray;
            this.generateInvoiceBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.generateInvoiceBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("generateInvoiceBtn.Iconimage")));
            this.generateInvoiceBtn.Iconimage_right = null;
            this.generateInvoiceBtn.Iconimage_right_Selected = null;
            this.generateInvoiceBtn.Iconimage_Selected = null;
            this.generateInvoiceBtn.IconMarginLeft = 0;
            this.generateInvoiceBtn.IconMarginRight = 0;
            this.generateInvoiceBtn.IconRightVisible = true;
            this.generateInvoiceBtn.IconRightZoom = 0D;
            this.generateInvoiceBtn.IconVisible = true;
            this.generateInvoiceBtn.IconZoom = 90D;
            this.generateInvoiceBtn.IsTab = false;
            this.generateInvoiceBtn.Location = new System.Drawing.Point(3, 3);
            this.generateInvoiceBtn.Name = "generateInvoiceBtn";
            this.generateInvoiceBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.generateInvoiceBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.generateInvoiceBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.generateInvoiceBtn.selected = false;
            this.generateInvoiceBtn.Size = new System.Drawing.Size(208, 52);
            this.generateInvoiceBtn.TabIndex = 7;
            this.generateInvoiceBtn.Text = "    Generate And  Save";
            this.generateInvoiceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateInvoiceBtn.Textcolor = System.Drawing.Color.White;
            this.generateInvoiceBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateInvoiceBtn.Click += new System.EventHandler(this.generateInvoiceBtn_Click);
            // 
            // onlySaveButton
            // 
            this.onlySaveButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.onlySaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.onlySaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onlySaveButton.BorderRadius = 0;
            this.onlySaveButton.ButtonText = "    Save";
            this.onlySaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onlySaveButton.DisabledColor = System.Drawing.Color.Gray;
            this.onlySaveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.onlySaveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("onlySaveButton.Iconimage")));
            this.onlySaveButton.Iconimage_right = null;
            this.onlySaveButton.Iconimage_right_Selected = null;
            this.onlySaveButton.Iconimage_Selected = null;
            this.onlySaveButton.IconMarginLeft = 0;
            this.onlySaveButton.IconMarginRight = 0;
            this.onlySaveButton.IconRightVisible = true;
            this.onlySaveButton.IconRightZoom = 0D;
            this.onlySaveButton.IconVisible = true;
            this.onlySaveButton.IconZoom = 90D;
            this.onlySaveButton.IsTab = false;
            this.onlySaveButton.Location = new System.Drawing.Point(217, 3);
            this.onlySaveButton.Name = "onlySaveButton";
            this.onlySaveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.onlySaveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.onlySaveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.onlySaveButton.selected = false;
            this.onlySaveButton.Size = new System.Drawing.Size(115, 52);
            this.onlySaveButton.TabIndex = 9;
            this.onlySaveButton.Text = "    Save";
            this.onlySaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onlySaveButton.Textcolor = System.Drawing.Color.White;
            this.onlySaveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlySaveButton.Click += new System.EventHandler(this.onlySaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(338, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 41);
            this.panel1.TabIndex = 10;
            // 
            // clearItems
            // 
            this.clearItems.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearItems.BackColor = System.Drawing.Color.Red;
            this.clearItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearItems.BorderRadius = 0;
            this.clearItems.ButtonText = "Clear Items";
            this.clearItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearItems.DisabledColor = System.Drawing.Color.Gray;
            this.clearItems.Iconcolor = System.Drawing.Color.Transparent;
            this.clearItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("clearItems.Iconimage")));
            this.clearItems.Iconimage_right = null;
            this.clearItems.Iconimage_right_Selected = null;
            this.clearItems.Iconimage_Selected = null;
            this.clearItems.IconMarginLeft = 0;
            this.clearItems.IconMarginRight = 0;
            this.clearItems.IconRightVisible = true;
            this.clearItems.IconRightZoom = 0D;
            this.clearItems.IconVisible = true;
            this.clearItems.IconZoom = 90D;
            this.clearItems.IsTab = false;
            this.clearItems.Location = new System.Drawing.Point(633, 3);
            this.clearItems.Name = "clearItems";
            this.clearItems.Normalcolor = System.Drawing.Color.Red;
            this.clearItems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearItems.OnHoverTextColor = System.Drawing.Color.White;
            this.clearItems.selected = false;
            this.clearItems.Size = new System.Drawing.Size(168, 52);
            this.clearItems.TabIndex = 11;
            this.clearItems.Text = "Clear Items";
            this.clearItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearItems.Textcolor = System.Drawing.Color.White;
            this.clearItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearItems.Click += new System.EventHandler(this.clearItems_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fileDBDataSet1
            // 
            this.fileDBDataSet1.DataSetName = "FileDBDataSet";
            this.fileDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moreProductsButton
            // 
            this.moreProductsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.moreProductsButton.BackColor = System.Drawing.Color.Peru;
            this.moreProductsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moreProductsButton.BorderRadius = 0;
            this.moreProductsButton.ButtonText = "More Products";
            this.moreProductsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreProductsButton.DisabledColor = System.Drawing.Color.Gray;
            this.moreProductsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.moreProductsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("moreProductsButton.Iconimage")));
            this.moreProductsButton.Iconimage_right = null;
            this.moreProductsButton.Iconimage_right_Selected = null;
            this.moreProductsButton.Iconimage_Selected = null;
            this.moreProductsButton.IconMarginLeft = 0;
            this.moreProductsButton.IconMarginRight = 0;
            this.moreProductsButton.IconRightVisible = true;
            this.moreProductsButton.IconRightZoom = 0D;
            this.moreProductsButton.IconVisible = true;
            this.moreProductsButton.IconZoom = 90D;
            this.moreProductsButton.IsTab = false;
            this.moreProductsButton.Location = new System.Drawing.Point(459, 3);
            this.moreProductsButton.Name = "moreProductsButton";
            this.moreProductsButton.Normalcolor = System.Drawing.Color.Peru;
            this.moreProductsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.moreProductsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.moreProductsButton.selected = false;
            this.moreProductsButton.Size = new System.Drawing.Size(168, 52);
            this.moreProductsButton.TabIndex = 12;
            this.moreProductsButton.Text = "More Products";
            this.moreProductsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moreProductsButton.Textcolor = System.Drawing.Color.White;
            this.moreProductsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreProductsButton.Click += new System.EventHandler(this.moreProductsButton_Click);
            // 
            // InvoicePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "InvoicePage";
            this.Size = new System.Drawing.Size(988, 484);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox phoneNoBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox customerNameBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Database.FileDBDataSet fileDBDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Bunifu.Framework.UI.BunifuFlatButton generateInvoiceBtn;
        private System.Windows.Forms.Button button1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox remarksBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker;
        private Bunifu.Framework.UI.BunifuFlatButton onlySaveButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton clearItems;
        private Bunifu.Framework.UI.BunifuFlatButton moreProductsButton;
    }
}
