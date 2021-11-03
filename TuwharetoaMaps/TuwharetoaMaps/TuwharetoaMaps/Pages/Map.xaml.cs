using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using TuwharetoaMaps.Classes.CustomeRenderer;
using TuwharetoaMaps.PinPages;

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
                Type = PinType.Place,
                Position = new Position(-38.98940756708174, 175.81025906977305),
                Label = "WARNING!",
                Address = "Information Incoming!"            
            };
            pin.MarkerClicked += async (args, s) =>
            {
                await Task.Delay(2000);
                await Navigation.PushAsync(new FirstPin());
            };
            myMap.CustomPins = new List<CustomPin> { pin };
            myMap.Pins.Add(pin);

            CustomPin pin2 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(-39.277411628728515, 175.56836026097102),
                Label = "WARNING!",
                Address = "Information Incoming!"
            };
            pin2.MarkerClicked += async (args, s) =>
            {
                await Task.Delay(2000);
                await Navigation.PushAsync(new SecondPin());
            };
            myMap.CustomPins = new List<CustomPin> { pin2 };
            myMap.Pins.Add(pin2);

            CustomPin pin3 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(-38.96679323572123, 175.76621056686162),
                Label = "WARNING!",
                Address = "Information Incoming!"
            };
            pin3.MarkerClicked += async (args, s) =>
            {
                await Task.Delay(2000);
                await Navigation.PushAsync(new ThirdPin());
            };
            myMap.CustomPins = new List<CustomPin> { pin3 };
            myMap.Pins.Add(pin3);

            CustomPin pin4 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(-38.68654068813484, 176.0885056102074),
                Label = "WARNING!",
                Address = "Information Incoming!"
            };
            pin4.MarkerClicked += async (args, s) =>
            {
                await Task.Delay(2000);
                await Navigation.PushAsync(new FourthPin());
            };
            myMap.CustomPins = new List<CustomPin> { pin4 };
            myMap.Pins.Add(pin4);

            CustomPin pin5 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(-38.795375550261475, 175.9105937927503),
                Label = "WARNING!",
                Address = "Information Incoming!"
            };
            pin5.MarkerClicked += async (args, s) =>
            {
                await Task.Delay(2000);
                await Navigation.PushAsync(new FifthPin());
            };
            myMap.CustomPins = new List<CustomPin> { pin5 };
            myMap.Pins.Add(pin5);
            #endregion
        }
    }
}