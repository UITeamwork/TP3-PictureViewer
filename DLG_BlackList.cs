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
    public partial class DLG_BlackList : Form
    {
        // userId, avatarThumbnail
        public static Dictionary<int, Image> UserThumbnails;
        public static List<int> BlacklistedUsers = new List<int>();

        public DLG_BlackList()
        {
            InitializeComponent();
            BlacklistedUsers.Add(1);
        }

        private void DLG_BlackList_Load(object sender, EventArgs e)
        {
            InitUserThumbnails();
            InitListViewsImages();

            var blackListedUsers = MainForm.AllUsers.Where(u => BlacklistedUsers.Contains(u.Id)).ToList();
            PopulateListView(LV_BlacklistedUsers, blackListedUsers);
            var acceptedUser = MainForm.AllUsers.Where(u => !BlacklistedUsers.Contains(u.Id)).ToList();
            PopulateListView(LV_AcceptedUsers, acceptedUser);
        }

        private void PopulateListView(ListView toInit, List<User> population)
        {
            foreach (var user in population)
            {
                toInit.Items.Add(" ", user.Id.ToString()).SubItems.AddRange(new string[] { user.Name, " ", user.Id.ToString() });
                toInit.Items[toInit.Items.Count - 1].UseItemStyleForSubItems = false;
            }
        }

        private void AddUserToListView(ListView lv, User toAdd)
        {
            lv.Items.Add(" ", toAdd.Id.ToString()).SubItems.AddRange(new string[] { toAdd.Name, " ", toAdd.Id.ToString() });
            lv.Items[lv.Items.Count - 1].UseItemStyleForSubItems = false;
        }
        private void AddUserToListView(ListView lv, ListViewItem toAdd)
        {
            lv.Items.Add(" ", toAdd.SubItems[3].Text).SubItems.AddRange(new string[] { toAdd.SubItems[1].Text, " ", toAdd.SubItems[3].Text });
            lv.Items[lv.Items.Count - 1].UseItemStyleForSubItems = false;
        }

        private void InitListViewsImages()
        {
            LV_AcceptedUsers.LargeImageList = new ImageList { ImageSize = new Size(50, 50) };
            LV_BlacklistedUsers.LargeImageList = new ImageList { ImageSize = new Size(50, 50) };

            foreach (var keyValuePair in UserThumbnails)
            {
                LV_AcceptedUsers.LargeImageList.Images.Add(keyValuePair.Key.ToString(), keyValuePair.Value);
                LV_BlacklistedUsers.LargeImageList.Images.Add(keyValuePair.Key.ToString(), keyValuePair.Value);
            }
        }

        private void InitUserThumbnails()
        {
            if (UserThumbnails == null)
            {
                UserThumbnails = new Dictionary<int, Image>();
                foreach (var user in MainForm.AllUsers)
                {
                    if (user.GetAvatarThumbnailImage() != null)
                    {
                        UserThumbnails.Add(user.Id, user.GetAvatarThumbnailImage());
                    }
                }
            }
        }

        private void DisplayPhotosOfSelectedUser(ListView lv)
        {
            if (lv.SelectedItems != null && lv.SelectedItems.Count == 1)
            {
                ImgL_SelectedUserImages.Clear();
                var userPhotos = MainForm.photos.Where(p => p.OwnerId.ToString() == lv.SelectedItems[0].SubItems[3].Text).ToList();
                foreach (var photo in userPhotos)
                {
                    ImgL_SelectedUserImages.AddPhoto(photo);
                }
            }
        }

        private void AddDroppedItemToListView(ListView lv, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                AddUserToListView(lv, item);
            }
        }

        private void RemoveDroppedItemFromListView(ListView lv, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                if (lv.Items.Contains(item))
                {
                    lv.Items.Remove(item);
                }
            }
        }
        private void RemoveDroppedItemFromListView(ListView lv, ListViewItem item)
        {
            if (lv.Items.Contains(item))
            {
                lv.Items.Remove(item);
            }
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete all users from your blacklist?\nThis action is permanent.", "Confirm reset", MessageBoxButtons.YesNo);
        }

        private void LV_AcceptedUsers_ItemDrag(object sender, ItemDragEventArgs e)
        {
            LV_AcceptedUsers.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void LV_AcceptedUsers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void LV_BlacklistedUsers_ItemDrag(object sender, ItemDragEventArgs e)
        {
            LV_BlacklistedUsers.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void LV_BlacklistedUsers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void LV_AcceptedUsers_DragDrop(object sender, DragEventArgs e)
        {
            RemoveDroppedItemFromListView(LV_AcceptedUsers, e);
            RemoveDroppedItemFromListView(LV_BlacklistedUsers, e);
            AddDroppedItemToListView(LV_AcceptedUsers, e);
        }

        private void LV_BlacklistedUsers_DragDrop(object sender, DragEventArgs e)
        {
            RemoveDroppedItemFromListView(LV_AcceptedUsers, e);
            RemoveDroppedItemFromListView(LV_BlacklistedUsers, e);
            AddDroppedItemToListView(LV_BlacklistedUsers, e);
        }

        private void LV_AcceptedUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisplayPhotosOfSelectedUser(LV_AcceptedUsers);
        }

        private void LV_BlacklistedUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DisplayPhotosOfSelectedUser(LV_BlacklistedUsers);
        }

        private void DLG_BlackList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Right:
                    if (LV_AcceptedUsers.SelectedItems != null && LV_AcceptedUsers.SelectedItems.Count == 1)
                    {
                        AddUserToListView(LV_BlacklistedUsers, LV_AcceptedUsers.SelectedItems[0]);
                        RemoveDroppedItemFromListView(LV_AcceptedUsers, LV_AcceptedUsers.SelectedItems[0]);
                    }
                    break;
                case Keys.Left:
                    if (LV_BlacklistedUsers.SelectedItems != null && LV_BlacklistedUsers.SelectedItems.Count == 1)
                    {
                        AddUserToListView(LV_AcceptedUsers, LV_BlacklistedUsers.SelectedItems[0]);
                        RemoveDroppedItemFromListView(LV_BlacklistedUsers, LV_BlacklistedUsers.SelectedItems[0]);
                    }
                    break;
            }
        }
    }
}
