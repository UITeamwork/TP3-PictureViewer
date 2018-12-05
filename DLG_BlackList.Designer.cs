namespace Client_PM
{
    partial class DLG_BlackList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLG_BlackList));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.LV_AcceptedUsers = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_BlacklistedUsers = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.ImgL_SelectedUserImages = new PhotoManagerClient.ImagesLayout();
            this.FBTN_ResetBlacklist = new PhotoManagerClient.FlashButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Accepted users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Blacklisted users";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(695, 599);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 25);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(614, 599);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 25);
            this.BTN_OK.TabIndex = 7;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // LV_AcceptedUsers
            // 
            this.LV_AcceptedUsers.AllowDrop = true;
            this.LV_AcceptedUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.LV_AcceptedUsers.FullRowSelect = true;
            this.LV_AcceptedUsers.Location = new System.Drawing.Point(16, 34);
            this.LV_AcceptedUsers.MultiSelect = false;
            this.LV_AcceptedUsers.Name = "LV_AcceptedUsers";
            this.LV_AcceptedUsers.Size = new System.Drawing.Size(371, 402);
            this.LV_AcceptedUsers.TabIndex = 9;
            this.LV_AcceptedUsers.TileSize = new System.Drawing.Size(268, 60);
            this.LV_AcceptedUsers.UseCompatibleStateImageBehavior = false;
            this.LV_AcceptedUsers.View = System.Windows.Forms.View.Tile;
            this.LV_AcceptedUsers.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LV_AcceptedUsers_ItemDrag);
            this.LV_AcceptedUsers.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_AcceptedUsers_DragDrop);
            this.LV_AcceptedUsers.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_AcceptedUsers_DragEnter);
            this.LV_AcceptedUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_AcceptedUsers_MouseDoubleClick);
            // 
            // LV_BlacklistedUsers
            // 
            this.LV_BlacklistedUsers.AllowDrop = true;
            this.LV_BlacklistedUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LV_BlacklistedUsers.FullRowSelect = true;
            this.LV_BlacklistedUsers.Location = new System.Drawing.Point(393, 34);
            this.LV_BlacklistedUsers.MultiSelect = false;
            this.LV_BlacklistedUsers.Name = "LV_BlacklistedUsers";
            this.LV_BlacklistedUsers.Size = new System.Drawing.Size(371, 402);
            this.LV_BlacklistedUsers.TabIndex = 10;
            this.LV_BlacklistedUsers.TileSize = new System.Drawing.Size(268, 60);
            this.LV_BlacklistedUsers.UseCompatibleStateImageBehavior = false;
            this.LV_BlacklistedUsers.View = System.Windows.Forms.View.Tile;
            this.LV_BlacklistedUsers.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LV_BlacklistedUsers_ItemDrag);
            this.LV_BlacklistedUsers.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_BlacklistedUsers_DragDrop);
            this.LV_BlacklistedUsers.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_BlacklistedUsers_DragEnter);
            this.LV_BlacklistedUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_BlacklistedUsers_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Double click a user to display his photos";
            // 
            // ImgL_SelectedUserImages
            // 
            this.ImgL_SelectedUserImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgL_SelectedUserImages.AutoScroll = true;
            this.ImgL_SelectedUserImages.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImgL_SelectedUserImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgL_SelectedUserImages.IgnoreMouseInteractions = true;
            this.ImgL_SelectedUserImages.Location = new System.Drawing.Point(16, 486);
            this.ImgL_SelectedUserImages.Name = "ImgL_SelectedUserImages";
            this.ImgL_SelectedUserImages.SelectedPhotoBox = null;
            this.ImgL_SelectedUserImages.Size = new System.Drawing.Size(748, 107);
            this.ImgL_SelectedUserImages.TabIndex = 11;
            this.ImgL_SelectedUserImages.WrapContents = false;
            // 
            // FBTN_ResetBlacklist
            // 
            this.FBTN_ResetBlacklist.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Recycle_Neutral;
            this.FBTN_ResetBlacklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_ResetBlacklist.ClickedImage = global::Client_PM.Properties.Resources.IMG_Recycle_Clicked;
            this.FBTN_ResetBlacklist.DisabledImage = global::Client_PM.Properties.Resources.IMG_Recycle_Disabled;
            this.FBTN_ResetBlacklist.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_ResetBlacklist.Image")));
            this.FBTN_ResetBlacklist.Location = new System.Drawing.Point(749, 2);
            this.FBTN_ResetBlacklist.Name = "FBTN_ResetBlacklist";
            this.FBTN_ResetBlacklist.NeutralImage = global::Client_PM.Properties.Resources.IMG_Recycle_Neutral;
            this.FBTN_ResetBlacklist.OverImage = global::Client_PM.Properties.Resources.IMG_Recycle_Over;
            this.FBTN_ResetBlacklist.Size = new System.Drawing.Size(30, 30);
            this.FBTN_ResetBlacklist.TabIndex = 0;
            this.FBTN_ResetBlacklist.Text = "Reset the blacklist";
            this.FBTN_ResetBlacklist.UseVisualStyleBackColor = true;
            this.FBTN_ResetBlacklist.Click += new System.EventHandler(this.FBTN_ResetBlacklist_Click);
            // 
            // DLG_BlackList
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(782, 634);
            this.Controls.Add(this.FBTN_ResetBlacklist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImgL_SelectedUserImages);
            this.Controls.Add(this.LV_BlacklistedUsers);
            this.Controls.Add(this.LV_AcceptedUsers);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DLG_BlackList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLG_BlackList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_BlackList_FormClosing);
            this.Load += new System.EventHandler(this.DLG_BlackList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DLG_BlackList_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.ListView LV_AcceptedUsers;
        private System.Windows.Forms.ListView LV_BlacklistedUsers;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private PhotoManagerClient.ImagesLayout ImgL_SelectedUserImages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private PhotoManagerClient.FlashButton FBTN_ResetBlacklist;
    }
}