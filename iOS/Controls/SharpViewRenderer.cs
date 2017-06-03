using System;
using CoreGraphics;
using SharpPaintCode.Controls;
using SharpPaintCode.iOS.Controls;
using SharpPaintCode.iOS.Controls.Native;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SharpView), typeof(SharpViewRenderer))]
namespace SharpPaintCode.iOS.Controls
{
    public class SharpViewRenderer : ViewRenderer<SharpView, UISharpView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SharpView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    var sharpFrame = new CGRect(0, 0, Element.WidthRequest, Element.HeightRequest);
                    var native = new UISharpView(sharpFrame);
                    native.FillColor = Element.FillColor.ToUIColor();
                    SetNativeControl(native);
                }
            }
        }
    }
}
