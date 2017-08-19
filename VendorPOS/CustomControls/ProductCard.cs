using System;
using System.Windows.Forms;

namespace VendorPOS
{
    public delegate void EventHandler(object sender, EventArgs e);  
    //delegate
    public delegate void InvoiceAddEvent();

    public partial class ProductCard : UserControl
    {
        public Database.Product product;
        Pages.ProductPage myProPage;

        public event EventHandler<CustomEventArgs> RaiseCustomEvent;
        //private event InvoiceAddEvent InvoiceAdded
        //new delegate 
        public delegate void AddToInvoiceEventHandler(Database.Product source,EventArgs args);
        public event AddToInvoiceEventHandler InvoiceAdded;

        protected virtual void OnInvoiceAdded() {
            if (InvoiceAdded != null)
            {
                InvoiceAdded(this.product,EventArgs.Empty);
            }
        }

        public void DoSomething()
        {
            // Write some code that does something useful here
            // then raise the event. You can also raise an event
            // before you execute a block of code.
            //OnRaiseCustomEvent(new CustomEventArgs("Did something"));
        }

        public ProductCard(Database.Product p, Pages.ProductPage myProPage)
        {
            InitializeComponent();
            product = p;
            this.myProPage = myProPage;
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {
            name.Text = product.name;

            desc.Text = product.archived.ToString() ;
            //desc.Text = product.description;
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

        private void button1_Click(object sender, EventArgs e)
        {
            OnInvoiceAdded();
        }

        private void handleInvoiceAdded() {

            name.Text = "Hello";
        }

         protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter
                e.Message += String.Format(" at {0}", DateTime.Now.ToString());

                // Use the () operator to raise the event.
                handler(this, e);
            }
        }

         private void EditButton_Click(object sender, EventArgs e)
         {
             myProPage.editProductDialogShow(product);

         }
    }


    // Define a class to hold custom event info
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
