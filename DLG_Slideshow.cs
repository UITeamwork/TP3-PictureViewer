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
    public partial class DLG_Slideshow : Form
    {


        public List<int> SlideShowList { get; set; }
        
        public List<Photo> PhotoPool { get; set; }

        private List<Photo> Slides;
        
        private int[] PhotosOrder;
       
        private bool RandomOrder = false;
       
        private bool FullScreen = false;
        
        private int Current_PhotosOrder_Index = 0;

        private int Show_Controls_Zone = 20;

        public DLG_Slideshow()
        {
            InitializeComponent();
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
        }

        private void DLG_Slideshow_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.Y.ToString();
            if (!PN_Controls.Visible)
            {
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

        }
        private void Previous_Image()
        {

        }

        private void DLG_Slideshow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //  case Keys.F1: ShowHelp(); break;
                case Keys.F11: Fullscreen(); break;
                case Keys.P: Timer.Start(); break;
                case Keys.S: Timer.Stop(); break;
                 //case Keys.R: RandomOrder = !RandomOrder; SetPhotosOrder(); break;
                case Keys.Left: Timer.Interval = (Timer.Interval < 10000 ? Timer.Interval + 1000 : Timer.Interval); if (TrckB_SlideshowSpeed.Value < 6) { TrckB_SlideshowSpeed.Value = TrckB_SlideshowSpeed.Value + 1; } break;
                case Keys.Right: Timer.Interval = (Timer.Interval > 500 ? Timer.Interval - 1000 : Timer.Interval); if(TrckB_SlideshowSpeed.Value > 0) { TrckB_SlideshowSpeed.Value = TrckB_SlideshowSpeed.Value - 1; } break;
                case Keys.Escape: Timer.Stop(); Close(); break;
            }
        }

        private void DLG_Slideshow_DoubleClick(object sender, EventArgs e)
        {
            Fullscreen();
        }

        private void DLG_Slideshow_Shown(object sender, EventArgs e)
        {
            WaitSplash.Show(this, "Loading slide show photos...");
            Slides = new List<Photo>();
            //foreach (int photoId in SlideShowList)
            //{
            //    // Obtenir la photo 
            //    Photo photo = PhotoPool.Where(p => p.Id == photoId).First<Photo>();
            //    if (photo != null)
            //        Slides.Add(photo);
            //}
            WaitSplash.Hide();
            // Définir l'ordre des photos
            //SetPhotosOrder();
            // Démarrer l'horloge
           Timer.Start();
        }

        private void TrckB_SlideshowSpeed_Scroll(object sender, EventArgs e)
        {
            if (TrckB_SlideshowSpeed.Value == 0)
                Timer.Interval = 10000;
            else if (TrckB_SlideshowSpeed.Value == 1)
                Timer.Interval = 9000;
            else if(TrckB_SlideshowSpeed.Value == 2)
                Timer.Interval = 8000;
            else if(TrckB_SlideshowSpeed.Value == 3)
                Timer.Interval = 7000;
            else if(TrckB_SlideshowSpeed.Value == 4)
                Timer.Interval = 6000;
            else if (TrckB_SlideshowSpeed.Value == 5)
                Timer.Interval = 5000;
            else if (TrckB_SlideshowSpeed.Value == 6)
                Timer.Interval = 4000;
            else if (TrckB_SlideshowSpeed.Value == 6)
                Timer.Interval = 3000;
            else if (TrckB_SlideshowSpeed.Value == 6)
                Timer.Interval = 2000;
            else if (TrckB_SlideshowSpeed.Value == 6)
                Timer.Interval = 1000;
        }
    }
}
