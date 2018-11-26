using PhotoManagerClient;
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
        private static readonly string DIMENSIONS_FORMAT = "{0} X {1}";

        public Photo SelectedPhoto { get; set; }

        public DLG_PhotoInfo()
        {
            InitializeComponent();
        }

        private void DLG_PhotoInfo_Load(object sender, EventArgs e)
        {
            OwnerInfoToDLG();
            PhotoInfoToDLG();
        }

        private void OwnerInfoToDLG()
        {
            User owner = User.GetAllUsers().First(u => u.Id == SelectedPhoto.OwnerId);
            LAB_OwnerName.Text = owner.Name;
            PBX_OwnerPicture.Image = owner.GetAvatarThumbnailImage();
        }

        private void PhotoInfoToDLG()
        {
            LAB_Shared.Text = (SelectedPhoto.Shared ? "SHARED" : "PRIVATE");
            TBX_Title.Text = SelectedPhoto.Title;
            DTP_PhotoDate.Value = SelectedPhoto.CreationDate;
            TBX_PictureSize.Text = string.Format(DIMENSIONS_FORMAT, SelectedPhoto.GetOriginalImage().Width, SelectedPhoto.GetOriginalImage().Height);
            RTBX_Description.Text = SelectedPhoto.Description;
            TBX_Keywords.Text = SelectedPhoto.Keywords;
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
