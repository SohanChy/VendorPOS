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
    public partial class LoadingPage : UserControl
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            circleProgressBar.animated = true;
            circleProgressBar.animationIterval = 5;
            circleProgressBar.animationSpeed = 10;
        }
    }
}
