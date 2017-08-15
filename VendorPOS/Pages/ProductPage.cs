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
        private System.Data.Linq.Table<Database.Product>  productList;

        private IEnumerable<Database.Product> pquery;
        private int selectedCatId;
        public ProductPage()
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

            if (selectedCatId != 0)
            {
                pquery = from p in productList
                         where p.name.Contains(searchBox.Text)
                         && p.category_id == selectedCatId
                         select p;
            }
            else
            {
                pquery = from p in productList
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
                     where p.category_id == selectedCatId
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
