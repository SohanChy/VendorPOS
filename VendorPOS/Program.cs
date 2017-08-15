using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorPOS
{
    static class Program
    {
        public static string DB_FILE_PATH = System.IO.Path.Combine(Environment.CurrentDirectory, "FileDB_Permanent.mdf");
        public static string DB_CONN_STRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+ DB_FILE_PATH + ";Integrated Security=True";

        public static string CAT_ICONS_DIR = System.IO.Path.Combine(Environment.CurrentDirectory, "images", "cat-icons");
        public static string PRO_IMAGES_DIR = System.IO.Path.Combine(Environment.CurrentDirectory, "images", "pro-images");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            createDirs();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void createDirs()
        {
            System.IO.Directory.CreateDirectory(CAT_ICONS_DIR);
            System.IO.Directory.CreateDirectory(PRO_IMAGES_DIR);
        }

    }
}
