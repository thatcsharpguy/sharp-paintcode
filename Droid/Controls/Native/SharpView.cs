using System;
using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;

namespace SharpPaintCode.Droid.Controls.Native
{
    public class SharpView : View
    {
        #region Constructores

        public SharpView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public SharpView(Context context) : base(context)
        {
        }

        #endregion

        #region Propiedades

        public Color _fillColor = Color.Argb(255, 60, 138, 63);
        public Color FillColor
        {
            get { return _fillColor; }
            set
            {
                _fillColor = value;
                Invalidate();
            }
        }

        #endregion
    }
}
