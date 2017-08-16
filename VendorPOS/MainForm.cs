﻿using System;
using System.Windows.Forms;

namespace VendorPOS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void ChangeContainer(UserControl u)
        {
            containerPane.Controls.Clear();
            containerPane.Controls.Add(u);
            u.Dock = DockStyle.Fill;
        }

        private void sohafn_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btn_Products_Click(object sender, EventArgs e)
        {
            ChangeContainer(new Pages.ProductPage());
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            ChangeContainer(new Pages.CategoryPage());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            ChangeContainer(new Pages.InvoicePage(new VendorPOS.ProductCard()));

        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_ApplicationName_Click(object sender, EventArgs e)
        {

        }
    }
}
