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
    public partial class Notifications : ContentPage
    {
        public Notifications()
        {
            InitializeComponent();
        }
        public interface INotificationManager
        {
            event EventHandler NotificationReceived;
            void Initialize();
            void SendNotification(string title, string message, DateTime? notifyTime = null);
            void ReceiveNotification(string title, string message);
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