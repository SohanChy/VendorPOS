using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace VendorPOS.Pages
{
    public partial class ProductPage : UserControl
    {
        private Database.DataModelsDataContext DB = new Database.DataModelsDataContext();
        private System.Data.Linq.Table<Database.Category>categoryList;
        private System.Data.Linq.Table<Database.Product>productList;
        private List<Database.Product> invoiceList = new List<Database.Product>();
        
        private IEnumerable<Database.Product> pquery;
        //delegates
        public delegate void ViewInvoiceEventHandler(List<Database.Product>invoiceList, EventArgs args);
        public event ViewInvoiceEventHandler viewInvoiceEvent;

        protected virtual void OnViewInvoice()
        {
            if (viewInvoiceEvent != null)
            {
                viewInvoiceEvent(this.invoiceList, EventArgs.Empty);
            }
        }

        public ProductPage()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            viewInvoiceBtn.Hide();
            categoryList = DB.Categories;
            foreach (var item in categoryList)
            {
                categoryDropdown.AddItem(item.name);
            }

            productList = DB.Products;

            pquery = (from p in productList
                     orderby p.created_at
                     select p).Take(10);
            populateProducts();
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_OnValueChanged(object sender, EventArgs e)
        {
            pquery = from p in productList
                     where p.name.Contains(searchBox.Text)
                     select p;
            populateProducts();
        }

        private void categoryDropdown_onItemSelected(object sender, EventArgs e)
        {
            var cquery = from cat in categoryList
                    where cat.name == categoryDropdown.selectedValue
                           select cat.Id;
            int sel = cquery.First();

            pquery = from p in productList 
                                                   where p.category_id == sel
                                                    select p;
            populateProducts();
        }

        private void populateProducts()
        {
            productFlow.Controls.Clear();
            foreach (Database.Product p in pquery)
            {
                VendorPOS.ProductCard productCard = new ProductCard(p);  //publisher
                productCard.InvoiceAdded += this.OnInvoiceAdded;
                productFlow.Controls.Add(productCard);
            }
        }

        //event handler 
        public void OnInvoiceAdded(Database.Product source, EventArgs e)
        {
            this.invoiceList.Add(source);
            invoiceText.Text = "Products Added To Invoice";
            invoiceCount.Text = this.invoiceList.Count().ToString();

            if (this.invoiceList.Count() > 0)
            {
                viewInvoiceBtn.Show();   
            }
        }

        private void invoiceCount_Click(object sender, EventArgs e)
        {

        }

        private void viewInvoiceBtn_Click(object sender, EventArgs e)
        {
            OnViewInvoice();
        }
    }
}
