using System;
using SharpPaintCode.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using FormsSharpView = SharpPaintCode.Controls.SharpView;
using NativeSharpView = SharpPaintCode.Droid.Controls.Native.SharpView;

[assembly: ExportRenderer(typeof(FormsSharpView), typeof(SharpViewRenderer))]
namespace SharpPaintCode.Droid.Controls
{
    public class SharpViewRenderer : ViewRenderer<FormsSharpView, NativeSharpView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<FormsSharpView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    var native = new NativeSharpView(Context);
                    native.FillColor = Element.FillColor.ToAndroid();
                    SetNativeControl(native);
                }
            }
        }
    }
}
