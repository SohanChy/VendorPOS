using System;
using System.Windows.Forms;

namespace VendorPOS
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public Database.Product product;

        public ProductCard(Database.Product p)
        {
            InitializeComponent();
            product = p;
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {
            name.Text = product.name;
            desc.Text = product.description;
            price.Text = "BDT " + product.price.ToString();
            pictureBox.ImageLocation = product.image;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void ActionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
