using PhotoManagerClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class Slideshow : Form
    {
       

        public static List<int> SlideShowList { get; set; }

        public List<Photo> PhotoPool { get; set; }

        private List<Photo> Slides;

        private int[] PhotosOrder;

        private bool RandomOrder = false;

        private bool FullScreen = false;

        private int Current_PhotosOrder_Index = 0;

        private int Show_Controls_Zone = 20;

        public Slideshow()
        {
            InitializeComponent();
            ToolTip tooltip1 = new ToolTip();
            tooltip1.SetToolTip(BTN_Next, "See next image...");
            ToolTip tooltip2 = new ToolTip();
            tooltip1.SetToolTip(BTN_Previous, "See previous image...");
        }

        private void Fullscreen()
        {

            FullScreen = !FullScreen;
            if (FullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }


        private void DLG_Slideshow_Load(object sender, EventArgs e)
        {
            PN_Controls.Visible = false;
           
            LBL_Menu.Visible = true;
            tableLayoutPanel2.Location = new Point(0, 350);
            tableLayoutPanel1.Visible = true;
           
            LBL_Menu.ForeColor = System.Drawing.Color.White;
        }

        private void DLG_Slideshow_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (!PN_Controls.Visible)
            {
               
                LBL_Menu.Visible = true;
                
                PN_Controls.Visible = e.Location.Y > (ClientRectangle.Height - Show_Controls_Zone);
            }
            else
            {
                PN_Controls.Visible = e.Location.Y > PN_Controls.Location.Y;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Next_Image();
        }


        private void Next_Image()
        {
            if (PhotosOrder.Count() > 0)
            {
                // Régler l'image de fond avec la prochaine photo
                this.BackgroundImage = Slides[PhotosOrder[Current_PhotosOrder_Index]].GetOriginalImage();
                // Index de la prochaine photo. Si était la dernière, revenir à la première
                Current_PhotosOrder_Index = Current_PhotosOrder_Index < Slides.Count - 1 ? Current_PhotosOrder_Index + 1 : 0;
            }
        }
        private void Previous_Image()
        {
            if (PhotosOrder.Count() > 0)
            {
                // Régler l'image de fond avec la prochaine photo
                this.BackgroundImage = Slides[PhotosOrder[Current_PhotosOrder_Index]].GetOriginalImage();
                // Index de la prochaine photo. Si était la dernière, revenir à la première
                Current_PhotosOrder_Index = Current_PhotosOrder_Index > 0 ? Current_PhotosOrder_Index - 1 : PhotosOrder.Count() - 1;
            }
        }

        private void DLG_Slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
               case Keys.F1: ShowHelp(); break;
                case Keys.F11: Fullscreen(); break;
                case Keys.P: Timer.Start(); break;
                case Keys.S: Timer.Stop(); break;
                case Keys.R: RandomOrder = !RandomOrder;
                    if (flashCheckBox1.Checked == false)
                    { flashCheckBox1.Checked = true; }
                    else
                    { flashCheckBox1.Checked = false; }
                    
                    break;
                case Keys.Down: Timer.Interval = (Timer.Interval < 10000 ? Timer.Interval + 1000 : Timer.Interval);if (TrckB_SlideshowSpeed.Value > 0) { TrckB_SlideshowSpeed.Value = TrckB_SlideshowSpeed.Value - 1; } break;
                case Keys.Up: Timer.Interval = (Timer.Interval > 1500 ? Timer.Interval - 1000 : Timer.Interval); if (TrckB_SlideshowSpeed.Value < 9) { TrckB_SlideshowSpeed.Value = TrckB_SlideshowSpeed.Value + 1; }  break;
                case Keys.Escape: Timer.Stop(); Close(); break;
                case Keys.Left: BTN_Previous.PerformClick(); break;
                case Keys.Right: BTN_Next.PerformClick(); break;
            }
            e.SuppressKeyPress = true;
            int timer = Timer.Interval / 1000;
            Timer_Interval.Text = timer.ToString() + "s";
        }

        private void DLG_Slideshow_DoubleClick(object sender, EventArgs e)
        {
            Fullscreen();
        }

        private void DLG_Slideshow_Shown(object sender, EventArgs e)
        {
            WaitSplash.Show(this, "Loading slide show photos...");
            Slides = new List<Photo>();
            foreach (int photoId in SlideShowList)
            {
                // Obtenir la photo 
                Photo photo = PhotoPool.Where(p => p.Id == photoId).First<Photo>();
                if (photo != null)
                    Slides.Add(photo);
            }
            WaitSplash.Hide();
            // Définir l'ordre des photos
            SetPhotosOrder();
            // Démarrer l'horloge
            Timer.Start();
        }

        private void TrckB_SlideshowSpeed_Scroll(object sender, EventArgs e)
        {
            if (TrckB_SlideshowSpeed.Value == 0)
                Timer.Interval = 10000;
            else if (TrckB_SlideshowSpeed.Value == 1)
                Timer.Interval = 9000;
            else if (TrckB_SlideshowSpeed.Value == 2)
                Timer.Interval = 8000;
            else if (TrckB_SlideshowSpeed.Value == 3)
                Timer.Interval = 7000;
            else if (TrckB_SlideshowSpeed.Value == 4)
                Timer.Interval = 6000;
            else if (TrckB_SlideshowSpeed.Value == 5)
                Timer.Interval = 5000;
            else if (TrckB_SlideshowSpeed.Value == 6)
                Timer.Interval = 4000;
            else if (TrckB_SlideshowSpeed.Value == 7)
                Timer.Interval = 3000;
            else if (TrckB_SlideshowSpeed.Value == 8)
                Timer.Interval = 2000;
            else if (TrckB_SlideshowSpeed.Value == 9)
                Timer.Interval = 1000;
            int timer = Timer.Interval / 1000;
            Timer_Interval.Text = timer.ToString() + "s";
        }

        private void BTN_Previous_Click(object sender, EventArgs e)
        {
            Previous_Image();
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            Next_Image();
        }

        private void ShufflePhotosOrder()
        {
            Random rnd = new Random(DateTime.Now.Second);
            int nb_Photos = SlideShowList.Count;
            for (int i = 0; i < nb_Photos - 1; i++)
            {
                int j = rnd.Next((nb_Photos - i - 2)) + i + 1;
                int k = PhotosOrder[i];
                PhotosOrder[i] = PhotosOrder[j];
                PhotosOrder[j] = k;
            }
        }

        // Définir l'ordre des photos
        private void SetPhotosOrder()
        {
            WaitSplash.Show(this, "Setting photo order...");
            Current_PhotosOrder_Index = 0;

            int nb_Photos = SlideShowList.Count;
            PhotosOrder = new int[nb_Photos];
            // Ordre séquentiel
            for (int i = 0; i < nb_Photos; i++)
            {
                PhotosOrder[i] = i;
            }
            if (RandomOrder)
            {
                // Ordre aléatoire
                ShufflePhotosOrder();
            }
            WaitSplash.Hide();
            // Affichier la première photo
            Next_Image();
        }

        private void flashCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShufflePhotosOrder();
        }

        void ShowHelp()
        {
            DLG_Help help = new DLG_Help
            {
                ContentFromResources = Properties.Resources.HTMLPage2,
                slideshow = true
            };
            help.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        private void PN_Controls_VisibleChanged(object sender, EventArgs e)
        {
            if (PN_Controls.Visible)
            {
                LBL_Menu.Visible = false;
                tableLayoutPanel2.Visible = false;
            }
            else
            { LBL_Menu.Visible = true;
                tableLayoutPanel2.Visible = true;
            }
        }

      
    }
}
