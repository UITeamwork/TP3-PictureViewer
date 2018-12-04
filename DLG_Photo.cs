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
using PhotoManagerClient;
using Validation;

namespace Client_PM
{
    public partial class DLG_Photo : Form
    {
        private static readonly string TITLE_MISSING = "The title cannot be empty";
        private static readonly string SHARED_UNDEFINED = "Shared cannot be undefined";

        private ValidationProvider Provider;

        public Photo Photo;

        public DLG_Photo()
        {
            InitializeComponent();
        }

        private void DLG_Photo_Load(object sender, EventArgs e)
        {
            // TODO : Add OnSubmit tasks/validations
            Provider = new ValidationProvider(this);
            AddControlToValidate();
        }

        #region Validations
        private void AddControlToValidate()
        {

        }

        private bool TBX_Title_Validation(ref string message)
        {
            message = TITLE_MISSING;
            return !string.IsNullOrWhiteSpace(TBX_Title.Text);
        }
        private bool CBX_Shared_Validation(ref string message)
        {
            message = SHARED_UNDEFINED;
            return !CB;
        }
        #endregion

        private void FBTN_Rotate_Click(object sender, EventArgs e)
        {

        }
    }
}
