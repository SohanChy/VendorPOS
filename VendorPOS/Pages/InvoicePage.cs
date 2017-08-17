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
    public partial class InvoicePage : UserControl
    {

        private string id;
        public InvoicePage()
        {
            InitializeComponent();
            this.loadListViewData();
        }


        public InvoicePage(VendorPOS.ProductCard pc)
        {
            InitializeComponent();
            this.loadListViewData();
            pc.RaiseCustomEvent += HandleCustomEvent;
        }


    

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadListViewData()
        {

            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;

            //column header style
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // column header names.
            dataGridView1.Columns[0].Name = "Product Name";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Name = "Category";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Name = "Price";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Name = "Add To List";
            dataGridView1.Columns[3].Width = 150;

            string[] row1 = new string[] { "Meatloaf", "Main Dish", "ground beef",
           "**" };
            string[] row2 = new string[] { "Key Lime Pie", "Dessert", 
           "lime juice, evaporated milk", "****" };
            string[] row3 = new string[] { "Orange-Salsa Pork Chops", "Main Dish", 
           "pork chops, salsa, orange juice", "****" };
            string[] row4 = new string[] { "Black Bean and Rice Salad", "Salad", 
           "black beans, brown rice", "****" };
            string[] row5 = new string[] { "Chocolate Cheesecake", "Dessert", 
           "cream cheese", "***" };
            string[] row6 = new string[] { "Black Bean Dip", "Appetizer", 
           "black beans, sour cream", "***" };
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6 };

            foreach (string[] rowArray in rows)
            {
                dataGridView1.Rows.Add(rowArray);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
        }

    
          // Define what actions to take when the event is raised.
        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(id + " received this message: {0}", e.Message);
            string[] row6 = new string[] { "NEW", "NEW", 
           "NEW beans, sour cream", "***" };
            dataGridView1.Rows.Add(row6);
        }


        //event handler 
        public void OnInvoiceAdded(object source,EventArgs e)
        {
            Console.WriteLine("In Invoice page Go !!");
        }
    }
}
