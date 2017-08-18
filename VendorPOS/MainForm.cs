using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace VendorPOS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Pages.ProductPage myProductPage = new Pages.ProductPage();
            myProductPage.viewInvoiceEvent += this.OnViewInvoice;
            
            ChangeContainer(myProductPage);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeContainer(UserControl u)
        {
            containerPane.Controls.Clear();
            containerPane.Controls.Add(u);
            u.Dock = DockStyle.Fill;
        }

        private void sohafn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            Pages.ProductPage myProductPage = new Pages.ProductPage();
            myProductPage.viewInvoiceEvent += this.OnViewInvoice;
            ChangeContainer(myProductPage);
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            ChangeContainer(new Pages.CategoryPage());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Pages.InvoicePage myInvoicePage = new Pages.InvoicePage();
            ChangeContainer(myInvoicePage);

        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_ApplicationName_Click(object sender, EventArgs e)
        {

        }

        //event handler
        public void OnViewInvoice(List<Database.Product> invoiceList, EventArgs args)
        {
            Pages.InvoicePage myInvoicePage = new Pages.InvoicePage(invoiceList);
            ChangeContainer(myInvoicePage);
        }

        private void containerPane_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
