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
        private User Logged_User = null;
        private bool Initializing = true;
        private DLG_PhotoInfo InfoOnSelected = new DLG_PhotoInfo();
        private PhotoFilter PhotoFilter;
        private bool PhotoBrowserIsExpanded = false;

        /// <summary>
        /// Constructed using <see cref="PhotoFilter.UsersList"/> that is loaded on construction. We don't want to load all users multiple times in the program.
        /// <para>To make it complete, we only add the <see cref="Logged_User"/> and remove the first two entries ("only mine" and "all users")</para>
        /// </summary>
        public static readonly List<User> AllUsers = new List<User>();

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
            bool UserIsLoggedIn = Logged_User != null;
            // PhotoIsSelected implies that the user is logged in
            bool PhotoIsSelected = UserIsLoggedIn && PhotoBrowser.SelectedPhoto != null;
            // PhotoIsOwnedByLoggedUser implies that the user is logged in and that a photo is currently selected
            bool PhotoIsOwnedByLoggedUser = PhotoIsSelected && PhotoBrowser.SelectedPhoto.OwnerId == Logged_User.Id;

            MI_Account_Profil.Enabled = UserIsLoggedIn;
            MI_Blacklist.Enabled = UserIsLoggedIn;
            FBTN_NewPicture.Enabled = UserIsLoggedIn;
            FBTN_ViewPictureInfo.Enabled = PhotoIsSelected;
            FBTN_EditPicture.Enabled = PhotoIsOwnedByLoggedUser;
            FBTN_DeletePicture.Enabled = PhotoIsOwnedByLoggedUser;
            FBTN_PictureSlideshow.Enabled = PhotoIsSelected;
        }

        private void Init_UsersList()
        {
            foreach (User user in PhotoFilter.UsersList)
            {
                if (user.Name != null && user.Name != Logged_User.Name)
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
                PhotoFilter = new PhotoFilter(Logged_User.Id);
                AllUsers.AddRange(PhotoFilter.UsersList);
                AllUsers.Add(Logged_User);
                AllUsers.RemoveRange(0, 2); // Remove "only mine" and "all users"

                Init_UsersList();
                Initializing = true;
                LoadPhoto();
                Init_Keywords_List();
                Initializing = false;
            }
            else
            {
                CBX_UsersList.Items.Clear();
                CBX_Keywords.Items.Clear();
                PhotoBrowser.Clear();
                PhotoFilter = null;
            }
            MI_Account_Login.Text = (Logged_User != null ? "Disconnect" : "Login");
            Text = "Photo Manager Client application -" + (Logged_User != null ? Logged_User.Name : "Not Connected");
            Update_UI();
        }

        private void HideShowAllGroups(bool isShow)
        {
            foreach(GroupBox group in FLP_Groups.Controls)
            {
                ChangeGroupVisibility(group, isShow);
            }
        }

        private bool AllGroupsAreHidden()
        {
            foreach(Control group in FLP_Groups.Controls)
            {
                if (group.Visible)
                {
                    return false;
                }
            }
            return true;
        }

        private void ChangeGroupVisibility(GroupBox gbx, bool isVisible)
        {
            FLP_Groups.Visible = (isVisible ? isVisible : FLP_Groups.Visible);
            gbx.Visible = isVisible;

            if (AllGroupsAreHidden())
            {
                if (!PhotoBrowserIsExpanded)
                {
                    PhotoBrowser.Location = FLP_Groups.Location;
                    PhotoBrowser.Height += FLP_Groups.Height;
                    FLP_Groups.Visible = false;
                    PhotoBrowserIsExpanded = true;
                }
            }
            else if (PhotoBrowserIsExpanded)
            {
                PhotoBrowser.Location = new Point(PhotoBrowser.Location.X, PhotoBrowser.Location.Y + FLP_Groups.Height);
                PhotoBrowser.Height -= FLP_Groups.Height;
                FLP_Groups.Visible = true;
                PhotoBrowserIsExpanded = false;
            }
        }

        #region Control Events
        private void PhotoBrowser_SelectedChanged(object sender, EventArgs e)
        {
            Update_UI();
            if (InfoOnSelected.Visible)
            {
                InfoOnSelected.SelectedPhoto = PhotoBrowser.SelectedPhoto;
                InfoOnSelected.UpdateDLG();
            }
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
            Initializing = true;
            PhotoFilter.SetKeywordsFilter(false, "");
            LoadPhoto();
            Init_Keywords_List();
            Initializing = false;
        }

        private void CBX_Keywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Initializing)
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
            // PhotoBrowser.SelectedPhoto will not be null since the button is not accessible if it's the case
            InfoOnSelected.SelectedPhoto = PhotoBrowser.SelectedPhoto;
            InfoOnSelected.UpdateDLG();
        }

        #region Layout Menu

        #region Browser Disposition
        private void MI_Left_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Left;
        }

        private void MI_Top_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Top;
        }

        private void MI_Right_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Right;
        }

        private void MI_Bottom_Click(object sender, EventArgs e)
        {
            PhotoBrowser.Placement = PhotoBrowserPlacement.Bottom;
        }
        #endregion

        #region Hide/Show Groups
        private void MI_HideAll_Click(object sender, EventArgs e)
        {
            HideShowAllGroups(false);
        }

        private void MI_ShowAll_Click(object sender, EventArgs e)
        {
            HideShowAllGroups(true);
        }

        private void MI_HSCommands_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Commands, !GBX_Commands.Visible);
        }

        private void MI_HSUserFilter_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Users, !GBX_Users.Visible);
        }

        private void MI_HSKeywordFilter_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Keyword, !GBX_Keyword.Visible);
        }

        private void MI_HSDateFilter_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Date, !GBX_Date.Visible);
        }

        private void MI_HStodo_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Todo, !GBX_Todo.Visible);
        }
        #endregion

        #endregion

        #region Account Menu
        private void MI_Account_Login_Click(object sender, EventArgs e)
        {
            if (Logged_User == null)
            {
                DLG_Login dlg = new DLG_Login();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Logged_User = dlg.Logged_User;
                    Setup_Logged_User();
                }
            }
            else
            {
                Logged_User = null;
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
