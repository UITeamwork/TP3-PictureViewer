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
            this.CLBX_AllUsers = new System.Windows.Forms.CheckedListBox();
            this.BTN_SendToBlacklist = new System.Windows.Forms.Button();
            this.BTN_RemoveFromBlacklist = new System.Windows.Forms.Button();
            this.CLBX_BlacklistedUsers = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.FBTN_ResetBlacklist = new PhotoManagerClient.FlashButton();
            this.SuspendLayout();
            // 
            // CLBX_AllUsers
            // 
            this.CLBX_AllUsers.FormattingEnabled = true;
            this.CLBX_AllUsers.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc"});
            this.CLBX_AllUsers.Location = new System.Drawing.Point(13, 35);
            this.CLBX_AllUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CLBX_AllUsers.Name = "CLBX_AllUsers";
            this.CLBX_AllUsers.Size = new System.Drawing.Size(210, 251);
            this.CLBX_AllUsers.TabIndex = 0;
            // 
            // BTN_SendToBlacklist
            // 
            this.BTN_SendToBlacklist.Location = new System.Drawing.Point(243, 156);
            this.BTN_SendToBlacklist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_SendToBlacklist.Name = "BTN_SendToBlacklist";
            this.BTN_SendToBlacklist.Size = new System.Drawing.Size(39, 33);
            this.BTN_SendToBlacklist.TabIndex = 1;
            this.BTN_SendToBlacklist.Text = ">>";
            this.BTN_SendToBlacklist.UseVisualStyleBackColor = true;
            // 
            // BTN_RemoveFromBlacklist
            // 
            this.BTN_RemoveFromBlacklist.Location = new System.Drawing.Point(243, 82);
            this.BTN_RemoveFromBlacklist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_RemoveFromBlacklist.Name = "BTN_RemoveFromBlacklist";
            this.BTN_RemoveFromBlacklist.Size = new System.Drawing.Size(39, 33);
            this.BTN_RemoveFromBlacklist.TabIndex = 2;
            this.BTN_RemoveFromBlacklist.Text = "<<";
            this.BTN_RemoveFromBlacklist.UseVisualStyleBackColor = true;
            // 
            // CLBX_BlacklistedUsers
            // 
            this.CLBX_BlacklistedUsers.FormattingEnabled = true;
            this.CLBX_BlacklistedUsers.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ccc"});
            this.CLBX_BlacklistedUsers.Location = new System.Drawing.Point(307, 35);
            this.CLBX_BlacklistedUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CLBX_BlacklistedUsers.Name = "CLBX_BlacklistedUsers";
            this.CLBX_BlacklistedUsers.Size = new System.Drawing.Size(210, 251);
            this.CLBX_BlacklistedUsers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "All users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 13);
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
            this.BTN_Cancel.Location = new System.Drawing.Point(446, 303);
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
            this.BTN_OK.Location = new System.Drawing.Point(365, 303);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 25);
            this.BTN_OK.TabIndex = 7;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // FBTN_ResetBlacklist
            // 
            this.FBTN_ResetBlacklist.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Reset;
            this.FBTN_ResetBlacklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_ResetBlacklist.ClickedImage = null;
            this.FBTN_ResetBlacklist.DisabledImage = null;
            this.FBTN_ResetBlacklist.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_ResetBlacklist.Image")));
            this.FBTN_ResetBlacklist.Location = new System.Drawing.Point(243, 250);
            this.FBTN_ResetBlacklist.Name = "FBTN_ResetBlacklist";
            this.FBTN_ResetBlacklist.NeutralImage = null;
            this.FBTN_ResetBlacklist.OverImage = null;
            this.FBTN_ResetBlacklist.Size = new System.Drawing.Size(39, 36);
            this.FBTN_ResetBlacklist.TabIndex = 8;
            this.FBTN_ResetBlacklist.Text = "flashButton1";
            this.FBTN_ResetBlacklist.UseVisualStyleBackColor = true;
            this.FBTN_ResetBlacklist.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // DLG_BlackList
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(533, 338);
            this.Controls.Add(this.FBTN_ResetBlacklist);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLBX_BlacklistedUsers);
            this.Controls.Add(this.BTN_RemoveFromBlacklist);
            this.Controls.Add(this.BTN_SendToBlacklist);
            this.Controls.Add(this.CLBX_AllUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DLG_BlackList";
            this.Text = "DLG_BlackList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CLBX_AllUsers;
        private System.Windows.Forms.Button BTN_SendToBlacklist;
        private System.Windows.Forms.Button BTN_RemoveFromBlacklist;
        private System.Windows.Forms.CheckedListBox CLBX_BlacklistedUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_OK;
        private PhotoManagerClient.FlashButton FBTN_ResetBlacklist;
    }
}