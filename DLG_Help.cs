using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class DLG_Help : Form
    {
        private static readonly string CREATED_FILE_NAME = "HelpData";

        public string ContentFromResources { get; set; }

        public DLG_Help()
        {
            InitializeComponent();
        }

        private void LoadHelpFile()
        {
            // Create an absolute path leading to the created file (local file url)
            Uri url = new Uri(string.Format(@"file:///{0}/{1}", Directory.GetCurrentDirectory(), CREATED_FILE_NAME + ".html"));
            // Load the file in the WebBrowser
            WB_HelpBrowser.Navigate(url);
        }

        private void DLG_Help_Load(object sender, EventArgs e)
        {
            // Take all the content of a file and write to an external .html file (created in the same place as the executable)
            File.WriteAllBytes(CREATED_FILE_NAME + ".html", Encoding.ASCII.GetBytes(ContentFromResources));
            LoadHelpFile();
        }

        private void DLG_Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(Directory.GetCurrentDirectory() + "//" + CREATED_FILE_NAME + ".html");
        }
    }
}
