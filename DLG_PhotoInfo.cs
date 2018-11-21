using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class DLG_PhotoInfo : Form
    {
        private static readonly string DIMENSIONS_FORMAT = "{0}px X {1}px";

        public DLG_PhotoInfo()
        {
            InitializeComponent();

            string str = string.Format(DIMENSIONS_FORMAT, "100", "100");
            MessageBox.Show(str);
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {

        }
    }
}
