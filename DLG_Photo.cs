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
        private ValidationProvider Provider;
        private bool InterfaceIsLocked = false;

        public Photo Photo;

        public DLG_Photo(bool deletePhoto = false)
        {
            InitializeComponent();
            InterfaceIsLocked = deletePhoto;
        }

        private void DLG_Photo_Load(object sender, EventArgs e)
        {
            Provider = new ValidationProvider(this);

            if (Photo == null)
            {
                Photo = new Photo();
            }
            else
            {
                DataToDLG();
            }

            UpdateUI();
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
        }

        private void FBTN_RotateImage_Click(object sender, EventArgs e)
        {
            Image img = (Image)ImgBX_Image.BackgroundImage.Clone();
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ImgBX_Image.BackgroundImage = img;
        }
    }
}
