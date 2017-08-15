using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace VendorPOS
{
    public partial class ProductControl : UserControl
    {
        private Database.DataModelsDataContext DB = new Database.DataModelsDataContext();
        private System.Data.Linq.Table<Database.Category> categoryList;
        private System.Data.Linq.Table<Database.Product>  productList;

        private IEnumerable<Database.Product> pquery;
        public ProductControl()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            categoryList = DB.Categories;

            foreach (var item in categoryList)
            {
                categoryDropdown.AddItem(item.name);
            }

            productList = DB.Products;
            
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
                productFlow.Controls.Add(new ProductCard(p));
            }
        }
    }
}
