using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace VendorPOS.Pages
{
    public partial class InvoicePage : UserControl
    {

        private List<Database.Product> invoiceList = new List<Database.Product>();
        private Double total = 0.00;
        private int totalQuantity = 0;

        public InvoicePage()
        {
            InitializeComponent();
            this.loadListViewData();
        }

        public InvoicePage(List<Database.Product> invoiceList)
        {
            InitializeComponent();
            this.invoiceList = invoiceList;
            this.loadListViewData();
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
            dataGridView1.Columns[1].Name = "Description";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Name = "Price";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[3].Width = 150;


            if (this.invoiceList.Count() > 0)
            {
                object[] rows = new object[this.invoiceList.Count()+1];
                int index = 0;
                List<Database.Product> tempList = this.invoiceList;
                List<Database.Product> DistinctItems = tempList.GroupBy(test => test.Id)
                                                       .Select(grp => grp.First())
                                                       .ToList();
                
                foreach (var item in DistinctItems)
                {
                    var duplicates = this.invoiceList.Where(p => p.Id == item.Id);
                    string[] row = new string[] { item.name, item.description, item.price.ToString(), duplicates.Count().ToString() };
                    rows[index] = row;
                    index++;
                    this.totalQuantity += duplicates.Count();
                    this.total += (Double) (item.price * duplicates.Count());
                }

                string[] lastRow = new string[] { "" , "TOTAL " , this.total.ToString(), this.totalQuantity.ToString()};
                rows[index] = lastRow;
                foreach (string[] rowArray in rows)
                {
                    if (rowArray != null)
                    {
                        dataGridView1.Rows.Add(rowArray);
                    }
                }
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generateInvoiceBtn_Click(object sender, EventArgs e)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";
 
            // Create an empty page
            PdfPage page = document.AddPage();
 
            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);
            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);
 
            // Draw the text
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.Center);
 
            // Save the document...
            const string filename = "HelloWorld.pdf";
            document.Save(filename);
        }
    }
}
