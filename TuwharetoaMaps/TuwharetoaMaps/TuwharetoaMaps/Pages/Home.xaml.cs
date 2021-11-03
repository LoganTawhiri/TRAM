using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using TuwharetoaMaps.Classes;

namespace TuwharetoaMaps.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        private const string locationUrl = "https://api.jsonbin.io/b/61823bfd9548541c29cce49c";
        private readonly HttpClient httpClient = new HttpClient();

        public ObservableCollection<Location> Locations { get; set; } = new ObservableCollection<Location>();

        public Home()
        {
            InitializeComponent();

            BindingContext = this;
        }      

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var locationJson = await httpClient.GetStringAsync(locationUrl);
            var locations = JsonConvert.DeserializeObject<Location[]>(locationJson);

            Locations.Clear();
            foreach(var location in locations)
            {
                Locations.Add(location);
            }
        }
    }
}