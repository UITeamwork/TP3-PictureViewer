using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class DLG_Help : Form
    {
        public DLG_Help()
        {
            InitializeComponent();
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/{1}.html", curDir,"HTMLPage1"));
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
