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
            this.BTN_Next = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PN_Controls = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.flashCheckBox1 = new CustomControls.FlashCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrckB_SlideshowSpeed)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.PN_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrckB_SlideshowSpeed
            // 
            this.TrckB_SlideshowSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrckB_SlideshowSpeed.Location = new System.Drawing.Point(13, 82);
            this.TrckB_SlideshowSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.TrckB_SlideshowSpeed.Maximum = 6;
            this.TrckB_SlideshowSpeed.Name = "TrckB_SlideshowSpeed";
            this.TrckB_SlideshowSpeed.Size = new System.Drawing.Size(561, 45);
            this.TrckB_SlideshowSpeed.TabIndex = 1;
            this.TrckB_SlideshowSpeed.Scroll += new System.EventHandler(this.TrckB_SlideshowSpeed_Scroll);
            // 
            // LAB_SlideshowSpeed
            // 
            this.LAB_SlideshowSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LAB_SlideshowSpeed.AutoSize = true;
            this.LAB_SlideshowSpeed.Location = new System.Drawing.Point(13, 60);
            this.LAB_SlideshowSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAB_SlideshowSpeed.Name = "LAB_SlideshowSpeed";
            this.LAB_SlideshowSpeed.Size = new System.Drawing.Size(120, 18);
            this.LAB_SlideshowSpeed.TabIndex = 2;
            this.LAB_SlideshowSpeed.Text = "Slideshow speed";
            // 
            // BTN_Previous
            // 
            this.BTN_Previous.Location = new System.Drawing.Point(3, 3);
            this.BTN_Previous.Name = "BTN_Previous";
            this.BTN_Previous.Size = new System.Drawing.Size(34, 31);
            this.BTN_Previous.TabIndex = 3;
            this.BTN_Previous.Text = "<<";
            this.BTN_Previous.UseVisualStyleBackColor = true;
            this.BTN_Previous.Click += new System.EventHandler(this.BTN_Previous_Click);
            // 
            // BTN_Next
            // 
            this.BTN_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Next.Location = new System.Drawing.Point(548, 3);
            this.BTN_Next.Name = "BTN_Next";
            this.BTN_Next.Size = new System.Drawing.Size(34, 31);
            this.BTN_Next.TabIndex = 4;
            this.BTN_Next.Text = ">>";
            this.BTN_Next.UseVisualStyleBackColor = true;
            this.BTN_Next.Click += new System.EventHandler(this.BTN_Next_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Next, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flashCheckBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Previous, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 47);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // PN_Controls
            // 
            this.PN_Controls.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PN_Controls.Controls.Add(this.TrckB_SlideshowSpeed);
            this.PN_Controls.Controls.Add(this.tableLayoutPanel1);
            this.PN_Controls.Controls.Add(this.LAB_SlideshowSpeed);
            this.PN_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Controls.Location = new System.Drawing.Point(0, 330);
            this.PN_Controls.Name = "PN_Controls";
            this.PN_Controls.Size = new System.Drawing.Size(591, 131);
            this.PN_Controls.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // flashCheckBox1
            // 
            this.flashCheckBox1.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Neutral;
            this.flashCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashCheckBox1.CheckedClickedImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Checked_Clicked;
            this.flashCheckBox1.CheckedDisabledImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Checked_Disabled;
            this.flashCheckBox1.CheckedNeutralImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Checked_Neutral;
            this.flashCheckBox1.CheckedOverImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Checked_Over;
            this.flashCheckBox1.ClickedImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Clicked;
            this.flashCheckBox1.DisabledImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Disabled;
            this.flashCheckBox1.Image = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.Image")));
            this.flashCheckBox1.Location = new System.Drawing.Point(267, 3);
            this.flashCheckBox1.Name = "flashCheckBox1";
            this.flashCheckBox1.NeutralImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Neutral;
            this.flashCheckBox1.OverImage = global::Client_PM.Properties.Resources.IMG_Shuffle_Over;
            this.flashCheckBox1.Size = new System.Drawing.Size(50, 41);
            this.flashCheckBox1.TabIndex = 5;
            this.flashCheckBox1.Text = "flashCheckBox1";
            this.flashCheckBox1.UseVisualStyleBackColor = true;
            this.flashCheckBox1.CheckedChanged += new System.EventHandler(this.flashCheckBox1_CheckedChanged);
            // 
            // DLG_Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Client_PM.Properties.Resources.IMG_Upload_Clicked;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(591, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PN_Controls);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DLG_Slideshow";
            this.Text = "DLG_Slideshow";
            this.Load += new System.EventHandler(this.DLG_Slideshow_Load);
            this.Shown += new System.EventHandler(this.DLG_Slideshow_Shown);
            this.DoubleClick += new System.EventHandler(this.DLG_Slideshow_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DLG_Slideshow_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DLG_Slideshow_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.TrckB_SlideshowSpeed)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PN_Controls.ResumeLayout(false);
            this.PN_Controls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar TrckB_SlideshowSpeed;
        private System.Windows.Forms.Label LAB_SlideshowSpeed;
        private System.Windows.Forms.Button BTN_Previous;
        private System.Windows.Forms.Button BTN_Next;
        private CustomControls.FlashCheckBox flashCheckBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PN_Controls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer;
    }
}