using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

// Namespace name was changed from "Convertisseur" to "CustomControls"
// Rename to "Convertisseur" if it causes problems
namespace CustomControls
{
    // Author : Gabriel Fournier-Cloutier
    /// <summary>
    /// A "Flash CheckBox" is a checkbox with 8 states (4 unchecked, 4 checked) that reacts to mouse actions (over and clicks)
    /// <para>When an image was left empty, the checkbox will try to use the image from the other state. If that image is also null, it will be transparent.</para>
    /// <para>Exemple : If NeutralImage is null, but CheckedNeutralImage is not, NeutralImage will be the same as CheckedNeutralImage. The opposite is also true.</para>
    /// <para>Set the Autosize property to false to properly resize the control</para>
    /// </summary>
    class FlashCheckBox : CheckBox
    {
        private enum FlashState { Neutral, Over, Clicked, Disabled}
        private bool _wasInitialized = false;

        public Image NeutralImage { get; set; }
        public Image OverImage { get; set; }
        public Image ClickedImage { get; set; }
        public Image DisabledImage { get; set; }
        public Image CheckedNeutralImage { get; set; }
        public Image CheckedOverImage { get; set; }
        public Image CheckedClickedImage { get; set; }
        public Image CheckedDisabledImage { get; set; }

        public FlashCheckBox() : base()
        {
            Size = new Size(36, 36);
            BackgroundImageLayout = ImageLayout.Zoom;
            
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this, Text);
            this.CheckStateChanged += FlashCheckBox_CheckStateChanged;


        }

        private void FlashCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            ChangeBgImage(FlashState.Neutral);
            
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this, Text);
        }

        private void InitImages()
        {
            Bitmap defaultImage = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(defaultImage);
            g.Clear(Color.Transparent);

            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
            NeutralImage = (NeutralImage ?? (CheckedNeutralImage ?? defaultImage));
            OverImage = (OverImage ?? (CheckedOverImage ?? defaultImage));
            ClickedImage = (ClickedImage ?? (CheckedClickedImage ?? defaultImage));
            DisabledImage = (DisabledImage ?? (CheckedDisabledImage ?? defaultImage));

            CheckedNeutralImage = (CheckedNeutralImage ?? (NeutralImage ?? defaultImage));
            CheckedOverImage = (CheckedOverImage ?? (OverImage ?? defaultImage));
            CheckedClickedImage = (CheckedClickedImage ?? (ClickedImage ?? defaultImage));
            CheckedDisabledImage = (CheckedDisabledImage ?? (DisabledImage ?? defaultImage));
        }

        /// <summary>Changes the background image based on the current state</summary>
        /// <remarks>Assumes that no image is null (see: <see cref="InitImages()"/>)</remarks>
        /// <param name="state">The current state the checkbox is in</param>
        private void ChangeBgImage(FlashState state)
        {
            if (!_wasInitialized)
            {
                _wasInitialized = true;
                InitImages();
            }
            
            switch (state)
            {
                case FlashState.Neutral:
                    BackgroundImage = (CheckState == CheckState.Checked ? CheckedNeutralImage : NeutralImage);
                    break;
                case FlashState.Over:
                    BackgroundImage = (CheckState == CheckState.Checked ? CheckedOverImage : OverImage);
                    break;
                case FlashState.Clicked:
                    BackgroundImage = (CheckState == CheckState.Checked ? CheckedClickedImage : ClickedImage);
                    break;
                case FlashState.Disabled:
                    BackgroundImage = (CheckState == CheckState.Checked ? CheckedDisabledImage : DisabledImage);
                    break;
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
            ChangeBgImage(FlashState.Clicked);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            ChangeBgImage(FlashState.Over);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Hand;
            ChangeBgImage(FlashState.Over);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            ChangeBgImage(FlashState.Neutral);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            ChangeBgImage(FlashState.Neutral);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            ChangeBgImage(Enabled ? FlashState.Neutral : FlashState.Disabled);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ChangeBgImage(FlashState.Neutral);
        }
    }
}
