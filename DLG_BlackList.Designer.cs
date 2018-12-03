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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "A Very Long User Name",
            "asdf",
            "adsf"}, 1);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.LV_AcceptedUsers = new System.Windows.Forms.ListView();
            this.LV_BlacklistedUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_SelectedUserImages = new System.Windows.Forms.ListView();
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
            this.BTN_Cancel.Location = new System.Drawing.Point(695, 571);
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
            this.BTN_OK.Location = new System.Drawing.Point(614, 571);
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
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LV_AcceptedUsers.FullRowSelect = true;
            this.LV_AcceptedUsers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.LV_AcceptedUsers.Location = new System.Drawing.Point(16, 34);
            this.LV_AcceptedUsers.Name = "LV_AcceptedUsers";
            this.LV_AcceptedUsers.Size = new System.Drawing.Size(371, 402);
            this.LV_AcceptedUsers.TabIndex = 9;
            this.LV_AcceptedUsers.TileSize = new System.Drawing.Size(268, 60);
            this.LV_AcceptedUsers.UseCompatibleStateImageBehavior = false;
            this.LV_AcceptedUsers.View = System.Windows.Forms.View.Tile;
            this.LV_AcceptedUsers.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LV_AcceptedUsers_ItemDrag);
            this.LV_AcceptedUsers.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_AcceptedUsers_DragDrop);
            this.LV_AcceptedUsers.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_AcceptedUsers_DragEnter);
            // 
            // LV_BlacklistedUsers
            // 
            this.LV_BlacklistedUsers.AllowDrop = true;
            this.LV_BlacklistedUsers.Location = new System.Drawing.Point(393, 34);
            this.LV_BlacklistedUsers.Name = "LV_BlacklistedUsers";
            this.LV_BlacklistedUsers.Size = new System.Drawing.Size(371, 402);
            this.LV_BlacklistedUsers.TabIndex = 10;
            this.LV_BlacklistedUsers.UseCompatibleStateImageBehavior = false;
            this.LV_BlacklistedUsers.View = System.Windows.Forms.View.Tile;
            this.LV_BlacklistedUsers.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LV_BlacklistedUsers_ItemDrag);
            this.LV_BlacklistedUsers.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_BlacklistedUsers_DragDrop);
            this.LV_BlacklistedUsers.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_BlacklistedUsers_DragEnter);
            // 
            // LV_SelectedUserImages
            // 
            this.LV_SelectedUserImages.Location = new System.Drawing.Point(16, 440);
            this.LV_SelectedUserImages.Name = "LV_SelectedUserImages";
            this.LV_SelectedUserImages.Size = new System.Drawing.Size(748, 118);
            this.LV_SelectedUserImages.TabIndex = 11;
            this.LV_SelectedUserImages.UseCompatibleStateImageBehavior = false;
            // 
            // DLG_BlackList
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(782, 606);
            this.Controls.Add(this.LV_SelectedUserImages);
            this.Controls.Add(this.LV_BlacklistedUsers);
            this.Controls.Add(this.LV_AcceptedUsers);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DLG_BlackList";
            this.Text = "DLG_BlackList";
            this.Load += new System.EventHandler(this.DLG_BlackList_Load);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView LV_SelectedUserImages;
    }
}