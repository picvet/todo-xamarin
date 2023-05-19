using Notes.Views.FlyoutPages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NotesFlyoutPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
