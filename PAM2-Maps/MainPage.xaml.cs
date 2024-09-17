using Microsoft.Maui.Maps;

namespace PAM2_Maps
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            var Location = new Location(-23.51972836623556, -46.59645381774267);
            var mapSpan = new MapSpan(Location, 0.01, 0.01);
            map.MoveToRegion(mapSpan);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
