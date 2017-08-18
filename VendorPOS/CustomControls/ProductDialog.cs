using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorPOS.CustomControls
{
    public partial class ProductDialog : UserControl
    {
        public Database.DataModelsDataContext DB;
        public Database.Product product;
        
        private bool newModel = true;


        public ProductDialog(Database.Product product, Database.DataModelsDataContext DB)
        {
            InitializeComponent();

            this.product = product;
            this.newModel = false;
            this.DB = DB;
        }

        public ProductDialog(Database.DataModelsDataContext DB)
        {
            InitializeComponent();

            this.product = new Database.Product();
            this.newModel = true;
            deleteButton.Hide();

            this.DB = DB;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iconHolderBox.ImageLocation = FD.FileName;
            }
        }

        public bool confirm()
        {

            if (nameBox.Text.Count() > 0)
            {
                this.product.name = nameBox.Text;
                 product.name = this.nameBox.Text;
                 product.price = decimal.Parse(this.priceBox.Text);
                 product.image = this.iconHolderBox.ImageLocation;
                 product.description = this.descBox.Text;

                 this.product.expiry_date = this.datePicker.Value;


                 foreach (var item in DB.Categories)
                 {
                     if (categoryDropDown.selectedIndex != -1)
                     {
                         if (item.name.Equals(categoryDropDown.selectedValue))
                         {
                             product.Category = item;
                         }
                     }
                 }

                 if (iconHolderBox.ImageLocation != product.image)
                {
                    if (product.image != null)
                    {
                        System.IO.File.Delete(product.image);
                    }

                    string toFile = System.IO.Path.Combine(
                    Program.PRO_IMAGES_DIR,
                    DateTime.Now.ToString("yyyyMMddHHmmss") + System.IO.Path.GetExtension(iconHolderBox.ImageLocation)
                    );

                    System.IO.File.Copy(iconHolderBox.ImageLocation, toFile, true);
                    this.product.image = toFile;
                }


                if (this.newModel == true)
                {
                    DB.Products.InsertOnSubmit(product);
                }

                DB.SubmitChanges();

                return true;

            }
            else
            {
                nameBox.Focus();
                return false;

            }

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (confirm())
            {
                this.FindForm().Close();
            }
        }

        private void ProductDialog_Load(object sender, EventArgs e)
        {
            this.nameBox.Text = product.name;
            this.priceBox.Text = product.price.ToString();
            this.iconHolderBox.ImageLocation = product.image;
            this.descBox.Text = product.description;

            if (this.product.expiry_date != null)
            {
                this.datePicker.Value = (System.DateTime)this.product.expiry_date;

            }


            foreach (var item in DB.Categories)
            {
                categoryDropDown.AddItem(item.name);

                if (product.category_id == item.Id)
                {
                    //select by default
                }
            }
            

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            DB.Invoice_Products.DeleteAllOnSubmit(product.Invoice_Products);
            DB.Products.DeleteOnSubmit(product);
            DB.SubmitChanges();

            this.FindForm().Close();
            
        }


    }
}
