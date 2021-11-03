using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TuwharetoaMaps.Table;
namespace TuwharetoaMaps.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        void SignUpBtn_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                Name = EntryName.Text,
                Email = EntryEmail.Text,
                Password = EntryPassword.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Sweet", "User Registration Successful", "Yes", "Cancel");

                if(result)
                {
                    await Navigation.PushAsync(new Login());
                }
            });
        }
    }
}