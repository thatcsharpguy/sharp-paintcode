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

        #region Properties
        UIColor _fillColor = UIColor.FromRGB(60, 138, 63);

        public UIColor FillColor
        {
            get { return _fillColor; }
            set { _fillColor = value; SetNeedsDisplay(); }
        }
        #endregion

        #region Drawing methods

        public override void Draw(CGRect rect)
        {
            DrawSharpCanvas(FillColor, rect.Width, rect.Height);
        }

        private void DrawSharpCanvas(UIColor fillColor, nfloat width, nfloat height)
        {

            //// Frames
            var sharpFrame = new CGRect(0.0f, 0.0f, width, height);


            //// SharpSymbol Drawing
            var sharpSymbolPath = new UIBezierPath();
            sharpSymbolPath.MoveTo(new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.00002f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.20000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + -0.00000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.08245f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 1.00000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.20000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 1.00000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.40000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.40000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.60000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.46586f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.53414f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 1.00000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.60000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 1.00000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.80000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.80000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 1.00000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.91755f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 1.00000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 1.00000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.80000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 1.00000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.91755f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.80000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 1.00000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.91755f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 1.00000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 1.00000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.80000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 1.00000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.91755f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.00000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.80000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.00000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.60000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.60000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.40000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.53414f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.46586f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.00000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.40000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.00000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.20000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.20000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.00000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.08245f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.20000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.00000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.00000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.20000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.00000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.08245f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.20000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.00000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.08245f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.00000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.00000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.80000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.00002f * sharpFrame.Height));
            sharpSymbolPath.ClosePath();
            sharpSymbolPath.MoveTo(new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.40000f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.40000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.60000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.46586f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.40000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.53414f * sharpFrame.Height));
            sharpSymbolPath.AddLineTo(new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.60000f * sharpFrame.Height));
            sharpSymbolPath.AddCurveToPoint(new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.40000f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.53414f * sharpFrame.Height), new CGPoint(sharpFrame.GetMinX() + 0.60000f * sharpFrame.Width, sharpFrame.GetMinY() + 0.46586f * sharpFrame.Height));
            sharpSymbolPath.ClosePath();
            fillColor.SetFill();
            sharpSymbolPath.Fill();
        }

        #endregion
    }
}
