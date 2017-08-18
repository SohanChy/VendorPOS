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
    public partial class HistoryPage : UserControl
    {
        private Database.DataModelsDataContext DB = new Database.DataModelsDataContext();
        List<Database.Invoice> invoiceList;

        public HistoryPage()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            DateTime today = DateTime.Today;
            invoiceList = (from inv in DB.Invoices
                          where inv.date.Month == today.Month
                          && inv.date.Year == today.Year
                          orderby inv.date descending
                                select inv).ToList();

            foreach (var inv in invoiceList)
            {
                historyGridView.Rows.Add(new[] 
                    { inv.Id.ToString(), 
                        inv.date.Date.ToShortDateString(),
                        inv.customer_name.ToString(), 
                        inv.total.ToString() 
                    });
            }
        }

        private void rowDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = historyGridView.SelectedRows[0].Index;

            Database.Invoice selectedInvoice = invoiceList[index];
            //proof of concept that object comes
            label1.Text = selectedInvoice.customer_name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
