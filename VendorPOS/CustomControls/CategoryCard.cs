using System.Windows.Forms;

namespace VendorPOS
{
    public partial class CategoryCard : UserControl
    {
        public Database.Category category;
        public Pages.CategoryPage myCatPage;

        public CategoryCard(Database.Category c, Pages.CategoryPage catPage)
        {
            InitializeComponent();
            category = c;
            myCatPage = catPage;
        }

        private void CategoryCard_Load(object sender, System.EventArgs e)
        {
            name.Text = category.name;
            pictureBox.ImageLocation = category.icon;

        }

        private void CategoryCard_DoubleClick(object sender, System.EventArgs e)
        {
            myCatPage.editCategoryDialogShow(category);
        }

        private void name_Click(object sender, System.EventArgs e)
        {
            myCatPage.editCategoryDialogShow(category);
        }
    }
}
