using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Convertisseur
{
    class FlashCheckBox : CheckBox
    {
        public Image NeutralImage { get; set; }
        public Image ClickedImage { get; set; }
        public Image DisabledImage { get; set; }

        public FlashCheckBox() : base()
        {
            Size = new Size(36, 36);
            BackgroundImageLayout = ImageLayout.Zoom;
            Image = new Bitmap(ClientSize.Width, ClientSize.Height);
            changeBgImage((CheckState == CheckState.Checked) ? NeutralImage : DisabledImage);
        }

        private void changeBgImage(Image img)
        {
            if ((img != null) && Enabled)
            {
                this.BackgroundImage = img;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);
            if (BackgroundImage != null)
                pevent.Graphics.DrawImage(BackgroundImage, ClientRectangle);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            changeBgImage(ClickedImage);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            changeBgImage((CheckState == CheckState.Checked) ? NeutralImage : DisabledImage);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            changeBgImage((CheckState == CheckState.Checked) ? NeutralImage : DisabledImage);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            changeBgImage((CheckState == CheckState.Checked) ? NeutralImage : DisabledImage);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            BackgroundImage = Enabled ? NeutralImage : DisabledImage;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            changeBgImage((CheckState == CheckState.Checked) ? NeutralImage : DisabledImage);
        }
    }
}
