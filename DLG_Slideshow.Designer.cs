namespace Client_PM
{
    partial class DLG_Slideshow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLG_Slideshow));
            this.TrckB_SlideshowSpeed = new System.Windows.Forms.TrackBar();
            this.LAB_SlideshowSpeed = new System.Windows.Forms.Label();
            this.BTN_Previous = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flashCheckBox1 = new CustomControls.FlashCheckBox();
            this.imageBox1 = new PhotoManagerClient.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrckB_SlideshowSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrckB_SlideshowSpeed
            // 
            this.TrckB_SlideshowSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrckB_SlideshowSpeed.Location = new System.Drawing.Point(13, 412);
            this.TrckB_SlideshowSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.TrckB_SlideshowSpeed.Name = "TrckB_SlideshowSpeed";
            this.TrckB_SlideshowSpeed.Size = new System.Drawing.Size(447, 45);
            this.TrckB_SlideshowSpeed.TabIndex = 1;
            this.TrckB_SlideshowSpeed.Scroll += new System.EventHandler(this.TrckB_SlideshowSpeed_Scroll);
            // 
            // LAB_SlideshowSpeed
            // 
            this.LAB_SlideshowSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LAB_SlideshowSpeed.AutoSize = true;
            this.LAB_SlideshowSpeed.Location = new System.Drawing.Point(13, 390);
            this.LAB_SlideshowSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_SlideshowSpeed.Name = "LAB_SlideshowSpeed";
            this.LAB_SlideshowSpeed.Size = new System.Drawing.Size(120, 18);
            this.LAB_SlideshowSpeed.TabIndex = 2;
            this.LAB_SlideshowSpeed.Text = "Slideshow speed";
            // 
            // BTN_Previous
            // 
            this.BTN_Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Previous.Location = new System.Drawing.Point(16, 336);
            this.BTN_Previous.Name = "BTN_Previous";
            this.BTN_Previous.Size = new System.Drawing.Size(34, 31);
            this.BTN_Previous.TabIndex = 3;
            this.BTN_Previous.Text = "<<";
            this.BTN_Previous.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(426, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flashCheckBox1
            // 
            this.flashCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flashCheckBox1.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Neutral;
            this.flashCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashCheckBox1.CheckedClickedImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Checked_Clicked;
            this.flashCheckBox1.CheckedDisabledImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Checked_Disabled;
            this.flashCheckBox1.CheckedNeutralImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Checked_Neutral;
            this.flashCheckBox1.CheckedOverImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Checked_Over;
            this.flashCheckBox1.ClickedImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Clicked;
            this.flashCheckBox1.DisabledImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Disabled;
            this.flashCheckBox1.Image = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.Image")));
            this.flashCheckBox1.Location = new System.Drawing.Point(207, 336);
            this.flashCheckBox1.Name = "flashCheckBox1";
            this.flashCheckBox1.NeutralImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Neutral;
            this.flashCheckBox1.OverImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Over;
            this.flashCheckBox1.Size = new System.Drawing.Size(50, 50);
            this.flashCheckBox1.TabIndex = 5;
            this.flashCheckBox1.Text = "flashCheckBox1";
            this.flashCheckBox1.UseVisualStyleBackColor = true;
            // 
            // imageBox1
            // 
            this.imageBox1.AllowDrop = true;
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.imageBox1.ImportImageText = "Import image from file...";
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.OpenFileDialogTitle = "Please choose image an file";
            this.imageBox1.PasteMenuText = "Paste image from clipboard";
            this.imageBox1.Size = new System.Drawing.Size(477, 329);
            this.imageBox1.TabIndex = 0;
            this.imageBox1.TabStop = false;
            // 
            // DLG_Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 469);
            this.Controls.Add(this.flashCheckBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Previous);
            this.Controls.Add(this.LAB_SlideshowSpeed);
            this.Controls.Add(this.TrckB_SlideshowSpeed);
            this.Controls.Add(this.imageBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DLG_Slideshow";
            this.Text = "DLG_Slideshow";
            this.Load += new System.EventHandler(this.DLG_Slideshow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrckB_SlideshowSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotoManagerClient.ImageBox imageBox1;
        private System.Windows.Forms.TrackBar TrckB_SlideshowSpeed;
        private System.Windows.Forms.Label LAB_SlideshowSpeed;
        private System.Windows.Forms.Button BTN_Previous;
        private System.Windows.Forms.Button button1;
        private CustomControls.FlashCheckBox flashCheckBox1;
    }
}