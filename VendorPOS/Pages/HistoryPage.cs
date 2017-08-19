using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace VendorPOS.Pages
{
    public partial class HistoryPage : UserControl
    {
        private Database.DataModelsDataContext DB = new Database.DataModelsDataContext();
        List<Database.Invoice> invoiceList;

        DateTime selectedDate = DateTime.Today;


        //delegates
        public delegate void ViewInvoiceEventHandler(List<Database.Product> productList,Database.Invoice invoice,EventArgs args);
        public event ViewInvoiceEventHandler viewInvoiceEvent;

        protected virtual void OnViewInvoice(Database.Invoice inv)
        {
            if (viewInvoiceEvent != null)
            {
                List<Database.Product> productList = (from p in inv.Invoice_Products
                                                     select p.Product).ToList();
                viewInvoiceEvent(productList,inv, EventArgs.Empty);
            }
        }

        public HistoryPage()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            string[] monthNames =
                        System.Globalization.CultureInfo.CurrentCulture
                            .DateTimeFormat.MonthGenitiveNames;
            foreach (var item in monthNames)
            {
                if (!item.Equals(""))
                    monthPicker.AddItem(item);
            }

            string[] yrNames = new string[3] { "2017", "2016", "2015" };

            foreach (var item in yrNames)
            {
                YearPicker.AddItem(item);
            }

            loadData();
        }

        private void loadData()
        {
            
            invoiceList = (from inv in DB.Invoices
                           where inv.date.Month == selectedDate.Month
                          && inv.date.Year == selectedDate.Year
                          orderby inv.date descending
                                select inv).ToList();
            historyGridView.Rows.Clear();
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

            OnViewInvoice(selectedInvoice);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void YearPicker_onItemSelected(object sender, EventArgs e)
        {
            selectedDate = DateTime.Parse(selectedDate.Month + "/1/" + YearPicker.selectedValue).Date;
            label1.Text = selectedDate.ToString();
            loadData();
        }

        private void monthPicker_onItemSelected(object sender, EventArgs e)
        {
            selectedDate = DateTime.Parse( monthPicker.selectedValue + "/1/" + selectedDate.Year).Date;
            label1.Text = selectedDate.ToString();
            loadData();
        }

    }
}
