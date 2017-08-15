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
    public partial class CategoryDialog : UserControl
    {

        public Database.DataModelsDataContext DB;
        public Database.Category category;
        private bool newModel = true;

        public CategoryDialog(Database.Category category,Database.DataModelsDataContext DB)
        {
            InitializeComponent();

            this.category = category;
            this.newModel = false;
            this.DB = DB;
        }

        public CategoryDialog(Database.DataModelsDataContext DB)
        {
            InitializeComponent();

            this.category = new Database.Category();
            this.newModel = true;
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

        //this is save button alternative
        public bool confirm() {

            if (nameBox.Text.Count() > 0)
            {
                this.category.name = nameBox.Text;

                string toFile = System.IO.Path.Combine(
                Program.CAT_ICONS_DIR,
                DateTime.Now.ToString("yyyyMMddHHmmss") + System.IO.Path.GetExtension(iconHolderBox.ImageLocation)
                );

                System.IO.File.Copy(iconHolderBox.ImageLocation, toFile, true);
                this.category.icon = toFile;

                if (this.newModel == true)
                {
                    DB.Categories.InsertOnSubmit(category);
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

        public void saveButton_Click(object sender, EventArgs e) {

            if(confirm())
            {
                this.FindForm().Close();
            }
            
        }

        private void CategoryDialog_Load(object sender, EventArgs e)
        {
            this.nameBox.Text = category.name;
            this.iconHolderBox.ImageLocation = category.icon;

        }

    }
}
