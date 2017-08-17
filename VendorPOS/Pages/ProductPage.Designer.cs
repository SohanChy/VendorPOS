namespace VendorPOS.Pages
{
    partial class ProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButoon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.searchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.productFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.invoiceText = new System.Windows.Forms.Label();
            this.invoiceCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productFlow, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.473F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addButoon);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.categoryDropdown);
            this.flowLayoutPanel1.Controls.Add(this.searchBox);
            this.flowLayoutPanel1.Controls.Add(this.invoiceText);
            this.flowLayoutPanel1.Controls.Add(this.invoiceCount);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(894, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addButoon
            // 
            this.addButoon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButoon.BorderRadius = 0;
            this.addButoon.ButtonText = "  Add Products";
            this.addButoon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButoon.DisabledColor = System.Drawing.Color.Gray;
            this.addButoon.Iconcolor = System.Drawing.Color.Transparent;
            this.addButoon.Iconimage = ((System.Drawing.Image)(resources.GetObject("addButoon.Iconimage")));
            this.addButoon.Iconimage_right = null;
            this.addButoon.Iconimage_right_Selected = null;
            this.addButoon.Iconimage_Selected = null;
            this.addButoon.IconMarginLeft = 0;
            this.addButoon.IconMarginRight = 0;
            this.addButoon.IconRightVisible = true;
            this.addButoon.IconRightZoom = 0D;
            this.addButoon.IconVisible = true;
            this.addButoon.IconZoom = 90D;
            this.addButoon.IsTab = false;
            this.addButoon.Location = new System.Drawing.Point(3, 3);
            this.addButoon.Name = "addButoon";
            this.addButoon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addButoon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addButoon.OnHoverTextColor = System.Drawing.Color.White;
            this.addButoon.selected = false;
            this.addButoon.Size = new System.Drawing.Size(121, 48);
            this.addButoon.TabIndex = 1;
            this.addButoon.Text = "  Add Products";
            this.addButoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButoon.Textcolor = System.Drawing.Color.White;
            this.addButoon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButoon.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(130, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 48);
            this.panel1.TabIndex = 4;
            // 
            // categoryDropdown
            // 
            this.categoryDropdown.BackColor = System.Drawing.Color.Transparent;
            this.categoryDropdown.BorderRadius = 3;
            this.categoryDropdown.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryDropdown.ForeColor = System.Drawing.Color.White;
            this.categoryDropdown.Items = new string[0];
            this.categoryDropdown.Location = new System.Drawing.Point(233, 3);
            this.categoryDropdown.Name = "categoryDropdown";
            this.categoryDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.categoryDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.categoryDropdown.selectedIndex = -1;
            this.categoryDropdown.Size = new System.Drawing.Size(110, 48);
            this.categoryDropdown.TabIndex = 2;
            this.categoryDropdown.onItemSelected += new System.EventHandler(this.categoryDropdown_onItemSelected);
            // 
            // searchBox
            // 
            this.searchBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.searchBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.searchBox.BorderThickness = 3;
            this.searchBox.CausesValidation = false;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.isPassword = false;
            this.searchBox.Location = new System.Drawing.Point(350, 4);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(259, 46);
            this.searchBox.TabIndex = 3;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.searchBox_OnValueChanged);
            // 
            // productFlow
            // 
            this.productFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productFlow.Location = new System.Drawing.Point(3, 60);
            this.productFlow.Name = "productFlow";
            this.productFlow.Size = new System.Drawing.Size(894, 397);
            this.productFlow.TabIndex = 1;
            // 
            // invoiceText
            // 
            this.invoiceText.AutoSize = true;
            this.invoiceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceText.Location = new System.Drawing.Point(616, 0);
            this.invoiceText.Name = "invoiceText";
            this.invoiceText.Size = new System.Drawing.Size(13, 13);
            this.invoiceText.TabIndex = 5;
            this.invoiceText.Text = "  ";
            this.invoiceText.Click += new System.EventHandler(this.invoiceCount_Click);
            // 
            // invoiceCount
            // 
            this.invoiceCount.AutoSize = true;
            this.invoiceCount.Location = new System.Drawing.Point(635, 0);
            this.invoiceCount.Name = "invoiceCount";
            this.invoiceCount.Size = new System.Drawing.Size(13, 13);
            this.invoiceCount.TabIndex = 0;
            this.invoiceCount.Text = "  ";
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductPage";
            this.Size = new System.Drawing.Size(900, 460);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton addButoon;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchBox;
        private Bunifu.Framework.UI.BunifuDropdown categoryDropdown;
        private System.Windows.Forms.FlowLayoutPanel productFlow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label invoiceText;
        private System.Windows.Forms.Label invoiceCount;

    }
}
