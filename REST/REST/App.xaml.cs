using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace REST
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new REST.MainPage();
        }

        protected override async void OnStart()
        {
            // Handle when your app starts

            var client = new RestClient();

            var json = client.Serialize();

           await MainPage.DisplayAlert("JSON:", json, "cancel");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
