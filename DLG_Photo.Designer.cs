namespace Client_PM
{
    partial class DLG_Photo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLG_Photo));
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FBTN_Rotate = new PhotoManagerClient.FlashButton();
            this.ImgBX_Image = new PhotoManagerClient.ImageBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBX_Keywords = new System.Windows.Forms.TextBox();
            this.CBX_Shared = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBX_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Title
            // 
            this.TBX_Title.Location = new System.Drawing.Point(13, 30);
            this.TBX_Title.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(180, 24);
            this.TBX_Title.TabIndex = 0;
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(201, 30);
            this.DTP_Date.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(184, 24);
            this.DTP_Date.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 85);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(372, 101);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(273, 599);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(112, 32);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(153, 599);
            this.BTN_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(112, 32);
            this.BTN_Ok.TabIndex = 7;
            this.BTN_Ok.Text = "OK";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date";
            // 
            // FBTN_Rotate
            // 
            this.FBTN_Rotate.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Rotate_Neutral;
            this.FBTN_Rotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FBTN_Rotate.ClickedImage = global::Client_PM.Properties.Resources.IMG_Rotate_Clicked;
            this.FBTN_Rotate.DisabledImage = global::Client_PM.Properties.Resources.IMG_Rotate_Disabled;
            this.FBTN_Rotate.Image = ((System.Drawing.Image)(resources.GetObject("FBTN_Rotate.Image")));
            this.FBTN_Rotate.Location = new System.Drawing.Point(331, 202);
            this.FBTN_Rotate.Margin = new System.Windows.Forms.Padding(4);
            this.FBTN_Rotate.Name = "FBTN_Rotate";
            this.FBTN_Rotate.NeutralImage = global::Client_PM.Properties.Resources.IMG_Rotate_Neutral;
            this.FBTN_Rotate.OverImage = global::Client_PM.Properties.Resources.IMG_Rotate_Over;
            this.FBTN_Rotate.Size = new System.Drawing.Size(54, 50);
            this.FBTN_Rotate.TabIndex = 5;
            this.FBTN_Rotate.Text = "Rotate the image";
            this.FBTN_Rotate.UseVisualStyleBackColor = true;
            this.FBTN_Rotate.Click += new System.EventHandler(this.FBTN_Rotate_Click);
            // 
            // ImgBX_Image
            // 
            this.ImgBX_Image.AllowDrop = true;
            this.ImgBX_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBX_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgBX_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgBX_Image.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.ImgBX_Image.ImportImageText = "Import image from file...";
            this.ImgBX_Image.Location = new System.Drawing.Point(13, 263);
            this.ImgBX_Image.Margin = new System.Windows.Forms.Padding(4);
            this.ImgBX_Image.Name = "ImgBX_Image";
            this.ImgBX_Image.OpenFileDialogTitle = "Please choose image an file";
            this.ImgBX_Image.PasteMenuText = "Paste image from clipboard";
            this.ImgBX_Image.Size = new System.Drawing.Size(372, 316);
            this.ImgBX_Image.TabIndex = 3;
            this.ImgBX_Image.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Keywords (separate using spaces)";
            // 
            // TBX_Keywords
            // 
            this.TBX_Keywords.Location = new System.Drawing.Point(13, 222);
            this.TBX_Keywords.Margin = new System.Windows.Forms.Padding(4);
            this.TBX_Keywords.Name = "TBX_Keywords";
            this.TBX_Keywords.Size = new System.Drawing.Size(311, 24);
            this.TBX_Keywords.TabIndex = 12;
            // 
            // CBX_Shared
            // 
            this.CBX_Shared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBX_Shared.AutoSize = true;
            this.CBX_Shared.Checked = true;
            this.CBX_Shared.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.CBX_Shared.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_Shared.Location = new System.Drawing.Point(13, 605);
            this.CBX_Shared.Name = "CBX_Shared";
            this.CBX_Shared.Size = new System.Drawing.Size(80, 22);
            this.CBX_Shared.TabIndex = 14;
            this.CBX_Shared.Text = "Shared";
            this.CBX_Shared.UseVisualStyleBackColor = true;
            // 
            // DLG_Photo
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(398, 644);
            this.Controls.Add(this.CBX_Shared);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBX_Keywords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.FBTN_Rotate);
            this.Controls.Add(this.ImgBX_Image);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.TBX_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DLG_Photo";
            this.ShowIcon = false;
            this.Text = "DLG_Photo";
            this.Load += new System.EventHandler(this.DLG_Photo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBX_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Title;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private PhotoManagerClient.ImageBox ImgBX_Image;
        private PhotoManagerClient.FlashButton FBTN_Rotate;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBX_Keywords;
        private System.Windows.Forms.CheckBox CBX_Shared;
    }
}