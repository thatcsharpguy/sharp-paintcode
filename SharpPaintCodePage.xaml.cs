using Xamarin.Forms;

namespace SharpPaintCode
{
    public partial class SharpPaintCodePage : ContentPage
    {
        public SharpPaintCodePage()
        {
            InitializeComponent();
        }

        int _currentColor = 0;
        Color[] Colors = new Color[]
        {
            Color.Red, 
            Color.Olive, 
            Color.Green, 
            Color.DodgerBlue, 
            Color.DeepPink, 
            Color.DarkOrange
        };

        void NextColorsButtonClicked(object sender, System.EventArgs e)
        {
            _currentColor++;
            SetColor();
        }

        protected override void OnAppearing()
        {
            SetColor();
        }

        void SetColor()
        {
            Sharp1.FillColor = Colors[_currentColor % Colors.Length];
            Sharp2.FillColor = Colors[(_currentColor+1) % Colors.Length];
        }
    }
}
