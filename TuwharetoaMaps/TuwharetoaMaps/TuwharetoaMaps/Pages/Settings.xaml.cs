using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuwharetoaMaps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuwharetoaMaps.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }

        #region
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