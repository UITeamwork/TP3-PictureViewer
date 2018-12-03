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
        public static List<Image> UserThumbnails;

        // TODO : Load all photos of selected user that are not private

        public DLG_BlackList()
        {
            InitializeComponent();
        }

        private static void AddDroppedItemToListView(ListView lv, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                lv.Items.Add(item.Text, item.ImageIndex);
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

        private void DLG_BlackList_Load(object sender, EventArgs e)
        {
            // Initialize the users thumbnails
            if (UserThumbnails == null)
            {
                UserThumbnails = new List<Image>();
                foreach (var user in MainForm.AllUsers)
                {
                    if (user.GetAvatarThumbnailImage() != null)
                    {
                        UserThumbnails.Add(user.GetAvatarThumbnailImage());
                    }
                }
            }
            LV_AcceptedUsers.LargeImageList = new ImageList();
            LV_AcceptedUsers.LargeImageList.ImageSize = new Size(50, 50);
            LV_AcceptedUsers.LargeImageList.Images.AddRange(UserThumbnails.ToArray());
            LV_BlacklistedUsers.LargeImageList = new ImageList();
            LV_BlacklistedUsers.LargeImageList.Images.AddRange(UserThumbnails.ToArray());

            // Fill the listviews with the users
            int index = 0;
            foreach (var user in MainForm.AllUsers)
            {
                LV_AcceptedUsers.Items.Add(user.Name, index).SubItems.AddRange(new string[] { " ", " " });
                ++index;
            }
        }

        private void LV_AcceptedUsers_DragDrop(object sender, DragEventArgs e)
        {
            AddDroppedItemToListView(LV_AcceptedUsers, e);
        }

        private void LV_BlacklistedUsers_DragDrop(object sender, DragEventArgs e)
        {
            AddDroppedItemToListView(LV_BlacklistedUsers, e);
        }
    }
}
