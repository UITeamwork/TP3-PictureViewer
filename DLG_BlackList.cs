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
    public partial class DLG_BlackList : Form
    {
        public DLG_BlackList()
        {
            InitializeComponent();
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete all users from your blacklist?\nThis action is permanent.", "Confirm reset", MessageBoxButtons.YesNo);
        }
    }
}
