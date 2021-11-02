using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using TuwharetoaMaps.Classes.CustomeRenderer;

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
                Distance.FromKilometers(20)));

            #region Pins  
            CustomPin pin = new CustomPin
            {
                Label = "Tongariro National Trout Centre",
                Address = "257 State Highway 1, Rangipo 3382",
                Type = PinType.Place,
                Position = new Position(-39.020242117349845, 175.80994311014442),
                Name = "This is a name",
                Description = "This is a description"
            };
            myMap.CustomPins = new List<CustomPin> { pin };
            myMap.Pins.Add(pin);

            CustomPin pin2 = new CustomPin
            {
                Label = "Whakapapa Ski Fields",
                Address = "Manawatu-Wanganui 3989",
                Type = PinType.Place,
                Position = new Position(-39.23690074877571, 175.5566667992571),
            };
            myMap.CustomPins = new List<CustomPin> { pin2 };
            myMap.Pins.Add(pin2);

            CustomPin pin3 = new CustomPin
            {
                Label = "Turoa Ski Fields",
                Address = "Ohakune Mountain Road, Mt Ruapehu 4691",
                Type = PinType.Place,
                Position = new Position(-39.30437677129459, 175.52687938767426),
            };
            myMap.CustomPins = new List<CustomPin> { pin3 };
            myMap.Pins.Add(pin3);

            CustomPin pin4 = new CustomPin
            {
                Label = "Tawhai Falls",
                Address = "Manawatu-Wanganui 4691",
                Type = PinType.Place,
                Position = new Position(-39.17298086910358, 175.51471101882842),
            };
            myMap.CustomPins = new List<CustomPin> { pin4 };
            myMap.Pins.Add(pin4);

            CustomPin pin5 = new CustomPin
            {
                Label = "Ketetahi Falls",
                Address = "Tongariro Alpine Crossing, Waikato 4691",
                Type = PinType.Place,
                Position = new Position(-39.07719144337065, 175.65656916082278),
            };
            myMap.CustomPins = new List<CustomPin> { pin5 };
            myMap.Pins.Add(pin5);

            CustomPin pin6 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(-38.999470854318716, 175.80345734177396),
                Label = "Tongariro River Rafting",
                Address = "95 Atirau Road, Tūrangi 3334",
            };
            myMap.CustomPins = new List<CustomPin> { pin6 };
            myMap.Pins.Add(pin6);

            CustomPin pin7 = new CustomPin
            {
                Label = "Tongariro River Trail",
                Address = "1 Tahawai Street, Tūrangi 3334",
                Type = PinType.Place,
                Position = new Position(-38.999299947344575, 175.81265080643166),
            };
            myMap.CustomPins = new List<CustomPin> { pin7 };
            myMap.Pins.Add(pin7);

            CustomPin pin8 = new CustomPin
            {
                Label = "Tukino Skifield",
                Address = "Tukino, Access Road, Tukino Village 4691",
                Type = PinType.Place,
                Position = new Position(-39.27820470673391, 175.61427878171526),
            };
            myMap.CustomPins = new List<CustomPin> { pin8 };
            myMap.Pins.Add(pin8);

            CustomPin pin9 = new CustomPin
            {
                Label = "Tongariro Alpine Crossing",
                Address = "Tongariro National Park, Manawatu-Wanganui 4691",
                Type = PinType.Place,
                Position = new Position(-39.14455061225148, 175.5812016003488),
            };
            myMap.CustomPins = new List<CustomPin> { pin9 };
            myMap.Pins.Add(pin9);

            CustomPin pin10 = new CustomPin
            {
                Label = "Mine Bay Maori Rock Carvings",
                Address = "Mine Bay, Acacia Bay, Taupō 3330",
                Type = PinType.Place,
                Position = new Position(-38.73323321544769, 176.0075528608603),
            };
            myMap.CustomPins = new List<CustomPin> { pin10 };
            myMap.Pins.Add(pin10);

            CustomPin pin11 = new CustomPin
            {
                Label = "Huka Falls",
                Address = "Wairakei, Taupō 3384",
                Type = PinType.Place,
                Position = new Position(-38.64861439474102, 176.09005512060202),
            };
            myMap.CustomPins = new List<CustomPin> { pin11 };
            myMap.Pins.Add(pin11);
            #endregion
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