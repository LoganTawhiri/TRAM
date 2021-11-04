using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuwharetoaMaps;

using Xamarin.Essentials;
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
        private void SaveBtn_Clicked(object sender, EventArgs e)
        {            
            Preferences.Set("RandomBio", RandomBio.Text);
        }

        private async void ReturnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedNav());
        }
    }
}