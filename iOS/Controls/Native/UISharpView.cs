using System;
using CoreGraphics;
using UIKit;

namespace SharpPaintCode.iOS.Controls.Native
{
    public class UISharpView : UIView
    {
        #region Constructores

        public UISharpView(IntPtr p)
            : base(p) { }

        public UISharpView(CGRect rect) 
            : base(rect) { }

        public UISharpView() { }

        #endregion
    }
}
