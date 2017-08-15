using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorPOS.Pages
{
    public partial class CategoryPage : UserControl
    {
        private Database.DataModelsDataContext DB = new Database.DataModelsDataContext();
        private System.Data.Linq.Table<Database.Category> categoryList;
        private IEnumerable<Database.Category> cquery;

        public CategoryPage()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            cquery = DB.Categories.OrderByDescending(x => x.Id);
            categoryList = DB.Categories;
            populateCategories();
        }

        private void searchBox_OnValueChanged(object sender, EventArgs e)
        {
            cquery = from c in categoryList
                     where c.name.Contains(searchBox.Text)
                     select c;
            populateCategories();
        }

        private void populateCategories()
        {
            categoryFlow.Controls.Clear();
            
            foreach (Database.Category c in cquery)
            {
                categoryFlow.Controls.Add(new CategoryCard(c));
            }
        }

    }
}
