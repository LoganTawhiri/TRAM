using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace TuwharetoaMaps.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Map : ContentPage
    {
        public Map()
        {
            InitializeComponent();

            myMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(-38.799422, 175.910966),
                Distance.FromKilometers(10)));
        }

        #region Navigation
        private async void HomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
        private async void MapClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Map());
        }
        private async void NotificationsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notifications());
        }
        #endregion
    }
}