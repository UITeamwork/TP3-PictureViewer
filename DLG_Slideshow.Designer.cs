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
            this.flashCheckBox1 = new CustomControls.FlashCheckBox();
            this.PN_Controls = new System.Windows.Forms.Panel();
            this.intervalle = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_Interval = new System.Windows.Forms.Label();
            this.LBL_Menu = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.TrckB_SlideshowSpeed)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.PN_Controls.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrckB_SlideshowSpeed
            // 
            this.TrckB_SlideshowSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrckB_SlideshowSpeed.Location = new System.Drawing.Point(13, 82);
            this.TrckB_SlideshowSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.TrckB_SlideshowSpeed.Maximum = 9;
            this.TrckB_SlideshowSpeed.Name = "TrckB_SlideshowSpeed";
            this.TrckB_SlideshowSpeed.Size = new System.Drawing.Size(737, 45);
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
            this.LAB_SlideshowSpeed.Size = new System.Drawing.Size(159, 18);
            this.LAB_SlideshowSpeed.TabIndex = 2;
            this.LAB_SlideshowSpeed.Text = "DLG_Slideshow speed";
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
            this.BTN_Next.Location = new System.Drawing.Point(724, 3);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 47);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // flashCheckBox1
            // 
            this.flashCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.BackgroundImage")));
            this.flashCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashCheckBox1.CheckedClickedImage = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.CheckedClickedImage")));
            this.flashCheckBox1.CheckedDisabledImage = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.CheckedDisabledImage")));
            this.flashCheckBox1.CheckedNeutralImage = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.CheckedNeutralImage")));
            this.flashCheckBox1.CheckedOverImage = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.CheckedOverImage")));
            this.flashCheckBox1.ClickedImage = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.ClickedImage")));
            this.flashCheckBox1.DisabledImage = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.DisabledImage")));
            this.flashCheckBox1.Image = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.Image")));
            this.flashCheckBox1.Location = new System.Drawing.Point(355, 3);
            this.flashCheckBox1.Name = "flashCheckBox1";
            this.flashCheckBox1.NeutralImage = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.NeutralImage")));
            this.flashCheckBox1.OverImage = ((System.Drawing.Image)(resources.GetObject("flashCheckBox1.OverImage")));
            this.flashCheckBox1.Size = new System.Drawing.Size(50, 41);
            this.flashCheckBox1.TabIndex = 5;
            this.flashCheckBox1.Text = "Randomise the slideshow...";
            this.flashCheckBox1.UseVisualStyleBackColor = true;
            this.flashCheckBox1.CheckedChanged += new System.EventHandler(this.flashCheckBox1_CheckedChanged);
            // 
            // PN_Controls
            // 
            this.PN_Controls.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PN_Controls.Controls.Add(this.TrckB_SlideshowSpeed);
            this.PN_Controls.Controls.Add(this.tableLayoutPanel1);
            this.PN_Controls.Controls.Add(this.LAB_SlideshowSpeed);
            this.PN_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Controls.Location = new System.Drawing.Point(0, 236);
            this.PN_Controls.Name = "PN_Controls";
            this.PN_Controls.Size = new System.Drawing.Size(767, 131);
            this.PN_Controls.TabIndex = 7;
            this.PN_Controls.VisibleChanged += new System.EventHandler(this.PN_Controls_VisibleChanged);
            // 
            // intervalle
            // 
            this.intervalle.AutoSize = true;
            this.intervalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.intervalle.Location = new System.Drawing.Point(0, 24);
            this.intervalle.Name = "intervalle";
            this.intervalle.Size = new System.Drawing.Size(62, 18);
            this.intervalle.TabIndex = 8;
            this.intervalle.Text = "Interval :";
            // 
            // Timer
            // 
            this.Timer.Interval = 10000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.ToolStrip_Reset});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.helpToolStripMenuItem.Text = "help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // ToolStrip_Reset
            // 
            this.ToolStrip_Reset.Name = "ToolStrip_Reset";
            this.ToolStrip_Reset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ToolStrip_Reset.Size = new System.Drawing.Size(178, 22);
            this.ToolStrip_Reset.Text = "Reset photo";
            this.ToolStrip_Reset.Click += new System.EventHandler(this.ToolStrip_Reset_Click);
            // 
            // Timer_Interval
            // 
            this.Timer_Interval.AutoSize = true;
            this.Timer_Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_Interval.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Timer_Interval.Location = new System.Drawing.Point(68, 24);
            this.Timer_Interval.Name = "Timer_Interval";
            this.Timer_Interval.Size = new System.Drawing.Size(32, 18);
            this.Timer_Interval.TabIndex = 13;
            this.Timer_Interval.Text = "10s";
            // 
            // LBL_Menu
            // 
            this.LBL_Menu.AutoSize = true;
            this.LBL_Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Menu.Location = new System.Drawing.Point(249, 0);
            this.LBL_Menu.Name = "LBL_Menu";
            this.LBL_Menu.Size = new System.Drawing.Size(261, 18);
            this.LBL_Menu.TabIndex = 15;
            this.LBL_Menu.Text = "Move mouse here for slideshow menu";
            this.LBL_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.82013F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.17987F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_Menu, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 211);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 19);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // DLG_Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(767, 367);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Timer_Interval);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.intervalle);
            this.Controls.Add(this.PN_Controls);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DLG_Slideshow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLG_Slideshow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_Slideshow_FormClosing);
            this.Load += new System.EventHandler(this.DLG_Slideshow_Load);
            this.Shown += new System.EventHandler(this.DLG_Slideshow_Shown);
            this.DoubleClick += new System.EventHandler(this.DLG_Slideshow_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DLG_Slideshow_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DLG_Slideshow_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.TrckB_SlideshowSpeed)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PN_Controls.ResumeLayout(false);
            this.PN_Controls.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.Label intervalle;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label Timer_Interval;
        private System.Windows.Forms.Label LBL_Menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Reset;
    }
}