using System;
using System.Windows.Forms;

namespace VendorPOS
{
    public partial class CategoryControl : UserControl
    {
        public CategoryControl()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 20; x++)
            {
                    ProductPanel.Controls.Add(new CategoryCard());
            }
        }
    }
}
