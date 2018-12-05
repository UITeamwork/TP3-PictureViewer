namespace Client_PM
{
    partial class DLG_PhotoInfo
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
            this.LAB_PhotoDate = new System.Windows.Forms.Label();
            this.LAB_Description = new System.Windows.Forms.Label();
            this.LAB_Title = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.RTBX_Description = new System.Windows.Forms.RichTextBox();
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.TBX_PictureSize = new System.Windows.Forms.TextBox();
            this.LAB_PictureSize = new System.Windows.Forms.Label();
            this.GBX_Owner = new System.Windows.Forms.GroupBox();
            this.LAB_OwnerName = new System.Windows.Forms.Label();
            this.PBX_OwnerPicture = new System.Windows.Forms.PictureBox();
            this.LAB_Shared = new System.Windows.Forms.Label();
            this.LAB_Keywords = new System.Windows.Forms.Label();
            this.TBX_Keywords = new System.Windows.Forms.TextBox();
            this.DTP_PhotoDate = new System.Windows.Forms.DateTimePicker();
            this.GBX_Owner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_OwnerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LAB_PhotoDate
            // 
            this.LAB_PhotoDate.AutoSize = true;
            this.LAB_PhotoDate.Location = new System.Drawing.Point(247, 140);
            this.LAB_PhotoDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LAB_PhotoDate.Name = "LAB_PhotoDate";
            this.LAB_PhotoDate.Size = new System.Drawing.Size(39, 18);
            this.LAB_PhotoDate.TabIndex = 23;
            this.LAB_PhotoDate.Text = "Date";
            // 
            // LAB_Description
            // 
            this.LAB_Description.AutoSize = true;
            this.LAB_Description.Location = new System.Drawing.Point(10, 278);
            this.LAB_Description.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LAB_Description.Name = "LAB_Description";
            this.LAB_Description.Size = new System.Drawing.Size(83, 18);
            this.LAB_Description.TabIndex = 22;
            this.LAB_Description.Text = "Description";
            // 
            // LAB_Title
            // 
            this.LAB_Title.AutoSize = true;
            this.LAB_Title.Location = new System.Drawing.Point(8, 140);
            this.LAB_Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LAB_Title.Name = "LAB_Title";
            this.LAB_Title.Size = new System.Drawing.Size(35, 18);
            this.LAB_Title.TabIndex = 20;
            this.LAB_Title.Text = "Title";
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Close.Location = new System.Drawing.Point(365, 480);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(109, 35);
            this.BTN_Close.TabIndex = 18;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // RTBX_Description
            // 
            this.RTBX_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBX_Description.Location = new System.Drawing.Point(13, 302);
            this.RTBX_Description.Margin = new System.Windows.Forms.Padding(6);
            this.RTBX_Description.Name = "RTBX_Description";
            this.RTBX_Description.ReadOnly = true;
            this.RTBX_Description.Size = new System.Drawing.Size(462, 155);
            this.RTBX_Description.TabIndex = 14;
            this.RTBX_Description.TabStop = false;
            this.RTBX_Description.Text = "";
            // 
            // TBX_Title
            // 
            this.TBX_Title.Location = new System.Drawing.Point(13, 164);
            this.TBX_Title.Margin = new System.Windows.Forms.Padding(6);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.ReadOnly = true;
            this.TBX_Title.Size = new System.Drawing.Size(225, 24);
            this.TBX_Title.TabIndex = 12;
            this.TBX_Title.TabStop = false;
            // 
            // TBX_PictureSize
            // 
            this.TBX_PictureSize.Location = new System.Drawing.Point(13, 485);
            this.TBX_PictureSize.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_PictureSize.Name = "TBX_PictureSize";
            this.TBX_PictureSize.ReadOnly = true;
            this.TBX_PictureSize.Size = new System.Drawing.Size(148, 24);
            this.TBX_PictureSize.TabIndex = 24;
            this.TBX_PictureSize.TabStop = false;
            this.TBX_PictureSize.Text = "000 X 000";
            this.TBX_PictureSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LAB_PictureSize
            // 
            this.LAB_PictureSize.AutoSize = true;
            this.LAB_PictureSize.Location = new System.Drawing.Point(10, 463);
            this.LAB_PictureSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LAB_PictureSize.Name = "LAB_PictureSize";
            this.LAB_PictureSize.Size = new System.Drawing.Size(87, 18);
            this.LAB_PictureSize.TabIndex = 25;
            this.LAB_PictureSize.Text = "Dimensions";
            // 
            // GBX_Owner
            // 
            this.GBX_Owner.Controls.Add(this.LAB_OwnerName);
            this.GBX_Owner.Controls.Add(this.PBX_OwnerPicture);
            this.GBX_Owner.Location = new System.Drawing.Point(11, 12);
            this.GBX_Owner.Name = "GBX_Owner";
            this.GBX_Owner.Size = new System.Drawing.Size(464, 109);
            this.GBX_Owner.TabIndex = 26;
            this.GBX_Owner.TabStop = false;
            this.GBX_Owner.Text = "Owner";
            // 
            // LAB_OwnerName
            // 
            this.LAB_OwnerName.AutoSize = true;
            this.LAB_OwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_OwnerName.Location = new System.Drawing.Point(123, 53);
            this.LAB_OwnerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LAB_OwnerName.Name = "LAB_OwnerName";
            this.LAB_OwnerName.Size = new System.Drawing.Size(91, 20);
            this.LAB_OwnerName.TabIndex = 27;
            this.LAB_OwnerName.Text = "Username";
            // 
            // PBX_OwnerPicture
            // 
            this.PBX_OwnerPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_OwnerPicture.Location = new System.Drawing.Point(9, 21);
            this.PBX_OwnerPicture.Name = "PBX_OwnerPicture";
            this.PBX_OwnerPicture.Size = new System.Drawing.Size(80, 80);
            this.PBX_OwnerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBX_OwnerPicture.TabIndex = 0;
            this.PBX_OwnerPicture.TabStop = false;
            // 
            // LAB_Shared
            // 
            this.LAB_Shared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_Shared.AutoSize = true;
            this.LAB_Shared.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Shared.Location = new System.Drawing.Point(214, 484);
            this.LAB_Shared.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LAB_Shared.Name = "LAB_Shared";
            this.LAB_Shared.Size = new System.Drawing.Size(90, 24);
            this.LAB_Shared.TabIndex = 27;
            this.LAB_Shared.Text = "PRIVATE";
            // 
            // LAB_Keywords
            // 
            this.LAB_Keywords.AutoSize = true;
            this.LAB_Keywords.Location = new System.Drawing.Point(8, 207);
            this.LAB_Keywords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LAB_Keywords.Name = "LAB_Keywords";
            this.LAB_Keywords.Size = new System.Drawing.Size(74, 18);
            this.LAB_Keywords.TabIndex = 29;
            this.LAB_Keywords.Text = "Keywords";
            // 
            // TBX_Keywords
            // 
            this.TBX_Keywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Keywords.Location = new System.Drawing.Point(13, 231);
            this.TBX_Keywords.Margin = new System.Windows.Forms.Padding(6);
            this.TBX_Keywords.Name = "TBX_Keywords";
            this.TBX_Keywords.ReadOnly = true;
            this.TBX_Keywords.Size = new System.Drawing.Size(462, 24);
            this.TBX_Keywords.TabIndex = 28;
            this.TBX_Keywords.TabStop = false;
            // 
            // DTP_PhotoDate
            // 
            this.DTP_PhotoDate.Enabled = false;
            this.DTP_PhotoDate.Location = new System.Drawing.Point(250, 164);
            this.DTP_PhotoDate.Name = "DTP_PhotoDate";
            this.DTP_PhotoDate.Size = new System.Drawing.Size(225, 24);
            this.DTP_PhotoDate.TabIndex = 30;
            this.DTP_PhotoDate.TabStop = false;
            // 
            // DLG_PhotoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Close;
            this.ClientSize = new System.Drawing.Size(485, 523);
            this.Controls.Add(this.DTP_PhotoDate);
            this.Controls.Add(this.LAB_Keywords);
            this.Controls.Add(this.TBX_Keywords);
            this.Controls.Add(this.LAB_Shared);
            this.Controls.Add(this.GBX_Owner);
            this.Controls.Add(this.LAB_PictureSize);
            this.Controls.Add(this.TBX_PictureSize);
            this.Controls.Add(this.LAB_PhotoDate);
            this.Controls.Add(this.LAB_Description);
            this.Controls.Add(this.LAB_Title);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.RTBX_Description);
            this.Controls.Add(this.TBX_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DLG_PhotoInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Info";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_PhotoInfo_FormClosing);
            this.GBX_Owner.ResumeLayout(false);
            this.GBX_Owner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_OwnerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_PhotoDate;
        private System.Windows.Forms.Label LAB_Description;
        private System.Windows.Forms.Label LAB_Title;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.RichTextBox RTBX_Description;
        private System.Windows.Forms.TextBox TBX_Title;
        private System.Windows.Forms.TextBox TBX_PictureSize;
        private System.Windows.Forms.Label LAB_PictureSize;
        private System.Windows.Forms.GroupBox GBX_Owner;
        private System.Windows.Forms.Label LAB_OwnerName;
        private System.Windows.Forms.PictureBox PBX_OwnerPicture;
        private System.Windows.Forms.Label LAB_Shared;
        private System.Windows.Forms.Label LAB_Keywords;
        private System.Windows.Forms.TextBox TBX_Keywords;
        private System.Windows.Forms.DateTimePicker DTP_PhotoDate;
    }
}