using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private static readonly string IMAGE_MISSING = "The image cannot be empty";
        private static readonly string SHARED_UNDEFINED = "Choose if the photo should be visible by other users";

        private ValidationProvider Provider;
        private bool InterfaceIsLocked = false;
        private Image InitialImage;

        public Photo Photo;

        public DLG_Photo(bool deletePhoto = false)
        {
            InitializeComponent();
            InterfaceIsLocked = deletePhoto;
            Text = InterfaceIsLocked ? "Delete a photo" : "Edit a photo";
        }

        private void DLG_Photo_Load(object sender, EventArgs e)
        {
            Provider = new ValidationProvider(this);
            DTP_Date.MaxDate = Photo == null ? DateTime.Now : Photo.CreationDate;

            if (Photo == null)
            {
                Photo = new Photo();
                Text = "Upload a new photo";
            }
            else
            {
                DataToDLG();
            }

            AddControlsToValidate();
            UpdateUI();
        }

        private void DLG_Photo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && !InterfaceIsLocked)
            {
                DLGToData();
            }
        }

        private void UpdateUI()
        {
            FBTN_RotateImage.Enabled = ImgBX_Image.BackgroundImage != null && !InterfaceIsLocked;
            TBX_Title.ReadOnly = InterfaceIsLocked;
            TBX_Keywords.ReadOnly = InterfaceIsLocked;
            RTBX_Description.ReadOnly = InterfaceIsLocked;
            DTP_Date.Enabled = !InterfaceIsLocked;
            CBX_Shared.Enabled = !InterfaceIsLocked;
            ImgBX_Image.Enabled = !InterfaceIsLocked;
        }

        private void DataToDLG()
        {
            TBX_Title.Text = Photo.Title;
            TBX_Keywords.Text = Photo.Keywords;
            RTBX_Description.Text = Photo.Description;
            CBX_Shared.CheckState = (Photo.Shared ? CheckState.Checked : CheckState.Unchecked);
            DTP_Date.Value = Photo.CreationDate;
            ImgBX_Image.BackgroundImage = Photo.GetOriginalImage();

            InitialImage = ImgBX_Image.BackgroundImage;
        }

        private void DLGToData()
        {
            WaitSplash.Show(this, "Processing...");
            Photo.Title = TBX_Title.Text;
            Photo.Keywords = TBX_Keywords.Text;
            Photo.Description = RTBX_Description.Text;
            Photo.Shared = CBX_Shared.Checked;
            Photo.CreationDate = DTP_Date.Value;
            if (InitialImage != ImgBX_Image.BackgroundImage)
            {
                Photo.SetImage(ImgBX_Image.BackgroundImage);
            }
        }

        #region Validations
        private void AddControlsToValidate()
        {
            Provider.AddControlToValidate(TBX_Title, TBX_Title_Validation);
            Provider.AddControlToValidate(ImgBX_Image, ImgBX_Image_Validation);
            Provider.AddControlToValidate(CBX_Shared, CBX_Shared_Validation);
        }
        private bool TBX_Title_Validation(ref string message)
        {
            message = TITLE_MISSING;
            return !string.IsNullOrWhiteSpace(TBX_Title.Text);
        }
        private bool ImgBX_Image_Validation(ref string message)
        {
            message = IMAGE_MISSING;
            return InterfaceIsLocked || ImgBX_Image.BackgroundImage != null;
        }
        private bool CBX_Shared_Validation(ref string message)
        {
            message = SHARED_UNDEFINED;
            return CBX_Shared.CheckState != CheckState.Indeterminate;
        }
        #endregion

        private void FBTN_RotateImage_Click(object sender, EventArgs e)
        {
            ImgBX_Image.RotateBgImage();
        }

        private void ImgBX_Image_BackgroundImageChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}
