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
    public partial class MainForm : Form
    {
        private User Logged_User = null;
        private DLG_PhotoInfo InfoOnSelected = new DLG_PhotoInfo();
        private PhotoFilter PhotoFilter = null;
        private bool PhotoBrowserIsExpanded = false;
        private int InitialBrowserHeight;
        private bool Initializing = true;

        public static List<Photo> photos;
         
        #region FBTN_PhotoToSlideshow
        private List<Image> AddToSlideShow = new List<Image>
        {
            Properties.Resources.IMG_AddPicture_Clicked,
            Properties.Resources.IMG_AddPicture_Disabled,
            Properties.Resources.IMG_AddPicture_Neutral,
            Properties.Resources.IMG_AddPicture_Over
        };
        private List<Image> RemoveFromSlideShow = new List<Image>
        {
            Properties.Resources.IMG_RemovePicture_Clicked,
            Properties.Resources.IMG_RemovePicture_Disabled,
            Properties.Resources.IMG_RemovePicture_Neutral,
            Properties.Resources.IMG_RemovePicture_Over
        };
        #endregion

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
            WaitSplash.Show(this, "Initializing(this might take a moment)...");
            photos = DBPhotosWebServices.GetAllPhotos();
            Load_Settings();
            DTP_From.MaxDate = DateTime.Now;
            DTP_To.MaxDate = DateTime.Now;
            InitialBrowserHeight = PhotoBrowser.Height;
            WaitSplash.Hide();

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

            FBTN_PhotoToSlideshow.SetImages(PhotoIsSelected && DLG_Slideshow.SlideShowList.Contains(PhotoBrowser.SelectedPhoto.Id) ?  RemoveFromSlideShow : AddToSlideShow);
            FBTN_PhotoToSlideshow.BackgroundImage = (FBTN_PhotoToSlideshow.Enabled ? FBTN_PhotoToSlideshow.NeutralImage : FBTN_PhotoToSlideshow.DisabledImage);
            FBTN_PhotoToSlideshow.Text = (PhotoIsSelected && DLG_Slideshow.SlideShowList.Contains(PhotoBrowser.SelectedPhoto.Id) ? "Remove photo from your slideshow" : "Add photo to your slideshow");

            MI_Account_Profil.Enabled = UserIsLoggedIn;
            MI_Blacklist.Enabled = UserIsLoggedIn;
            FBTN_NewPicture.Enabled = UserIsLoggedIn;
            FBTN_ViewPictureInfo.Enabled = PhotoIsSelected;
            FBTN_EditPicture.Enabled = PhotoIsOwnedByLoggedUser;
            FBTN_DeletePicture.Enabled = PhotoIsOwnedByLoggedUser;
            FBTN_PhotoToSlideshow.Enabled = PhotoIsSelected;
            GBX_Date.Enabled = UserIsLoggedIn;
            GBX_Keyword.Enabled = UserIsLoggedIn;
            GBX_Managers.Enabled = UserIsLoggedIn;
            GBX_Users.Enabled = UserIsLoggedIn;
        }

        private void LoadPhoto()
        {
            WaitSplash.Show(this, "Loading photos from server...");
            PhotoBrowser.LoadPhotos(PhotoFilter.GetPhotos().Where(p => !DLG_BlackList.BlacklistedUsers.Contains(p.OwnerId)).ToList());
            WaitSplash.Hide();
        }

        #region Init Methods
        private void Init_UsersList()
        {
            foreach (User user in PhotoFilter.UsersList)
            {
                if (user.Name != null && user.Name != Logged_User.Name)
                    CBX_UsersList.Items.Add(user);
            }
            CBX_UsersList.SelectedIndex = 0;
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
                if(Initializing)
                {
                    AllUsers.AddRange(PhotoFilter.UsersList);
                    AllUsers.Add(Logged_User);
                    AllUsers.RemoveRange(0, 2); // Remove "only mine" and "all users"
                    Initializing = false;
                }
                Init_UsersList();
                LoadPhoto();
                Init_Keywords_List();
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
        #endregion

        #region Hide/Show Groups Methods
        private void HideShowAllGroups(bool isShow)
        {
            foreach(GroupBox group in FLP_Groups.Controls)
            {
                ChangeGroupVisibility(group, isShow);
            }
            foreach (var DropDownItem in MI_HideGroups.DropDownItems)
            {
                if (DropDownItem is ToolStripMenuItem) { (DropDownItem as ToolStripMenuItem).Checked = isShow; }
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

            PhotoBrowser.ToggleHidePhotosList();
            if (AllGroupsAreHidden())
            {
                if (!PhotoBrowserIsExpanded)
                {
                    PhotoBrowser.Height = InitialBrowserHeight + FLP_Groups.Height;
                    PhotoBrowser.Location = FLP_Groups.Location;
                    FLP_Groups.Visible = false;
                    PhotoBrowserIsExpanded = true;
                }
            }
            else if (PhotoBrowserIsExpanded)
            {
                PhotoBrowser.Height -= FLP_Groups.Height;
                PhotoBrowser.Location = new Point(PhotoBrowser.Location.X, PhotoBrowser.Location.Y + FLP_Groups.Height);
                FLP_Groups.Visible = true;
                PhotoBrowserIsExpanded = false;
            }
            PhotoBrowser.ToggleHidePhotosList();
        }
        #endregion

        #region Control Events
        private void PhotoBrowser_SelectedChanged(object sender, EventArgs e)
        {
            if (InfoOnSelected.Visible)
            {
                InfoOnSelected.SelectedPhoto = PhotoBrowser.SelectedPhoto;
                InfoOnSelected.UpdateDLG();
            }
            Update_UI();
        }

        #region Flash Buttons Events
        private void FBTN_Blacklist_Click(object sender, EventArgs e)
        {
            if (new DLG_BlackList(Logged_User.Id).ShowDialog() == DialogResult.OK)
            {
                LoadPhoto();
            }
        }

        private void FBTN_Slideshow_Click(object sender, EventArgs e)
        {
            DLG_Slideshow dlg = new DLG_Slideshow();
            dlg.PhotoPool = photos;
            dlg.ShowDialog();
        }

        private void FBTN_ViewPictureInfo_Click(object sender, EventArgs e)
        {
            // PhotoBrowser.SelectedPhoto will not be null since the button is not accessible if it's the case
            InfoOnSelected.SelectedPhoto = PhotoBrowser.SelectedPhoto;
            InfoOnSelected.UpdateDLG();        
        }

        private void FBTN_NewPicture_Click(object sender, EventArgs e)
        {
            DLG_Photo dlg = new DLG_Photo();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dlg.Photo.OwnerId = Logged_User.Id;
                DBPhotosWebServices.CreatePhoto(dlg.Photo);
                LoadPhoto();
            }
        }

        private void FBTN_EditPicture_Click(object sender, EventArgs e)
        {
            DLG_Photo dlg = new DLG_Photo();
            dlg.Photo = PhotoBrowser.SelectedPhoto;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dlg.Photo.OwnerId = Logged_User.Id;
                DBPhotosWebServices.UpdatePhoto(dlg.Photo);
                LoadPhoto();
            }
        }

        private void FBTN_DeletePicture_Click(object sender, EventArgs e)
        {
            DLG_Photo dlg = new DLG_Photo(true);
            dlg.Photo = PhotoBrowser.SelectedPhoto;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dlg.Photo.OwnerId = Logged_User.Id;
                DBPhotosWebServices.DeletePhoto(dlg.Photo);
                LoadPhoto();
            }
        }

        private void FBTN_PictureSlideshow_Click(object sender, EventArgs e)
        {
            if (!DLG_Slideshow.SlideShowList.Contains(PhotoBrowser.SelectedPhoto.Id))
            {
                DLG_Slideshow.SlideShowList.Add(PhotoBrowser.SelectedPhoto.Id);
            }
            else
            {
                DLG_Slideshow.SlideShowList.Remove(PhotoBrowser.SelectedPhoto.Id);
            }
            Update_UI();
        }
        #endregion

        #region Filters
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

            PhotoFilter.SetKeywordsFilter(false, "");
            LoadPhoto();
            Init_Keywords_List();
        }

        private void CBX_KeywordFilter_CheckedChanged(object sender, EventArgs e)
        {
            string keywords = (CBX_Keywords.SelectedItem != null ? CBX_Keywords.SelectedItem.ToString() : "");
            PhotoFilter.SetKeywordsFilter(CBX_KeywordFilter.Checked, keywords);
            LoadPhoto();
        }

        private void CBX_Keywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_KeywordFilter.Checked)
            {
                PhotoFilter.FilterByKeywords = true;
                PhotoFilter.Keywords = CBX_Keywords.SelectedItem.ToString();
                LoadPhoto();
            }
        }

        private void DTP_From_ValueChanged(object sender, EventArgs e)
        {
            if (CBX_DateFilter.Checked)
            {
                PhotoFilter.StartDate = DTP_From.Value;
                LoadPhoto();
            }
        }

        private void DTP_To_ValueChanged(object sender, EventArgs e)
        {
            if (CBX_DateFilter.Checked)
            {
                PhotoFilter.EndDate = DTP_To.Value;
                LoadPhoto();
            }
        }

        private void CBX_DateFilter_CheckedChanged(object sender, EventArgs e)
        {
            PhotoFilter.SetDateFilter(CBX_DateFilter.Checked, DTP_From.Value, DTP_To.Value);
            LoadPhoto();
        }

        private void CBX_ExcludeMine_CheckedChanged(object sender, EventArgs e)
        {
            PhotoFilter.ExludeUserRequester = CBX_ExcludeMine.Checked;
            LoadPhoto();
        }
        #endregion

        #region Help Menu
        private void MI_About_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void MI_DisplayHelp_Click(object sender, EventArgs e)
        {
            DLG_Help help = new DLG_Help();
            help.ContentFromResources = Properties.Resources.HTMLPage1;
            help.ShowDialog();
        }
        #endregion

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
            MI_ShowAll.Checked = false;
            MI_HideAll.Checked = false;
        }

        private void MI_HSCommands_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Commands, !GBX_Commands.Visible);
            MI_HSCommands.Checked = !MI_HSCommands.Checked;
        }

        private void MI_HSUserFilter_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Users, !GBX_Users.Visible);
            MI_HSUserFilter.Checked = !MI_HSUserFilter.Checked;
        }

        private void MI_HSKeywordFilter_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Keyword, !GBX_Keyword.Visible);
            MI_HSKeywordFilter.Checked = !MI_HSKeywordFilter.Checked;
        }

        private void MI_HSDateFilter_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Date, !GBX_Date.Visible);
            MI_HSDateFilter.Checked = !MI_HSDateFilter.Checked;
        }

        private void MI_HStodo_Click(object sender, EventArgs e)
        {
            ChangeGroupVisibility(GBX_Managers, !GBX_Managers.Visible);
            MI_HSManagers.Checked = !MI_HSManagers.Checked;
        }

        private void MI_HSPhotoList_Click(object sender, EventArgs e)
        {
            PhotoBrowser.ToggleHidePhotosList();
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
                // Disconnect
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

        private void MI_Account_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #endregion

        #region Settings

        private void Load_Settings()
        {
            // UNCOMMENT TO RESET FirstExecution
            //Properties.Settings.Default.Reset();

            DLG_BlackList.BlacklistedUsers = new List<int>();
            DLG_Slideshow.SlideShowList = new List<int>();
            if (Properties.Settings.Default.FirstExecution)
            {
                Properties.Settings.Default.Blacklist = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.SlideShowList = new System.Collections.Specialized.StringCollection();
            }
            else
            {
                LoadSlideShowList();
                LoadBlacklist();
            }
            this.Size = Properties.Settings.Default.DLG_MAINFORM_SIZE;
            this.Location = Properties.Settings.Default.DLG_MAINFORM_LOCATION;
        }

        private void Save_settings()
        {
            Properties.Settings.Default.DLG_MAINFORM_SIZE = this.Size;
            Properties.Settings.Default.DLG_MAINFORM_LOCATION = this.Location;
            Properties.Settings.Default.FirstExecution = false;
            SaveSlideShowList();
            SaveBlacklist();
            Properties.Settings.Default.Save();
        }
        private void LoadBlacklist()
        {
            if (Properties.Settings.Default.Blacklist != null)
            {
                foreach (var id in Properties.Settings.Default.Blacklist)
                {
                    DLG_BlackList.BlacklistedUsers.Add(int.Parse(id));
                }
            }
        }
        private void LoadSlideShowList()
        {
            if (Properties.Settings.Default.SlideShowList != null)
            {
                foreach (string stringPhotoId in Properties.Settings.Default.SlideShowList)
                {
                    int photoId = int.Parse(stringPhotoId);
                    DLG_Slideshow.SlideShowList.Add(photoId);
                }
            }
        }

        private void SaveBlacklist()
        {
            if (DLG_BlackList.BlacklistedUsers != null)
            {
                Properties.Settings.Default.Blacklist.Clear();
                foreach (var id in DLG_BlackList.BlacklistedUsers)
                {
                    Properties.Settings.Default.Blacklist.Add(id.ToString());
                }
            }
        }

        private void SaveSlideShowList()
        {
            if (DLG_Slideshow.SlideShowList != null)
            {
                Properties.Settings.Default.SlideShowList.Clear();
                foreach (int photoId in DLG_Slideshow.SlideShowList)
                {
                    Properties.Settings.Default.SlideShowList.Add(photoId.ToString());
                }
            }    
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_settings();
        }

        private void MI_Blacklist_Click(object sender, EventArgs e)
        {
            FBTN_Blacklist.PerformClick();
        }
    }
}
