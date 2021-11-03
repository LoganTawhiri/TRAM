using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuwharetoaMaps.Pages;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuwharetoaMaps.PinPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPin : ContentPage
    {
        public SecondPin()
        {
            InitializeComponent();
        }

        private async void BacktoMap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Map());
        }
    }
}