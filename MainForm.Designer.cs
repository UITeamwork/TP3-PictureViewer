namespace Client_PM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBX_UsersList = new System.Windows.Forms.ComboBox();
            this.MS_Account = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Profil = new System.Windows.Forms.ToolStripMenuItem();
            this.Mi_Account_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.blacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBX_Keywords = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PhotoBrowser = new PhotoManagerClient.PhotosBrowser();
            this.DTP_From = new System.Windows.Forms.DateTimePicker();
            this.DTP_To = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.FBTN_Help = new PhotoManagerClient.FlashButton();
            this.FBTN_Slideshow = new PhotoManagerClient.FlashButton();
            this.FBTN_Blacklist = new PhotoManagerClient.FlashButton();
            this.flashButton1 = new PhotoManagerClient.FlashButton();
            this.FBTN_PictureSlideshow = new PhotoManagerClient.FlashButton();
            this.FBTN_ViewPictureInfo = new PhotoManagerClient.FlashButton();
            this.FBTN_DeletePicture = new PhotoManagerClient.FlashButton();
            this.FBTN_EditPicture = new PhotoManagerClient.FlashButton();
            this.FBTN_NewPicture = new PhotoManagerClient.FlashButton();
            this.groupBox1.SuspendLayout();
            this.MS_Account.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.CBX_UsersList);
            this.groupBox1.Location = new System.Drawing.Point(245, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // CBX_UsersList
            // 
            this.CBX_UsersList.FormattingEnabled = true;
            this.CBX_UsersList.Location = new System.Drawing.Point(6, 56);
            this.CBX_UsersList.Name = "CBX_UsersList";
            this.CBX_UsersList.Size = new System.Drawing.Size(215, 28);
            this.CBX_UsersList.TabIndex = 0;
            this.CBX_UsersList.SelectedIndexChanged += new System.EventHandler(this.CBX_UsersList_SelectedIndexChanged);
            // 
            // MS_Account
            // 
            this.MS_Account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.layoutToolStripMenuItem});
            this.MS_Account.Location = new System.Drawing.Point(0, 0);
            this.MS_Account.Name = "MS_Account";
            this.MS_Account.Size = new System.Drawing.Size(1153, 24);
            this.MS_Account.TabIndex = 2;
            this.MS_Account.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Account_Login,
            this.MI_Account_Profil,
            this.Mi_Account_Create,
            this.blacklistToolStripMenuItem,
            this.MI_Account_Exit});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // MI_Account_Login
            // 
            this.MI_Account_Login.Name = "MI_Account_Login";
            this.MI_Account_Login.Size = new System.Drawing.Size(117, 22);
            this.MI_Account_Login.Text = "Login";
            this.MI_Account_Login.Click += new System.EventHandler(this.MI_Account_Login_Click);
            // 
            // MI_Account_Profil
            // 
            this.MI_Account_Profil.Name = "MI_Account_Profil";
            this.MI_Account_Profil.Size = new System.Drawing.Size(117, 22);
            this.MI_Account_Profil.Text = "Profil";
            this.MI_Account_Profil.Click += new System.EventHandler(this.MI_Account_Profil_Click);
            // 
            // Mi_Account_Create
            // 
            this.Mi_Account_Create.Name = "Mi_Account_Create";
            this.Mi_Account_Create.Size = new System.Drawing.Size(117, 22);
            this.Mi_Account_Create.Text = "Create";
            this.Mi_Account_Create.Click += new System.EventHandler(this.Mi_Account_Create_Click);
            // 
            // blacklistToolStripMenuItem
            // 
            this.blacklistToolStripMenuItem.Name = "blacklistToolStripMenuItem";
            this.blacklistToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.blacklistToolStripMenuItem.Text = "Blacklist";
            // 
            // MI_Account_Exit
            // 
            this.MI_Account_Exit.Name = "MI_Account_Exit";
            this.MI_Account_Exit.Size = new System.Drawing.Size(117, 22);
            this.MI_Account_Exit.Text = "Exit";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem,
            this.topToolStripMenuItem,
            this.bottomToolStripMenuItem});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.BTN_Left_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.BTN_Right_Click);
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.topToolStripMenuItem.Text = "Top";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.BTN_Top_Click);
            // 
            // bottomToolStripMenuItem
            // 
            this.bottomToolStripMenuItem.Name = "bottomToolStripMenuItem";
            this.bottomToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.bottomToolStripMenuItem.Text = "Bottom";
            this.bottomToolStripMenuItem.Click += new System.EventHandler(this.BTN_Bottom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flashButton1);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.CBX_Keywords);
            this.groupBox2.Location = new System.Drawing.Point(478, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keyword";
            // 
            // CBX_Keywords
            // 
            this.CBX_Keywords.FormattingEnabled = true;
            this.CBX_Keywords.Location = new System.Drawing.Point(7, 58);
            this.CBX_Keywords.Name = "CBX_Keywords";
            this.CBX_Keywords.Size = new System.Drawing.Size(155, 28);
            this.CBX_Keywords.TabIndex = 0;
            this.CBX_Keywords.SelectedIndexChanged += new System.EventHandler(this.CBX_Keywords_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FBTN_PictureSlideshow);
            this.groupBox4.Controls.Add(this.FBTN_ViewPictureInfo);
            this.groupBox4.Controls.Add(this.FBTN_DeletePicture);
            this.groupBox4.Controls.Add(this.FBTN_EditPicture);
            this.groupBox4.Controls.Add(this.FBTN_NewPicture);
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 94);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Commands";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.DTP_To);
            this.groupBox5.Controls.Add(this.DTP_From);
            this.groupBox5.Location = new System.Drawing.Point(654, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(271, 94);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date interval";
            // 
            // PhotoBrowser
            // 
            this.PhotoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBrowser.Location = new System.Drawing.Point(12, 127);
            this.PhotoBrowser.Name = "PhotoBrowser";
            this.PhotoBrowser.Placement = PhotoManagerClient.PhotoBrowserPlacement.Left;
            this.PhotoBrowser.SelectedPhoto = null;
            this.PhotoBrowser.Size = new System.Drawing.Size(1129, 535);
            this.PhotoBrowser.TabIndex = 0;
            // 
            // DTP_From
            // 
            this.DTP_From.Location = new System.Drawing.Point(101, 24);
            this.DTP_From.Name = "DTP_From";
            this.DTP_From.Size = new System.Drawing.Size(162, 26);
            this.DTP_From.TabIndex = 6;
            // 
            // DTP_To
            // 
            this.DTP_To.Location = new System.Drawing.Point(101, 56);
            this.DTP_To.Name = "DTP_To";
            this.DTP_To.Size = new System.Drawing.Size(162, 26);
            this.DTP_To.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 25);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(200, 25);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Exclude my photos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 24);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 25);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // FBTN_Help
            // 
            this.FBTN_Help.BackgroundImage = global::Client_PM.Properties.Resources.Help_icon;
            this.FBTN_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Help.ClickedImage = null;
            this.FBTN_Help.DisabledImage = null;
            this.FBTN_Help.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Help.Image")));
            this.FBTN_Help.Location = new System.Drawing.Point(1129, 0);
            this.FBTN_Help.Name = "FBTN_Help";
            this.FBTN_Help.NeutralImage = null;
            this.FBTN_Help.OverImage = null;
            this.FBTN_Help.Size = new System.Drawing.Size(24, 24);
            this.FBTN_Help.TabIndex = 5;
            this.FBTN_Help.Text = "Play the slideshow...";
            this.FBTN_Help.UseVisualStyleBackColor = true;
            // 
            // FBTN_Slideshow
            // 
            this.FBTN_Slideshow.BackgroundImage = global::Client_PM.Properties.Resources.play;
            this.FBTN_Slideshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Slideshow.ClickedImage = null;
            this.FBTN_Slideshow.DisabledImage = null;
            this.FBTN_Slideshow.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Slideshow.Image")));
            this.FBTN_Slideshow.Location = new System.Drawing.Point(1058, 52);
            this.FBTN_Slideshow.Name = "FBTN_Slideshow";
            this.FBTN_Slideshow.NeutralImage = null;
            this.FBTN_Slideshow.OverImage = null;
            this.FBTN_Slideshow.Size = new System.Drawing.Size(49, 49);
            this.FBTN_Slideshow.TabIndex = 4;
            this.FBTN_Slideshow.Text = "Play the slideshow...";
            this.FBTN_Slideshow.UseVisualStyleBackColor = true;
            this.FBTN_Slideshow.Click += new System.EventHandler(this.FBTN_Slideshow_Click);
            // 
            // FBTN_Blacklist
            // 
            this.FBTN_Blacklist.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Blacklist;
            this.FBTN_Blacklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Blacklist.ClickedImage = null;
            this.FBTN_Blacklist.DisabledImage = null;
            this.FBTN_Blacklist.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Blacklist.Image")));
            this.FBTN_Blacklist.Location = new System.Drawing.Point(971, 52);
            this.FBTN_Blacklist.Name = "FBTN_Blacklist";
            this.FBTN_Blacklist.NeutralImage = null;
            this.FBTN_Blacklist.OverImage = null;
            this.FBTN_Blacklist.Size = new System.Drawing.Size(49, 49);
            this.FBTN_Blacklist.TabIndex = 3;
            this.FBTN_Blacklist.Text = "Open the user blacklist...";
            this.FBTN_Blacklist.UseVisualStyleBackColor = true;
            this.FBTN_Blacklist.Click += new System.EventHandler(this.FBTN_Blacklist_Click);
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::Client_PM.Properties.Resources.search;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashButton1.ClickedImage = null;
            this.flashButton1.DisabledImage = null;
            this.flashButton1.Image = ((System.Drawing.Image)(resources.GetObject("flashButton1.Image")));
            this.flashButton1.Location = new System.Drawing.Point(132, 21);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.NeutralImage = null;
            this.flashButton1.OverImage = null;
            this.flashButton1.Size = new System.Drawing.Size(30, 30);
            this.flashButton1.TabIndex = 9;
            this.flashButton1.Text = "Add/Remove picture to/from slideshow";
            this.flashButton1.UseVisualStyleBackColor = true;
            // 
            // FBTN_PictureSlideshow
            // 
            this.FBTN_PictureSlideshow.BackgroundImage = global::Client_PM.Properties.Resources.add;
            this.FBTN_PictureSlideshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_PictureSlideshow.ClickedImage = null;
            this.FBTN_PictureSlideshow.DisabledImage = null;
            this.FBTN_PictureSlideshow.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_PictureSlideshow.Image")));
            this.FBTN_PictureSlideshow.Location = new System.Drawing.Point(178, 35);
            this.FBTN_PictureSlideshow.Name = "FBTN_PictureSlideshow";
            this.FBTN_PictureSlideshow.NeutralImage = null;
            this.FBTN_PictureSlideshow.OverImage = null;
            this.FBTN_PictureSlideshow.Size = new System.Drawing.Size(30, 30);
            this.FBTN_PictureSlideshow.TabIndex = 8;
            this.FBTN_PictureSlideshow.Text = "Add/Remove picture to/from slideshow";
            this.FBTN_PictureSlideshow.UseVisualStyleBackColor = true;
            // 
            // FBTN_ViewPictureInfo
            // 
            this.FBTN_ViewPictureInfo.BackgroundImage = global::Client_PM.Properties.Resources.view;
            this.FBTN_ViewPictureInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_ViewPictureInfo.ClickedImage = null;
            this.FBTN_ViewPictureInfo.DisabledImage = null;
            this.FBTN_ViewPictureInfo.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_ViewPictureInfo.Image")));
            this.FBTN_ViewPictureInfo.Location = new System.Drawing.Point(138, 35);
            this.FBTN_ViewPictureInfo.Name = "FBTN_ViewPictureInfo";
            this.FBTN_ViewPictureInfo.NeutralImage = null;
            this.FBTN_ViewPictureInfo.OverImage = null;
            this.FBTN_ViewPictureInfo.Size = new System.Drawing.Size(30, 30);
            this.FBTN_ViewPictureInfo.TabIndex = 7;
            this.FBTN_ViewPictureInfo.Text = "View picture info...";
            this.FBTN_ViewPictureInfo.UseVisualStyleBackColor = true;
            // 
            // FBTN_DeletePicture
            // 
            this.FBTN_DeletePicture.BackgroundImage = global::Client_PM.Properties.Resources.delete;
            this.FBTN_DeletePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_DeletePicture.ClickedImage = null;
            this.FBTN_DeletePicture.DisabledImage = null;
            this.FBTN_DeletePicture.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_DeletePicture.Image")));
            this.FBTN_DeletePicture.Location = new System.Drawing.Point(98, 35);
            this.FBTN_DeletePicture.Name = "FBTN_DeletePicture";
            this.FBTN_DeletePicture.NeutralImage = null;
            this.FBTN_DeletePicture.OverImage = null;
            this.FBTN_DeletePicture.Size = new System.Drawing.Size(30, 30);
            this.FBTN_DeletePicture.TabIndex = 6;
            this.FBTN_DeletePicture.Text = "Remove the picture";
            this.FBTN_DeletePicture.UseVisualStyleBackColor = true;
            // 
            // FBTN_EditPicture
            // 
            this.FBTN_EditPicture.BackgroundImage = global::Client_PM.Properties.Resources.edit;
            this.FBTN_EditPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_EditPicture.ClickedImage = null;
            this.FBTN_EditPicture.DisabledImage = null;
            this.FBTN_EditPicture.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_EditPicture.Image")));
            this.FBTN_EditPicture.Location = new System.Drawing.Point(60, 35);
            this.FBTN_EditPicture.Name = "FBTN_EditPicture";
            this.FBTN_EditPicture.NeutralImage = null;
            this.FBTN_EditPicture.OverImage = null;
            this.FBTN_EditPicture.Size = new System.Drawing.Size(30, 30);
            this.FBTN_EditPicture.TabIndex = 5;
            this.FBTN_EditPicture.Text = "Edit picture...";
            this.FBTN_EditPicture.UseVisualStyleBackColor = true;
            // 
            // FBTN_NewPicture
            // 
            this.FBTN_NewPicture.BackgroundImage = global::Client_PM.Properties.Resources.upload;
            this.FBTN_NewPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_NewPicture.ClickedImage = null;
            this.FBTN_NewPicture.DisabledImage = null;
            this.FBTN_NewPicture.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_NewPicture.Image")));
            this.FBTN_NewPicture.Location = new System.Drawing.Point(20, 35);
            this.FBTN_NewPicture.Name = "FBTN_NewPicture";
            this.FBTN_NewPicture.NeutralImage = null;
            this.FBTN_NewPicture.OverImage = null;
            this.FBTN_NewPicture.Size = new System.Drawing.Size(30, 30);
            this.FBTN_NewPicture.TabIndex = 4;
            this.FBTN_NewPicture.Text = "Upload a picture...";
            this.FBTN_NewPicture.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 674);
            this.Controls.Add(this.FBTN_Help);
            this.Controls.Add(this.FBTN_Slideshow);
            this.Controls.Add(this.FBTN_Blacklist);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PhotoBrowser);
            this.Controls.Add(this.MS_Account);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MS_Account;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1169, 713);
            this.Name = "MainForm";
            this.Text = "Photo manager client application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MS_Account.ResumeLayout(false);
            this.MS_Account.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotoManagerClient.PhotosBrowser PhotoBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip MS_Account;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Login;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Profil;
        private System.Windows.Forms.ToolStripMenuItem Mi_Account_Create;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Exit;
        private System.Windows.Forms.ComboBox CBX_UsersList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBX_Keywords;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem blacklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private PhotoManagerClient.FlashButton FBTN_Blacklist;
        private PhotoManagerClient.FlashButton FBTN_PictureSlideshow;
        private PhotoManagerClient.FlashButton FBTN_ViewPictureInfo;
        private PhotoManagerClient.FlashButton FBTN_DeletePicture;
        private PhotoManagerClient.FlashButton FBTN_EditPicture;
        private PhotoManagerClient.FlashButton FBTN_NewPicture;
        private PhotoManagerClient.FlashButton FBTN_Slideshow;
        private PhotoManagerClient.FlashButton FBTN_Help;
        private System.Windows.Forms.DateTimePicker DTP_To;
        private System.Windows.Forms.DateTimePicker DTP_From;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private PhotoManagerClient.FlashButton flashButton1;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

