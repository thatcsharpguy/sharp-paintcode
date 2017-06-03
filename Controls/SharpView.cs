using System;
using Xamarin.Forms;

namespace SharpPaintCode.Controls
{
    public class SharpView : View
    {
        public static readonly BindableProperty FillColorProperty =
            BindableProperty.Create(nameof(FillColor), typeof(Color), typeof(SharpView), default(Color));

        public Color FillColor
        {
            get { return (Color)GetValue(FillColorProperty); }
            set { SetValue(FillColorProperty, value); }
        }

        public SharpView()
        {
            BackgroundColor = Color.Transparent;
            HorizontalOptions = LayoutOptions.Center;
            WidthRequest = 150;
            HeightRequest = 150;
        }
    }
}
