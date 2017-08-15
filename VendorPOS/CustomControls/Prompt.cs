using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorPOS.CustomControls
{
    public static class Prompt
    {
        public delegate bool confirm();

        public static UserControl ShowDialog(UserControl userControl, confirm confirm)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = userControl.Height + 80,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };

            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => {

            };

            var margin = confirmation.Margin;
            margin.Left = 350;
            confirmation.Margin = margin;

            FlowLayoutPanel f = new FlowLayoutPanel();
            prompt.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Controls.Add(userControl);
            f.Controls.Add(confirmation);

            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? userControl : null;
        }
    }

}
