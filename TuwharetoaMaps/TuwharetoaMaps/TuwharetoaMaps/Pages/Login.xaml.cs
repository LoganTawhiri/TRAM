using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Essentials;

using TuwharetoaMaps.Classes.AuthHelpers;
using Xamarin.Auth;
using Newtonsoft.Json;
using System.Windows.Input;
using System.IO;
using SQLite;
using TuwharetoaMaps.Table;

namespace TuwharetoaMaps.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        Account account;
        AccountStore store;

        public Login()
        {
            InitializeComponent();

            store = AccountStore.Create();
        }
        private async void SignInBtn_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);

            var myquery = db.Table<RegUserTable>().Where(u => u.Email.Equals(EntryEmail.Text)
            && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if(myquery!=null)
            {
                App.Current.MainPage = new NavigationPage(new TabbedNav());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "User Credentials were incorrect please enter them again"
                        , "Yes", "Cancel");

                    if (result)
                    {
                        await Navigation.PushAsync(new Login());
                    }
                    else
                    {
                        await Navigation.PushAsync(new Login());
                    }
                });
            }
        }

        [Obsolete]
        private void GoogleLoginBtn_Clicked(object sender, EventArgs e)
        {
            string clientId = null;
            string redirectUri = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    clientId = Classes.AppConstant.Constants.iOSClientId;
                    redirectUri = Classes.AppConstant.Constants.iOSRedirectUrl;
                    break;

                case Device.Android:
                    clientId = Classes.AppConstant.Constants.AndroidClientId;
                    redirectUri = Classes.AppConstant.Constants.AndroidRedirectUrl;
                    break;
            }

            account = store.FindAccountsForService(Classes.AppConstant.Constants.AppName).FirstOrDefault();

            var authenticator = new OAuth2Authenticator(
                clientId,
                null,
                Classes.AppConstant.Constants.Scope,
                new Uri(Classes.AppConstant.Constants.AuthorizeUrl),
                new Uri(redirectUri),
                new Uri(Classes.AppConstant.Constants.AccessTokenUrl),
                null,
                true);

            authenticator.Completed += OnAuthCompleted;
            authenticator.Error += OnAuthError;

            AuthenticationState.Authenticator = authenticator;

            var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            presenter.Login(authenticator);
        }
        async void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            var authenticator = sender as OAuth2Authenticator;
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthCompleted;
                authenticator.Error -= OnAuthError;
            }

            User user = null;
            if (e.IsAuthenticated)
            {
                // If the user is authenticated, request their basic user data from Google
                // UserInfoUrl = https://www.googleapis.com/oauth2/v2/userinfo
                var request = new OAuth2Request("GET", new Uri(Classes.AppConstant.Constants.UserInfoUrl), null, e.Account);
                var response = await request.GetResponseAsync();
                if (response != null)
                {
                    // Deserialize the data and store it in the account store
                    // The users email address will be used to identify data in SimpleDB
                    string userJson = await response.GetResponseTextAsync();
                    user = JsonConvert.DeserializeObject<User>(userJson);
                }

                if (user != null)
                {
                    App.Current.MainPage = new NavigationPage(new TabbedNav());

                }

                //await store.SaveAsync(account = e.Account, AppConstant.Constants.AppName);
                //await DisplayAlert("Email address", user.Email, "OK");
            }
        }

        void OnAuthError(object sender, AuthenticatorErrorEventArgs e)
        {
            var authenticator = sender as OAuth2Authenticator;
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthCompleted;
                authenticator.Error -= OnAuthError;
            }

            Debug.WriteLine("Authentication error: " + e.Message);
        }

        private async void SignUp_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registration());
        }
    }
}