using System;
using Week6.View;
using Xamarin.Forms;

namespace CFSessionDB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SessionListPage());

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
