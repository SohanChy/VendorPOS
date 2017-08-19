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
        private Database.DataModelsDataContext DB = new Database.DataModelsDataContext();
        private List<Database.Product> invoiceList = new List<Database.Product>();
        private Double total = 0.00;
        private int totalQuantity = 0;
        private List<Database.Product> DistinctItems;

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
            dataGridView1.Columns[2].Name = "Quantity";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Name = "Price";
            dataGridView1.Columns[3].Width = 150;

            if (this.invoiceList.Count() > 0)
            {
                object[] rows = new object[this.invoiceList.Count()+1];
                int index = 0;
                List<Database.Product> tempList = this.invoiceList;
                this.DistinctItems = tempList.GroupBy(test => test.Id)
                                                       .Select(grp => grp.First())
                                                       .ToList();
                
                foreach (var item in DistinctItems)
                {
                    var duplicates = this.invoiceList.Where(p => p.Id == item.Id);
                    string[] row = new string[] { item.name, item.description,duplicates.Count().ToString(), item.price.ToString() };
                    rows[index] = row;
                    index++;
                    this.totalQuantity += duplicates.Count();
                    this.total += (Double) (item.price * duplicates.Count());
                }

                string[] lastRow = new string[] { "" , "TOTAL " , this.totalQuantity.ToString(),this.total.ToString()};
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
            createPDF();

            saveToDB();

        }

        private void saveToDB()
        {

            Database.Invoice invoice = new Database.Invoice();
            invoice.customer_name =customerNameBox.Text;
            invoice.customer_phone = phoneNoBox.Text;
            invoice.date = datePicker.Value;
            invoice.total = decimal.Parse(total.ToString());
  
            DB.Invoices.InsertOnSubmit(invoice);
            DB.SubmitChanges();
            
            //Complex stuff done here for invoice products generation
            List<Database.Product> tempList = this.invoiceList;
            this.DistinctItems = tempList.GroupBy(test => test.Id)
                                                       .Select(grp => grp.First())
                                                       .ToList();

            foreach (var item in DistinctItems)
            {


                var duplicates = this.invoiceList.Where(p => p.Id == item.Id);

                var invoiceProduct = new Database.Invoice_Product();

                invoiceProduct.invoice_id = invoice.Id;
                invoiceProduct.product_id = item.Id;
                invoiceProduct.quantity = duplicates.Count();

                DB.Invoice_Products.InsertOnSubmit(invoiceProduct);

            }

            DB.SubmitChanges();
        }

        private void createPDF()
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Invoice";
            // Create an empty page
            PdfPage page = document.AddPage();
            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);
            // Create a font
            XFont font = new XFont("Verdana", 10, XFontStyle.Regular);
            XFont headFont = new XFont("Verdana", 10, XFontStyle.Bold);
            
            // Draw the text
            gfx.DrawString("VendorPOS Invoice", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height),
            XStringFormats.TopCenter);

            int heightScale = 100;
            int widthScale = 100;

            if (dataGridView1.Rows.Count > 1)
            {
                gfx.DrawString("Product Name", headFont, XBrushes.Black,
                      new XRect(0, 50, page.Width, page.Height),
                      XStringFormats.TopLeft);

                gfx.DrawString("Description", headFont, XBrushes.Black,
                      new XRect(200, 50, page.Width, page.Height),
                      XStringFormats.TopLeft);

                gfx.DrawString("Quantity", headFont, XBrushes.Black,
                      new XRect(400, 50, page.Width, page.Height),
                      XStringFormats.TopLeft);

                gfx.DrawString("Price", headFont, XBrushes.Black,
                      new XRect(500, 50, page.Width, page.Height),
                      XStringFormats.TopLeft);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var productName = row.Cells[0].Value ?? string.Empty;
                    var productDescription = row.Cells[1].Value ?? string.Empty;
                    var productPrice = row.Cells[2].Value ?? string.Empty;
                    var productQuantity = row.Cells[3].Value ?? string.Empty;

                    gfx.DrawString(productName.ToString(), font, XBrushes.Black,
                        new XRect(0, 0 + heightScale, page.Width, page.Height),
                        XStringFormats.TopLeft);

                    var description = productDescription.ToString();

                    if (description.Length > 20)
                    {
                        description = description.Substring(0,20);
                    }

                    gfx.DrawString(description, font, XBrushes.Black,
                        new XRect(200, 0 + heightScale, page.Width, page.Height),
                        XStringFormats.TopLeft);

                    gfx.DrawString(productPrice.ToString(), font, XBrushes.Black,
                        new XRect(400, 0 + heightScale, page.Width, page.Height),
                        XStringFormats.TopLeft);

                    gfx.DrawString(productQuantity.ToString(), font, XBrushes.Black,
                        new XRect(500, 0 + heightScale, page.Width, page.Height),
                        XStringFormats.TopLeft);
                    heightScale += 50;
                }
            }

            // Save the document

            SaveFileDialog saveFileDialog = new SaveFileDialog();


            saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
            saveFileDialog.DefaultExt = ".pdf";
            saveFileDialog.FileName = "Invoice";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog.FileName;
                document.Save(filename);
            }
        }


        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, DataGridViewCellEventArgs e)
        {
            int totalQuantity = 0;
            int index = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                /*
                if (index >= dataGridView1.Rows.Count-2)
                {
                    break;
                }
                totalQuantity += Int32.Parse(row.Cells[2].Value.ToString());
                index++;
                 */
                
            }
            dataGridView1.Rows[3].Cells[2].Value = "Hello World";
            // Save the document
            PdfDocument document = new PdfDocument();
            const string filename = "Hell.pdf";
            document.Save(filename);
        }
    }

}
