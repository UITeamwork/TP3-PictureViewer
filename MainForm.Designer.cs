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
            this.GBX_Users = new System.Windows.Forms.GroupBox();
            this.CBX_ExcludeMine = new System.Windows.Forms.CheckBox();
            this.CBX_UsersList = new System.Windows.Forms.ComboBox();
            this.MS_Account = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Profil = new System.Windows.Forms.ToolStripMenuItem();
            this.Mi_Account_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Blacklist = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_BrowserDispo = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Left = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Right = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Top = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Bottom = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_HideGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_HideAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_ShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MI_HSCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_HSUserFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_HSKeywordFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_HSDateFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_HSManagers = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_HSPhotoList = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.displayHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.GBX_Keyword = new System.Windows.Forms.GroupBox();
            this.CBX_KeywordFilter = new System.Windows.Forms.CheckBox();
            this.CBX_Keywords = new System.Windows.Forms.ComboBox();
            this.GBX_Commands = new System.Windows.Forms.GroupBox();
            this.FBTN_PhotoToSlideshow = new PhotoManagerClient.FlashButton();
            this.FBTN_ViewPictureInfo = new PhotoManagerClient.FlashButton();
            this.FBTN_DeletePicture = new PhotoManagerClient.FlashButton();
            this.FBTN_EditPicture = new PhotoManagerClient.FlashButton();
            this.FBTN_NewPicture = new PhotoManagerClient.FlashButton();
            this.GBX_Date = new System.Windows.Forms.GroupBox();
            this.CBX_DateFilter = new System.Windows.Forms.CheckBox();
            this.DTP_To = new System.Windows.Forms.DateTimePicker();
            this.DTP_From = new System.Windows.Forms.DateTimePicker();
            this.GBX_Managers = new System.Windows.Forms.GroupBox();
            this.FBTN_Blacklist = new PhotoManagerClient.FlashButton();
            this.FBTN_Slideshow = new PhotoManagerClient.FlashButton();
            this.FLP_Groups = new System.Windows.Forms.FlowLayoutPanel();
            this.PhotoBrowser = new PhotoManagerClient.PhotosBrowser();
            this.GBX_Users.SuspendLayout();
            this.MS_Account.SuspendLayout();
            this.GBX_Keyword.SuspendLayout();
            this.GBX_Commands.SuspendLayout();
            this.GBX_Date.SuspendLayout();
            this.GBX_Managers.SuspendLayout();
            this.FLP_Groups.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBX_Users
            // 
            this.GBX_Users.Controls.Add(this.CBX_ExcludeMine);
            this.GBX_Users.Controls.Add(this.CBX_UsersList);
            this.GBX_Users.Location = new System.Drawing.Point(307, 3);
            this.GBX_Users.Name = "GBX_Users";
            this.GBX_Users.Size = new System.Drawing.Size(177, 94);
            this.GBX_Users.TabIndex = 1;
            this.GBX_Users.TabStop = false;
            this.GBX_Users.Text = "Users";
            // 
            // CBX_ExcludeMine
            // 
            this.CBX_ExcludeMine.AutoSize = true;
            this.CBX_ExcludeMine.Location = new System.Drawing.Point(6, 19);
            this.CBX_ExcludeMine.Name = "CBX_ExcludeMine";
            this.CBX_ExcludeMine.Size = new System.Drawing.Size(161, 24);
            this.CBX_ExcludeMine.TabIndex = 9;
            this.CBX_ExcludeMine.Text = "Exclude my photos";
            this.CBX_ExcludeMine.UseVisualStyleBackColor = true;
            this.CBX_ExcludeMine.CheckedChanged += new System.EventHandler(this.CBX_ExcludeMine_CheckedChanged);
            // 
            // CBX_UsersList
            // 
            this.CBX_UsersList.FormattingEnabled = true;
            this.CBX_UsersList.Location = new System.Drawing.Point(6, 56);
            this.CBX_UsersList.Name = "CBX_UsersList";
            this.CBX_UsersList.Size = new System.Drawing.Size(165, 28);
            this.CBX_UsersList.TabIndex = 0;
            this.CBX_UsersList.SelectedIndexChanged += new System.EventHandler(this.CBX_UsersList_SelectedIndexChanged);
            // 
            // MS_Account
            // 
            this.MS_Account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.layoutToolStripMenuItem,
            this.MI_Help});
            this.MS_Account.Location = new System.Drawing.Point(0, 0);
            this.MS_Account.Name = "MS_Account";
            this.MS_Account.Size = new System.Drawing.Size(1042, 24);
            this.MS_Account.TabIndex = 2;
            this.MS_Account.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Account_Login,
            this.MI_Account_Profil,
            this.Mi_Account_Create,
            this.MI_Blacklist,
            this.MI_Account_Exit});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // MI_Account_Login
            // 
            this.MI_Account_Login.Name = "MI_Account_Login";
            this.MI_Account_Login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.MI_Account_Login.Size = new System.Drawing.Size(154, 22);
            this.MI_Account_Login.Text = "Login";
            this.MI_Account_Login.Click += new System.EventHandler(this.MI_Account_Login_Click);
            // 
            // MI_Account_Profil
            // 
            this.MI_Account_Profil.Name = "MI_Account_Profil";
            this.MI_Account_Profil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.MI_Account_Profil.Size = new System.Drawing.Size(154, 22);
            this.MI_Account_Profil.Text = "Profil";
            this.MI_Account_Profil.Click += new System.EventHandler(this.MI_Account_Profil_Click);
            // 
            // Mi_Account_Create
            // 
            this.Mi_Account_Create.Name = "Mi_Account_Create";
            this.Mi_Account_Create.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.Mi_Account_Create.Size = new System.Drawing.Size(154, 22);
            this.Mi_Account_Create.Text = "Create";
            this.Mi_Account_Create.Click += new System.EventHandler(this.Mi_Account_Create_Click);
            // 
            // MI_Blacklist
            // 
            this.MI_Blacklist.Name = "MI_Blacklist";
            this.MI_Blacklist.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.MI_Blacklist.Size = new System.Drawing.Size(154, 22);
            this.MI_Blacklist.Text = "Blacklist";
            // 
            // MI_Account_Exit
            // 
            this.MI_Account_Exit.Name = "MI_Account_Exit";
            this.MI_Account_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MI_Account_Exit.Size = new System.Drawing.Size(154, 22);
            this.MI_Account_Exit.Text = "Exit";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_BrowserDispo,
            this.MI_HideGroups});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // MI_BrowserDispo
            // 
            this.MI_BrowserDispo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Left,
            this.MI_Right,
            this.MI_Top,
            this.MI_Bottom});
            this.MI_BrowserDispo.Name = "MI_BrowserDispo";
            this.MI_BrowserDispo.Size = new System.Drawing.Size(178, 22);
            this.MI_BrowserDispo.Text = "Browser Disposition";
            // 
            // MI_Left
            // 
            this.MI_Left.Name = "MI_Left";
            this.MI_Left.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.MI_Left.Size = new System.Drawing.Size(175, 22);
            this.MI_Left.Text = "Left";
            this.MI_Left.Click += new System.EventHandler(this.MI_Left_Click);
            // 
            // MI_Right
            // 
            this.MI_Right.Name = "MI_Right";
            this.MI_Right.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.MI_Right.Size = new System.Drawing.Size(175, 22);
            this.MI_Right.Text = "Right";
            this.MI_Right.Click += new System.EventHandler(this.MI_Right_Click);
            // 
            // MI_Top
            // 
            this.MI_Top.Name = "MI_Top";
            this.MI_Top.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Up)));
            this.MI_Top.Size = new System.Drawing.Size(175, 22);
            this.MI_Top.Text = "Top";
            this.MI_Top.Click += new System.EventHandler(this.MI_Top_Click);
            // 
            // MI_Bottom
            // 
            this.MI_Bottom.Name = "MI_Bottom";
            this.MI_Bottom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)));
            this.MI_Bottom.Size = new System.Drawing.Size(175, 22);
            this.MI_Bottom.Text = "Bottom";
            this.MI_Bottom.Click += new System.EventHandler(this.MI_Bottom_Click);
            // 
            // MI_HideGroups
            // 
            this.MI_HideGroups.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_HideAll,
            this.MI_ShowAll,
            this.toolStripSeparator2,
            this.MI_HSCommands,
            this.MI_HSUserFilter,
            this.MI_HSKeywordFilter,
            this.MI_HSDateFilter,
            this.MI_HSManagers,
            this.MI_HSPhotoList});
            this.MI_HideGroups.Name = "MI_HideGroups";
            this.MI_HideGroups.Size = new System.Drawing.Size(178, 22);
            this.MI_HideGroups.Text = "Hide Commands";
            // 
            // MI_HideAll
            // 
            this.MI_HideAll.Name = "MI_HideAll";
            this.MI_HideAll.Size = new System.Drawing.Size(252, 22);
            this.MI_HideAll.Text = "Hide All";
            this.MI_HideAll.Click += new System.EventHandler(this.MI_HideAll_Click);
            // 
            // MI_ShowAll
            // 
            this.MI_ShowAll.Name = "MI_ShowAll";
            this.MI_ShowAll.Size = new System.Drawing.Size(252, 22);
            this.MI_ShowAll.Text = "Show All";
            this.MI_ShowAll.Click += new System.EventHandler(this.MI_ShowAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // MI_HSCommands
            // 
            this.MI_HSCommands.Checked = true;
            this.MI_HSCommands.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MI_HSCommands.Name = "MI_HSCommands";
            this.MI_HSCommands.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.MI_HSCommands.Size = new System.Drawing.Size(252, 22);
            this.MI_HSCommands.Text = "Toggle Commands";
            this.MI_HSCommands.Click += new System.EventHandler(this.MI_HSCommands_Click);
            // 
            // MI_HSUserFilter
            // 
            this.MI_HSUserFilter.Checked = true;
            this.MI_HSUserFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MI_HSUserFilter.Name = "MI_HSUserFilter";
            this.MI_HSUserFilter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.U)));
            this.MI_HSUserFilter.Size = new System.Drawing.Size(252, 22);
            this.MI_HSUserFilter.Text = "Toggle User Filter";
            this.MI_HSUserFilter.Click += new System.EventHandler(this.MI_HSUserFilter_Click);
            // 
            // MI_HSKeywordFilter
            // 
            this.MI_HSKeywordFilter.Checked = true;
            this.MI_HSKeywordFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MI_HSKeywordFilter.Name = "MI_HSKeywordFilter";
            this.MI_HSKeywordFilter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.K)));
            this.MI_HSKeywordFilter.Size = new System.Drawing.Size(252, 22);
            this.MI_HSKeywordFilter.Text = "Toggle Keyword Filter";
            this.MI_HSKeywordFilter.Click += new System.EventHandler(this.MI_HSKeywordFilter_Click);
            // 
            // MI_HSDateFilter
            // 
            this.MI_HSDateFilter.Checked = true;
            this.MI_HSDateFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MI_HSDateFilter.Name = "MI_HSDateFilter";
            this.MI_HSDateFilter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.MI_HSDateFilter.Size = new System.Drawing.Size(252, 22);
            this.MI_HSDateFilter.Text = "Toggle Date Filter";
            this.MI_HSDateFilter.Click += new System.EventHandler(this.MI_HSDateFilter_Click);
            // 
            // MI_HSManagers
            // 
            this.MI_HSManagers.Checked = true;
            this.MI_HSManagers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MI_HSManagers.Name = "MI_HSManagers";
            this.MI_HSManagers.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.MI_HSManagers.Size = new System.Drawing.Size(252, 22);
            this.MI_HSManagers.Text = "Toggle Managers";
            this.MI_HSManagers.Click += new System.EventHandler(this.MI_HStodo_Click);
            // 
            // MI_HSPhotoList
            // 
            this.MI_HSPhotoList.CheckOnClick = true;
            this.MI_HSPhotoList.Name = "MI_HSPhotoList";
            this.MI_HSPhotoList.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.MI_HSPhotoList.Size = new System.Drawing.Size(252, 22);
            this.MI_HSPhotoList.Text = "Toggle Photo List";
            this.MI_HSPhotoList.Click += new System.EventHandler(this.MI_HSPhotoList_Click);
            // 
            // MI_Help
            // 
            this.MI_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.MI_About});
            this.MI_Help.Name = "MI_Help";
            this.MI_Help.Size = new System.Drawing.Size(44, 20);
            this.MI_Help.Text = "Help";
            // 
            // displayHelpToolStripMenuItem
            // 
            this.displayHelpToolStripMenuItem.Image = global::Client_PM.Properties.Resources.IMG_Help;
            this.displayHelpToolStripMenuItem.Name = "displayHelpToolStripMenuItem";
            this.displayHelpToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.displayHelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayHelpToolStripMenuItem.Text = "Help";
            this.displayHelpToolStripMenuItem.Click += new System.EventHandler(this.displayHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MI_About
            // 
            this.MI_About.Image = global::Client_PM.Properties.Resources.IMG_Info;
            this.MI_About.Name = "MI_About";
            this.MI_About.Size = new System.Drawing.Size(180, 22);
            this.MI_About.Text = "About";
            this.MI_About.Click += new System.EventHandler(this.MI_About_Click);
            // 
            // GBX_Keyword
            // 
            this.GBX_Keyword.Controls.Add(this.CBX_KeywordFilter);
            this.GBX_Keyword.Controls.Add(this.CBX_Keywords);
            this.GBX_Keyword.Location = new System.Drawing.Point(490, 3);
            this.GBX_Keyword.Name = "GBX_Keyword";
            this.GBX_Keyword.Size = new System.Drawing.Size(178, 94);
            this.GBX_Keyword.TabIndex = 1;
            this.GBX_Keyword.TabStop = false;
            this.GBX_Keyword.Text = "Keyword";
            // 
            // CBX_KeywordFilter
            // 
            this.CBX_KeywordFilter.AutoSize = true;
            this.CBX_KeywordFilter.Location = new System.Drawing.Point(7, 24);
            this.CBX_KeywordFilter.Name = "CBX_KeywordFilter";
            this.CBX_KeywordFilter.Size = new System.Drawing.Size(15, 14);
            this.CBX_KeywordFilter.TabIndex = 9;
            this.CBX_KeywordFilter.UseVisualStyleBackColor = true;
            this.CBX_KeywordFilter.CheckedChanged += new System.EventHandler(this.CBX_KeywordFilter_CheckedChanged);
            // 
            // CBX_Keywords
            // 
            this.CBX_Keywords.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBX_Keywords.FormattingEnabled = true;
            this.CBX_Keywords.Location = new System.Drawing.Point(6, 56);
            this.CBX_Keywords.Name = "CBX_Keywords";
            this.CBX_Keywords.Size = new System.Drawing.Size(165, 28);
            this.CBX_Keywords.TabIndex = 0;
            this.CBX_Keywords.SelectedIndexChanged += new System.EventHandler(this.CBX_Keywords_SelectedIndexChanged);
            // 
            // GBX_Commands
            // 
            this.GBX_Commands.Controls.Add(this.FBTN_PhotoToSlideshow);
            this.GBX_Commands.Controls.Add(this.FBTN_ViewPictureInfo);
            this.GBX_Commands.Controls.Add(this.FBTN_DeletePicture);
            this.GBX_Commands.Controls.Add(this.FBTN_EditPicture);
            this.GBX_Commands.Controls.Add(this.FBTN_NewPicture);
            this.GBX_Commands.Location = new System.Drawing.Point(3, 3);
            this.GBX_Commands.Name = "GBX_Commands";
            this.GBX_Commands.Size = new System.Drawing.Size(298, 94);
            this.GBX_Commands.TabIndex = 1;
            this.GBX_Commands.TabStop = false;
            this.GBX_Commands.Text = "Commands";
            // 
            // FBTN_PhotoToSlideshow
            // 
            this.FBTN_PhotoToSlideshow.BackgroundImage = global::Client_PM.Properties.Resources.IMG_AddPicture_Neutral;
            this.FBTN_PhotoToSlideshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_PhotoToSlideshow.ClickedImage = global::Client_PM.Properties.Resources.IMG_AddPicture_Clicked;
            this.FBTN_PhotoToSlideshow.DisabledImage = global::Client_PM.Properties.Resources.IMG_AddPicture_Disabled;
            this.FBTN_PhotoToSlideshow.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_PhotoToSlideshow.Image")));
            this.FBTN_PhotoToSlideshow.Location = new System.Drawing.Point(237, 32);
            this.FBTN_PhotoToSlideshow.Name = "FBTN_PhotoToSlideshow";
            this.FBTN_PhotoToSlideshow.NeutralImage = global::Client_PM.Properties.Resources.IMG_AddPicture_Neutral;
            this.FBTN_PhotoToSlideshow.OverImage = global::Client_PM.Properties.Resources.IMG_AddPicture_Over;
            this.FBTN_PhotoToSlideshow.Size = new System.Drawing.Size(45, 40);
            this.FBTN_PhotoToSlideshow.TabIndex = 8;
            this.FBTN_PhotoToSlideshow.Text = "Add/Remove picture to/from slideshow";
            this.FBTN_PhotoToSlideshow.UseVisualStyleBackColor = true;
            this.FBTN_PhotoToSlideshow.Click += new System.EventHandler(this.FBTN_PictureSlideshow_Click);
            // 
            // FBTN_ViewPictureInfo
            // 
            this.FBTN_ViewPictureInfo.BackgroundImage = global::Client_PM.Properties.Resources.IMG_View_Neutral;
            this.FBTN_ViewPictureInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_ViewPictureInfo.ClickedImage = global::Client_PM.Properties.Resources.IMG_View_Clicked;
            this.FBTN_ViewPictureInfo.DisabledImage = global::Client_PM.Properties.Resources.IMG_View_Disabled;
            this.FBTN_ViewPictureInfo.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_ViewPictureInfo.Image")));
            this.FBTN_ViewPictureInfo.Location = new System.Drawing.Point(171, 35);
            this.FBTN_ViewPictureInfo.Name = "FBTN_ViewPictureInfo";
            this.FBTN_ViewPictureInfo.NeutralImage = global::Client_PM.Properties.Resources.IMG_View_Neutral;
            this.FBTN_ViewPictureInfo.OverImage = global::Client_PM.Properties.Resources.IMG_View_Over;
            this.FBTN_ViewPictureInfo.Size = new System.Drawing.Size(54, 35);
            this.FBTN_ViewPictureInfo.TabIndex = 7;
            this.FBTN_ViewPictureInfo.Text = "View picture info...";
            this.FBTN_ViewPictureInfo.UseVisualStyleBackColor = true;
            this.FBTN_ViewPictureInfo.Click += new System.EventHandler(this.FBTN_ViewPictureInfo_Click);
            // 
            // FBTN_DeletePicture
            // 
            this.FBTN_DeletePicture.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Delete_Neutral;
            this.FBTN_DeletePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_DeletePicture.ClickedImage = global::Client_PM.Properties.Resources.IMG_Delete_Clicked;
            this.FBTN_DeletePicture.DisabledImage = global::Client_PM.Properties.Resources.IMG_Delete_Disabled;
            this.FBTN_DeletePicture.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_DeletePicture.Image")));
            this.FBTN_DeletePicture.Location = new System.Drawing.Point(118, 32);
            this.FBTN_DeletePicture.Name = "FBTN_DeletePicture";
            this.FBTN_DeletePicture.NeutralImage = global::Client_PM.Properties.Resources.IMG_Delete_Neutral;
            this.FBTN_DeletePicture.OverImage = global::Client_PM.Properties.Resources.IMG_Delete_Over;
            this.FBTN_DeletePicture.Size = new System.Drawing.Size(40, 40);
            this.FBTN_DeletePicture.TabIndex = 6;
            this.FBTN_DeletePicture.Text = "Remove the picture";
            this.FBTN_DeletePicture.UseVisualStyleBackColor = true;
            this.FBTN_DeletePicture.Click += new System.EventHandler(this.FBTN_DeletePicture_Click);
            // 
            // FBTN_EditPicture
            // 
            this.FBTN_EditPicture.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Edit_Neutral;
            this.FBTN_EditPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_EditPicture.ClickedImage = global::Client_PM.Properties.Resources.IMG_Edit_Clicked;
            this.FBTN_EditPicture.DisabledImage = global::Client_PM.Properties.Resources.IMG_Edit_Disabled;
            this.FBTN_EditPicture.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_EditPicture.Image")));
            this.FBTN_EditPicture.Location = new System.Drawing.Point(66, 32);
            this.FBTN_EditPicture.Name = "FBTN_EditPicture";
            this.FBTN_EditPicture.NeutralImage = global::Client_PM.Properties.Resources.IMG_Edit_Neutral;
            this.FBTN_EditPicture.OverImage = global::Client_PM.Properties.Resources.IMG_Edit_Over;
            this.FBTN_EditPicture.Size = new System.Drawing.Size(40, 40);
            this.FBTN_EditPicture.TabIndex = 5;
            this.FBTN_EditPicture.Text = "Edit picture...";
            this.FBTN_EditPicture.UseVisualStyleBackColor = true;
            this.FBTN_EditPicture.Click += new System.EventHandler(this.FBTN_EditPicture_Click);
            // 
            // FBTN_NewPicture
            // 
            this.FBTN_NewPicture.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Upload_Neutral;
            this.FBTN_NewPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_NewPicture.ClickedImage = global::Client_PM.Properties.Resources.IMG_Upload_Clicked;
            this.FBTN_NewPicture.DisabledImage = global::Client_PM.Properties.Resources.IMG_Upload_Disabled;
            this.FBTN_NewPicture.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_NewPicture.Image")));
            this.FBTN_NewPicture.Location = new System.Drawing.Point(14, 32);
            this.FBTN_NewPicture.Name = "FBTN_NewPicture";
            this.FBTN_NewPicture.NeutralImage = global::Client_PM.Properties.Resources.IMG_Upload_Neutral;
            this.FBTN_NewPicture.OverImage = global::Client_PM.Properties.Resources.IMG_Upload_Over;
            this.FBTN_NewPicture.Size = new System.Drawing.Size(40, 40);
            this.FBTN_NewPicture.TabIndex = 4;
            this.FBTN_NewPicture.Text = "Upload a picture...";
            this.FBTN_NewPicture.UseVisualStyleBackColor = true;
            this.FBTN_NewPicture.Click += new System.EventHandler(this.FBTN_NewPicture_Click);
            // 
            // GBX_Date
            // 
            this.GBX_Date.Controls.Add(this.CBX_DateFilter);
            this.GBX_Date.Controls.Add(this.DTP_To);
            this.GBX_Date.Controls.Add(this.DTP_From);
            this.GBX_Date.Location = new System.Drawing.Point(674, 3);
            this.GBX_Date.Name = "GBX_Date";
            this.GBX_Date.Size = new System.Drawing.Size(216, 94);
            this.GBX_Date.TabIndex = 1;
            this.GBX_Date.TabStop = false;
            this.GBX_Date.Text = "Date interval";
            // 
            // CBX_DateFilter
            // 
            this.CBX_DateFilter.AutoSize = true;
            this.CBX_DateFilter.Location = new System.Drawing.Point(6, 25);
            this.CBX_DateFilter.Name = "CBX_DateFilter";
            this.CBX_DateFilter.Size = new System.Drawing.Size(15, 14);
            this.CBX_DateFilter.TabIndex = 8;
            this.CBX_DateFilter.UseVisualStyleBackColor = true;
            this.CBX_DateFilter.CheckedChanged += new System.EventHandler(this.CBX_DateFilter_CheckedChanged);
            // 
            // DTP_To
            // 
            this.DTP_To.Location = new System.Drawing.Point(43, 58);
            this.DTP_To.Name = "DTP_To";
            this.DTP_To.Size = new System.Drawing.Size(165, 26);
            this.DTP_To.TabIndex = 7;
            this.DTP_To.ValueChanged += new System.EventHandler(this.DTP_To_ValueChanged);
            // 
            // DTP_From
            // 
            this.DTP_From.Location = new System.Drawing.Point(43, 24);
            this.DTP_From.Name = "DTP_From";
            this.DTP_From.Size = new System.Drawing.Size(165, 26);
            this.DTP_From.TabIndex = 6;
            this.DTP_From.ValueChanged += new System.EventHandler(this.DTP_From_ValueChanged);
            // 
            // GBX_Managers
            // 
            this.GBX_Managers.Controls.Add(this.FBTN_Blacklist);
            this.GBX_Managers.Controls.Add(this.FBTN_Slideshow);
            this.GBX_Managers.Location = new System.Drawing.Point(896, 3);
            this.GBX_Managers.Name = "GBX_Managers";
            this.GBX_Managers.Size = new System.Drawing.Size(122, 94);
            this.GBX_Managers.TabIndex = 10;
            this.GBX_Managers.TabStop = false;
            this.GBX_Managers.Text = "Managers";
            // 
            // FBTN_Blacklist
            // 
            this.FBTN_Blacklist.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Blacklist_Neutral;
            this.FBTN_Blacklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Blacklist.ClickedImage = global::Client_PM.Properties.Resources.IMG_Blacklist_Clicked;
            this.FBTN_Blacklist.DisabledImage = global::Client_PM.Properties.Resources.IMG_Blacklist_Disabled;
            this.FBTN_Blacklist.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Blacklist.Image")));
            this.FBTN_Blacklist.Location = new System.Drawing.Point(15, 32);
            this.FBTN_Blacklist.Name = "FBTN_Blacklist";
            this.FBTN_Blacklist.NeutralImage = global::Client_PM.Properties.Resources.IMG_Blacklist_Neutral;
            this.FBTN_Blacklist.OverImage = global::Client_PM.Properties.Resources.IMG_Blacklist_Over;
            this.FBTN_Blacklist.Size = new System.Drawing.Size(40, 40);
            this.FBTN_Blacklist.TabIndex = 3;
            this.FBTN_Blacklist.Text = "Open the user blacklist...";
            this.FBTN_Blacklist.UseVisualStyleBackColor = true;
            this.FBTN_Blacklist.Click += new System.EventHandler(this.FBTN_Blacklist_Click);
            // 
            // FBTN_Slideshow
            // 
            this.FBTN_Slideshow.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Play_Neutral;
            this.FBTN_Slideshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Slideshow.ClickedImage = global::Client_PM.Properties.Resources.IMG_Play_Clicked;
            this.FBTN_Slideshow.DisabledImage = global::Client_PM.Properties.Resources.IMG_Play_Disabled;
            this.FBTN_Slideshow.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Slideshow.Image")));
            this.FBTN_Slideshow.Location = new System.Drawing.Point(67, 32);
            this.FBTN_Slideshow.Name = "FBTN_Slideshow";
            this.FBTN_Slideshow.NeutralImage = global::Client_PM.Properties.Resources.IMG_Play_Neutral;
            this.FBTN_Slideshow.OverImage = global::Client_PM.Properties.Resources.IMG_Play_Over;
            this.FBTN_Slideshow.Size = new System.Drawing.Size(40, 40);
            this.FBTN_Slideshow.TabIndex = 4;
            this.FBTN_Slideshow.Text = "Play the slideshow...";
            this.FBTN_Slideshow.UseVisualStyleBackColor = true;
            this.FBTN_Slideshow.Click += new System.EventHandler(this.FBTN_Slideshow_Click);
            // 
            // FLP_Groups
            // 
            this.FLP_Groups.Controls.Add(this.GBX_Commands);
            this.FLP_Groups.Controls.Add(this.GBX_Users);
            this.FLP_Groups.Controls.Add(this.GBX_Keyword);
            this.FLP_Groups.Controls.Add(this.GBX_Date);
            this.FLP_Groups.Controls.Add(this.GBX_Managers);
            this.FLP_Groups.Location = new System.Drawing.Point(12, 27);
            this.FLP_Groups.Name = "FLP_Groups";
            this.FLP_Groups.Size = new System.Drawing.Size(1022, 109);
            this.FLP_Groups.TabIndex = 11;
            // 
            // PhotoBrowser
            // 
            this.PhotoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBrowser.Location = new System.Drawing.Point(15, 136);
            this.PhotoBrowser.Name = "PhotoBrowser";
            this.PhotoBrowser.Placement = PhotoManagerClient.PhotoBrowserPlacement.Left;
            this.PhotoBrowser.SelectedPhoto = null;
            this.PhotoBrowser.Size = new System.Drawing.Size(1015, 526);
            this.PhotoBrowser.TabIndex = 0;
            this.PhotoBrowser.SelectedChanged += new PhotoManagerClient.PhotosBrowser.SelectedChangedHandler(this.PhotoBrowser_SelectedChanged);
            this.PhotoBrowser.DoubleClick += new System.EventHandler(this.PhotoBrowser_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 674);
            this.Controls.Add(this.FLP_Groups);
            this.Controls.Add(this.PhotoBrowser);
            this.Controls.Add(this.MS_Account);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MS_Account;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1055, 713);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo manager client application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.GBX_Users.ResumeLayout(false);
            this.GBX_Users.PerformLayout();
            this.MS_Account.ResumeLayout(false);
            this.MS_Account.PerformLayout();
            this.GBX_Keyword.ResumeLayout(false);
            this.GBX_Keyword.PerformLayout();
            this.GBX_Commands.ResumeLayout(false);
            this.GBX_Date.ResumeLayout(false);
            this.GBX_Date.PerformLayout();
            this.GBX_Managers.ResumeLayout(false);
            this.FLP_Groups.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotoManagerClient.PhotosBrowser PhotoBrowser;
        private System.Windows.Forms.GroupBox GBX_Users;
        private System.Windows.Forms.MenuStrip MS_Account;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Login;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Profil;
        private System.Windows.Forms.ToolStripMenuItem Mi_Account_Create;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Exit;
        private System.Windows.Forms.ComboBox CBX_UsersList;
        private System.Windows.Forms.GroupBox GBX_Keyword;
        private System.Windows.Forms.ComboBox CBX_Keywords;
        private System.Windows.Forms.GroupBox GBX_Commands;
        private System.Windows.Forms.GroupBox GBX_Date;
        private System.Windows.Forms.ToolStripMenuItem MI_Blacklist;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private PhotoManagerClient.FlashButton FBTN_Blacklist;
        private PhotoManagerClient.FlashButton FBTN_PhotoToSlideshow;
        private PhotoManagerClient.FlashButton FBTN_ViewPictureInfo;
        private PhotoManagerClient.FlashButton FBTN_DeletePicture;
        private PhotoManagerClient.FlashButton FBTN_EditPicture;
        private PhotoManagerClient.FlashButton FBTN_NewPicture;
        private PhotoManagerClient.FlashButton FBTN_Slideshow;
        private System.Windows.Forms.DateTimePicker DTP_To;
        private System.Windows.Forms.DateTimePicker DTP_From;
        private System.Windows.Forms.CheckBox CBX_DateFilter;
        private System.Windows.Forms.CheckBox CBX_ExcludeMine;
        private System.Windows.Forms.CheckBox CBX_KeywordFilter;
        private System.Windows.Forms.ToolStripMenuItem MI_Help;
        private System.Windows.Forms.ToolStripMenuItem displayHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MI_About;
        private System.Windows.Forms.GroupBox GBX_Managers;
        private System.Windows.Forms.ToolStripMenuItem MI_HideGroups;
        private System.Windows.Forms.ToolStripMenuItem MI_BrowserDispo;
        private System.Windows.Forms.ToolStripMenuItem MI_Left;
        private System.Windows.Forms.ToolStripMenuItem MI_Right;
        private System.Windows.Forms.ToolStripMenuItem MI_Top;
        private System.Windows.Forms.ToolStripMenuItem MI_Bottom;
        private System.Windows.Forms.ToolStripMenuItem MI_HideAll;
        private System.Windows.Forms.ToolStripMenuItem MI_ShowAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MI_HSCommands;
        private System.Windows.Forms.ToolStripMenuItem MI_HSUserFilter;
        private System.Windows.Forms.ToolStripMenuItem MI_HSKeywordFilter;
        private System.Windows.Forms.ToolStripMenuItem MI_HSDateFilter;
        private System.Windows.Forms.ToolStripMenuItem MI_HSManagers;
        private System.Windows.Forms.FlowLayoutPanel FLP_Groups;
        private System.Windows.Forms.ToolStripMenuItem MI_HSPhotoList;
    }
}

