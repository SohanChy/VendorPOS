namespace VendorPOS.Pages
{
    partial class LoadingPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingPage));
            this.circleProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // circleProgressBar
            // 
            this.circleProgressBar.animated = false;
            this.circleProgressBar.animationIterval = 5;
            this.circleProgressBar.animationSpeed = 300;
            this.circleProgressBar.BackColor = System.Drawing.Color.White;
            this.circleProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleProgressBar.BackgroundImage")));
            this.circleProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleProgressBar.ForeColor = System.Drawing.Color.SeaGreen;
            this.circleProgressBar.LabelVisible = true;
            this.circleProgressBar.LineProgressThickness = 8;
            this.circleProgressBar.LineThickness = 5;
            this.circleProgressBar.Location = new System.Drawing.Point(239, 91);
            this.circleProgressBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circleProgressBar.MaxValue = 100;
            this.circleProgressBar.Name = "circleProgressBar";
            this.circleProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleProgressBar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.circleProgressBar.Size = new System.Drawing.Size(201, 201);
            this.circleProgressBar.TabIndex = 0;
            this.circleProgressBar.Value = 0;
            // 
            // LoadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.circleProgressBar);
            this.Name = "LoadingPage";
            this.Size = new System.Drawing.Size(727, 394);
            this.Load += new System.EventHandler(this.LoadingPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCircleProgressbar circleProgressBar;
    }
}
