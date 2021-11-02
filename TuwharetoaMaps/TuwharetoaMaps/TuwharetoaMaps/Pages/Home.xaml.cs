using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuwharetoaMaps.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
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
        private async void MapImageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Map());
        }
        #endregion 
    }
}