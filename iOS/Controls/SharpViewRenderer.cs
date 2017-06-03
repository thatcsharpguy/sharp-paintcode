using System;
using CoreGraphics;
using SharpPaintCode.Controls;
using SharpPaintCode.iOS.Controls.Native;
using Xamarin.Forms.Platform.iOS;

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
                    SetNativeControl(native);
                }
            }
        }
    }
}
