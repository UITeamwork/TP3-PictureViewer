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
    /* TODO :
    // About messagebox
    MessageBox.Show("Lorem Ipsum", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
    // Tooltips "FromDate" and "ToDate"
    */

    public partial class MainForm : Form
    {
        User Logged_User = null;
        PhotoFilter PhotoFilter = null;
        bool initializing = true;

        public MainForm()
        {
            InitializeComponent();
            Text = "Photo Manager Client application - Not connected";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Get server attention...
            WaitSplash.Show(this, "Connecting to Photo Manager...");
            string bidon = DBPhotosWebServices.GetServerImagesURLBase();
            WaitSplash.Hide();
            Update_UI();
        }

        private void Update_UI()
        {
            MI_Account_Profil.Enabled = Logged_User != null;
            FBTN_ViewPictureInfo.Enabled = PhotoBrowser.SelectedPhoto != null;
            FBTN_EditPicture.Enabled = PhotoBrowser.SelectedPhoto != null;
            FBTN_DeletePicture.Enabled = PhotoBrowser.SelectedPhoto != null;
            FBTN_PictureSlideshow.Enabled = PhotoBrowser.SelectedPhoto != null;
        }

        private void Init_UsersList()
        {
            foreach (User user in PhotoFilter.UsersList)
            {
                if (user.Name != null)
                    CBX_UsersList.Items.Add(user);
            }
            CBX_UsersList.SelectedIndex = 0;
        }

        private void LoadPhoto()
        {
            WaitSplash.Show(this, "Loading photos from server...");
            PhotoBrowser.LoadPhotos(PhotoFilter.GetPhotos());
            WaitSplash.Hide();
        }

        private void Init_Keywords_List()
        {
            CBX_Keywords.Items.Clear();
            CBX_Keywords.Items.Add("");

            foreach (string keyword in PhotoFilter.KeywordsList)
            {
                CBX_Keywords.Items.Add(keyword.Clone());
            }
            CBX_Keywords.SelectedIndex = 0;
        }

        private void Setup_Logged_User()
        {
            if (Logged_User != null)
            {
                Text = "Photo Manager Client application -" + Logged_User.Name;
                PhotoFilter = new PhotoFilter(Logged_User.Id);
                Init_UsersList();
                initializing = true;
                LoadPhoto();
                Init_Keywords_List();
                initializing = false;
            }
            else
            {
                CBX_UsersList.Items.Clear();
                CBX_Keywords.Items.Clear();
                PhotoBrowser.Clear();
                PhotoFilter = null;
            }
            Update_UI();
        }

        #region Control Events
        private void PhotoBrowser_SelectedChanged(object sender, EventArgs e)
        {
            Update_UI();
        }

        private void CBX_UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = (User)CBX_UsersList.SelectedItem;
            if (selectedUser.Id == -1) // Only mine
            {
                PhotoFilter.SetUserFilter(false, false, 0);
            }
            else
            {
                if (selectedUser.Id == 0) // All users
                {
                    PhotoFilter.SetUserFilter(false, true, 0);
                }
                else
                {
                    PhotoFilter.SetUserFilter(true, false, selectedUser.Id);
                }
            }
            initializing = true;
            PhotoFilter.SetKeywordsFilter(false, "");
            LoadPhoto();
            Init_Keywords_List();
            initializing = false;
        }

        private void CBX_Keywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initializing)
            {

                PhotoFilter.SetKeywordsFilter(true, CBX_Keywords.SelectedItem.ToString());

                LoadPhoto();
                PhotoBrowser.SelectNext();
                PhotoBrowser.Focus();
            }
        }

        private void FBTN_Blacklist_Click(object sender, EventArgs e)
        {
            // TODO : Get result from dialog and reload the images to hide blacklisted users
            if (new DLG_BlackList().ShowDialog() == DialogResult.OK)
            {
                // Do something...
            }
        }

        private void FBTN_Slideshow_Click(object sender, EventArgs e)
        {
            DLG_Slideshow dlg = new DLG_Slideshow();
            dlg.ShowDialog();
        }

        private void FBTN_ViewPictureInfo_Click(object sender, EventArgs e)
        {
            DLG_PhotoInfo dlg = new DLG_PhotoInfo()
            {
                // PhotoBrowser.SelectedPhoto will not be null since the button is not accessible if it's the case
                SelectedPhoto = PhotoBrowser.SelectedPhoto
            };
            dlg.Show();
        }

        #region Layout Menu
        private void BTN_Left_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Left;
        }

        private void BTN_Top_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Top;
        }

        private void BTN_Right_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Right;
        }

        private void BTN_Bottom_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Bottom;
        }
        #endregion

        #region Account Menu
        private void MI_Account_Login_Click(object sender, EventArgs e)
        {
            DLG_Login dlg = new DLG_Login();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.Logged_User;
                Setup_Logged_User();
            }
        }

        private void MI_Account_Profil_Click(object sender, EventArgs e)
        {
            DLG_Account dlg = new DLG_Account();
            dlg.User = Logged_User;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.User;
                Setup_Logged_User();
            }
        }

        private void Mi_Account_Create_Click(object sender, EventArgs e)
        {
            DLG_Account dlg = new DLG_Account();
             if (dlg.ShowDialog() == DialogResult.OK)
            {
                Logged_User = dlg.User;
                Setup_Logged_User();
            }
        }
        #endregion

        #endregion
    }
}
