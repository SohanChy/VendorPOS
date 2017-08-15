using System.Windows.Forms;

namespace VendorPOS
{
    public partial class CategoryCard : UserControl
    {
        public Database.Category category;

        public CategoryCard()
        {
            InitializeComponent();
        }

        public CategoryCard(Database.Category c)
        {
            InitializeComponent();
            category = c;
        }

        private void CategoryCard_Load(object sender, System.EventArgs e)
        {
            name.Text = category.name;
            pictureBox.ImageLocation = category.icon;

        }
    }
}
