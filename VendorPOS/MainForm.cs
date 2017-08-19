using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;


namespace VendorPOS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            if (!File.Exists(Program.DB_FILE_PATH))
            {
                new Database.DataModelsDataContext().CreateDatabase();
            }

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

        //event handler
        public void OnMoreProducts(List<Database.Product> invoiceList, EventArgs args)
        {
            Pages.ProductPage myProductPage = new Pages.ProductPage(invoiceList);
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
            myInvoicePage.moreProductsEvent += this.OnMoreProducts;
            ChangeContainer(myInvoicePage);
        }

        //event handler
        public void OnViewInvoice(List<Database.Product> invoiceList,Database.Invoice invoice, EventArgs args)
        {
            Pages.InvoicePage myInvoicePage = new Pages.InvoicePage(invoiceList, invoice);
            myInvoicePage.moreProductsEvent += this.OnMoreProducts;
            ChangeContainer(myInvoicePage);
        }

        private void containerPane_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            Pages.HistoryPage myHistoryPage = new Pages.HistoryPage();
            myHistoryPage.viewInvoiceEvent += this.OnViewInvoice;
            ChangeContainer(myHistoryPage);
        }

        private void NewInvoiceButton_Click(object sender, EventArgs e)
        {
            Pages.InvoicePage myInvoicePage = new Pages.InvoicePage();
            ChangeContainer(myInvoicePage);
        }
    }
}
