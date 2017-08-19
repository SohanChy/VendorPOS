using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace VendorPOS.Pages
{
    public partial class ProductPage : UserControl
    {
        private Database.DataModelsDataContext DB = new Database.DataModelsDataContext();
        private System.Data.Linq.Table<Database.Category> categoryList;
        private System.Data.Linq.Table<Database.Product> productList;
        private List<Database.Product> invoiceList = new List<Database.Product>();
        
        private IEnumerable<Database.Product> pquery;

        private int selectedCatId;
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

        public ProductPage(List<Database.Product> invoiceList)
        {
            InitializeComponent();
            this.invoiceList = invoiceList;
            loadData();
        }

        private void loadData()
        {
            if (invoiceList.Count <= 0)
            {
                viewInvoiceBtn.Hide();
            }
            categoryList = DB.Categories;
            foreach (var item in categoryList)
            {
                categoryDropdown.AddItem(item.name);
            }

            productList = DB.Products;

            pquery = (from p in productList
                      where p.archived == false
                      orderby p.created_at
                      select p).Take(10);
            populateProducts();
        }


        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductDialogShow(new CustomControls.ProductDialog(DB));

        }

        public void editProductDialogShow(Database.Product p)
        {
            ProductDialogShow(new CustomControls.ProductDialog(p, DB));
        }

        public void ProductDialogShow(CustomControls.ProductDialog catDialog)
        {
            Form prompt = new Form()
            {
                Width = catDialog.Width + 50,
                Height = catDialog.Height + 50,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };

            prompt.Controls.Add(catDialog);
            catDialog.Dock = DockStyle.Fill;
            prompt.ShowDialog();

            populateProducts();
        }

        private void searchBox_OnValueChanged(object sender, EventArgs e)
        {

            if (selectedCatId != 0)
            {
                pquery = from p in productList
                         where p.archived == false
                         where p.name.Contains(searchBox.Text)
                         && p.category_id == selectedCatId
                         select p;
            }
            else
            {
                pquery = from p in productList
                         where p.archived == false
                         where p.name.Contains(searchBox.Text)
                         select p;
            }
                        populateProducts();
        }

        private void categoryDropdown_onItemSelected(object sender, EventArgs e)
        {
            var cquery = from cat in categoryList
                    where cat.name == categoryDropdown.selectedValue
                           select cat.Id;
            selectedCatId = cquery.First();

            pquery = from p in productList
                     where p.archived == false
                     where p.category_id == selectedCatId
                     select p;

            pquery = from p in productList
                     where p.archived == false
                     where p.category_id == selectedCatId
                     select p;
            populateProducts();
        }

        private void populateProducts()
        {
            productFlow.Controls.Clear();
            foreach (Database.Product p in pquery)
            {
                VendorPOS.ProductCard productCard = new ProductCard(p,this);  //publisher
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
