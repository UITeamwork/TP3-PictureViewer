namespace Client_PM
{
    partial class DLG_Help
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
            this.BTN_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBox1 = new PhotoManagerClient.ImageBox();
            this.imageBox2 = new PhotoManagerClient.ImageBox();
            this.imageBox6 = new PhotoManagerClient.ImageBox();
            this.imageBox7 = new PhotoManagerClient.ImageBox();
            this.imageBox5 = new PhotoManagerClient.ImageBox();
            this.imageBox4 = new PhotoManagerClient.ImageBox();
            this.imageBox3 = new PhotoManagerClient.ImageBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Close
            // 
            this.BTN_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Close.Location = new System.Drawing.Point(656, 411);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 4;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Upload an image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(56, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Edit an uploaded image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(56, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Delete an uploaded image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(56, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "open the black list manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(56, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 36);
            this.label5.TabIndex = 16;
            this.label5.Text = "view information of the selected image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(56, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 54);
            this.label6.TabIndex = 17;
            this.label6.Text = "Add the selected image to the slideshow";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(56, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Play the slideShow";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.imageBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.imageBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.imageBox6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.imageBox7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.imageBox5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.imageBox4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.imageBox3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 385);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // imageBox1
            // 
            this.imageBox1.AllowDrop = true;
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox1.Image = global::Client_PM.Properties.Resources.IMG_Upload_Neutral;
            this.imageBox1.ImportImageText = "Import image from file...";
            this.imageBox1.Location = new System.Drawing.Point(3, 3);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox1.PasteMenuText = "Paste image from clipboard";
            this.imageBox1.Size = new System.Drawing.Size(44, 42);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 5;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.AllowDrop = true;
            this.imageBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox2.Image = global::Client_PM.Properties.Resources.IMG_Edit_Neutral;
            this.imageBox2.ImportImageText = "Import image from file...";
            this.imageBox2.Location = new System.Drawing.Point(3, 57);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox2.PasteMenuText = "Paste image from clipboard";
            this.imageBox2.Size = new System.Drawing.Size(44, 42);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 6;
            this.imageBox2.TabStop = false;
            // 
            // imageBox6
            // 
            this.imageBox6.AllowDrop = true;
            this.imageBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox6.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox6.Image = global::Client_PM.Properties.Resources.IMG_Delete_Neutral;
            this.imageBox6.ImportImageText = "Import image from file...";
            this.imageBox6.Location = new System.Drawing.Point(3, 111);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox6.PasteMenuText = "Paste image from clipboard";
            this.imageBox6.Size = new System.Drawing.Size(44, 42);
            this.imageBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox6.TabIndex = 10;
            this.imageBox6.TabStop = false;
            // 
            // imageBox7
            // 
            this.imageBox7.AllowDrop = true;
            this.imageBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox7.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox7.Image = global::Client_PM.Properties.Resources.IMG_View_Over;
            this.imageBox7.ImportImageText = "Import image from file...";
            this.imageBox7.Location = new System.Drawing.Point(3, 165);
            this.imageBox7.Name = "imageBox7";
            this.imageBox7.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox7.PasteMenuText = "Paste image from clipboard";
            this.imageBox7.Size = new System.Drawing.Size(44, 42);
            this.imageBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox7.TabIndex = 11;
            this.imageBox7.TabStop = false;
            // 
            // imageBox5
            // 
            this.imageBox5.AllowDrop = true;
            this.imageBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox5.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox5.Image = global::Client_PM.Properties.Resources.IMG_AddPicture_Neutral;
            this.imageBox5.ImportImageText = "Import image from file...";
            this.imageBox5.Location = new System.Drawing.Point(3, 219);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox5.PasteMenuText = "Paste image from clipboard";
            this.imageBox5.Size = new System.Drawing.Size(44, 42);
            this.imageBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox5.TabIndex = 9;
            this.imageBox5.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.AllowDrop = true;
            this.imageBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox4.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox4.Image = global::Client_PM.Properties.Resources.IMG_Blacklist_Neutral;
            this.imageBox4.ImportImageText = "Import image from file...";
            this.imageBox4.Location = new System.Drawing.Point(3, 273);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox4.PasteMenuText = "Paste image from clipboard";
            this.imageBox4.Size = new System.Drawing.Size(44, 42);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox4.TabIndex = 8;
            this.imageBox4.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.AllowDrop = true;
            this.imageBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox3.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox3.Image = global::Client_PM.Properties.Resources.IMG_Play_Neutral;
            this.imageBox3.ImportImageText = "Import image from file...";
            this.imageBox3.Location = new System.Drawing.Point(3, 327);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox3.PasteMenuText = "Paste image from clipboard";
            this.imageBox3.Size = new System.Drawing.Size(44, 43);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox3.TabIndex = 7;
            this.imageBox3.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(233, 11);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(429, 385);
            this.webBrowser1.TabIndex = 20;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // DLG_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 446);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BTN_Close);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DLG_Help";
            this.Text = "DLG_Help";
            this.Load += new System.EventHandler(this.DLG_Help_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_Close;
        private PhotoManagerClient.ImageBox imageBox1;
        private PhotoManagerClient.ImageBox imageBox2;
        private PhotoManagerClient.ImageBox imageBox3;
        private PhotoManagerClient.ImageBox imageBox4;
        private PhotoManagerClient.ImageBox imageBox5;
        private PhotoManagerClient.ImageBox imageBox6;
        private PhotoManagerClient.ImageBox imageBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}