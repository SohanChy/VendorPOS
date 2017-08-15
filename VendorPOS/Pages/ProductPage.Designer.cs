﻿namespace VendorPOS
{
    partial class ProductControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButoon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.categoryDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.searchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.productFlow = new System.Windows.Forms.FlowLayoutPanel();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addButoon);
            this.flowLayoutPanel1.Controls.Add(this.categoryDropdown);
            this.flowLayoutPanel1.Controls.Add(this.searchBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(897, 52);
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
            this.addButoon.Size = new System.Drawing.Size(155, 48);
            this.addButoon.TabIndex = 1;
            this.addButoon.Text = "  Add Products";
            this.addButoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButoon.Textcolor = System.Drawing.Color.White;
            this.addButoon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButoon.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // categoryDropdown
            // 
            this.categoryDropdown.BackColor = System.Drawing.Color.Transparent;
            this.categoryDropdown.BorderRadius = 3;
            this.categoryDropdown.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryDropdown.ForeColor = System.Drawing.Color.White;
            this.categoryDropdown.Items = new string[0];
            this.categoryDropdown.Location = new System.Drawing.Point(164, 3);
            this.categoryDropdown.Name = "categoryDropdown";
            this.categoryDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.categoryDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.categoryDropdown.selectedIndex = -1;
            this.categoryDropdown.Size = new System.Drawing.Size(177, 48);
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
            this.searchBox.Location = new System.Drawing.Point(348, 4);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(370, 46);
            this.searchBox.TabIndex = 3;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.searchBox_OnValueChanged);
            // 
            // productFlow
            // 
            this.productFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productFlow.Location = new System.Drawing.Point(3, 61);
            this.productFlow.Name = "productFlow";
            this.productFlow.Size = new System.Drawing.Size(897, 399);
            this.productFlow.TabIndex = 1;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(903, 463);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton addButoon;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchBox;
        private Bunifu.Framework.UI.BunifuDropdown categoryDropdown;
        private System.Windows.Forms.FlowLayoutPanel productFlow;

    }
}
