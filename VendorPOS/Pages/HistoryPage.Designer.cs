namespace VendorPOS.Pages
{
    partial class HistoryPage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.monthPicker = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.YearPicker = new Bunifu.Framework.UI.BunifuDropdown();
            this.InvoiceFLow = new System.Windows.Forms.FlowLayoutPanel();
            this.historyGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.InvoiceFLow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InvoiceFLow, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.473F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 460);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.monthPicker);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.YearPicker);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(894, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Month";
            // 
            // monthPicker
            // 
            this.monthPicker.BackColor = System.Drawing.Color.Transparent;
            this.monthPicker.BorderRadius = 3;
            this.monthPicker.ForeColor = System.Drawing.Color.White;
            this.monthPicker.Items = new string[0];
            this.monthPicker.Location = new System.Drawing.Point(46, 3);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.monthPicker.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.monthPicker.selectedIndex = -1;
            this.monthPicker.Size = new System.Drawing.Size(217, 35);
            this.monthPicker.TabIndex = 0;
            this.monthPicker.onItemSelected += new System.EventHandler(this.monthPicker_onItemSelected);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year";
            // 
            // YearPicker
            // 
            this.YearPicker.BackColor = System.Drawing.Color.Transparent;
            this.YearPicker.BorderRadius = 3;
            this.YearPicker.ForeColor = System.Drawing.Color.White;
            this.YearPicker.Items = new string[0];
            this.YearPicker.Location = new System.Drawing.Point(304, 3);
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.YearPicker.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.YearPicker.selectedIndex = -1;
            this.YearPicker.Size = new System.Drawing.Size(217, 35);
            this.YearPicker.TabIndex = 1;
            this.YearPicker.onItemSelected += new System.EventHandler(this.YearPicker_onItemSelected);
            // 
            // InvoiceFLow
            // 
            this.InvoiceFLow.Controls.Add(this.historyGridView);
            this.InvoiceFLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceFLow.Location = new System.Drawing.Point(3, 60);
            this.InvoiceFLow.Name = "InvoiceFLow";
            this.InvoiceFLow.Size = new System.Drawing.Size(894, 397);
            this.InvoiceFLow.TabIndex = 1;
            // 
            // historyGridView
            // 
            this.historyGridView.AllowUserToAddRows = false;
            this.historyGridView.AllowUserToDeleteRows = false;
            this.historyGridView.AllowUserToResizeRows = false;
            this.historyGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.historyGridView.BackgroundColor = System.Drawing.Color.White;
            this.historyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.date,
            this.customer,
            this.total});
            this.historyGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.historyGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.historyGridView.Location = new System.Drawing.Point(3, 3);
            this.historyGridView.MultiSelect = false;
            this.historyGridView.Name = "historyGridView";
            this.historyGridView.ReadOnly = true;
            this.historyGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyGridView.Size = new System.Drawing.Size(693, 316);
            this.historyGridView.TabIndex = 0;
            this.historyGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rowDoubleClick);
            this.historyGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rowDoubleClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 1F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 2;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            this.Id.Width = 2;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 150;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.MinimumWidth = 350;
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            this.customer.Width = 350;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 150;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // HistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HistoryPage";
            this.Size = new System.Drawing.Size(900, 460);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.InvoiceFLow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel InvoiceFLow;
        private System.Windows.Forms.DataGridView historyGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown monthPicker;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown YearPicker;

    }
}
