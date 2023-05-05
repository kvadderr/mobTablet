using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MobTablet.Views;
using Xamarin.CommunityToolkit.Extensions;
using MobTablet.Popups;
using Xamarin.CommunityToolkit.UI.Views;

namespace MobTablet
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Home home = new Home();
            Profile profile = new Profile();
            Achievements achievements = new Achievements();

            myFrameMain.Content = home;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void goToHome(object sender, EventArgs e)
        {
            Home home = new Home();
            myFrameMain.Content = home;
        }

        private void goToAchievements(object sender, EventArgs e)
        {
            Achievements achievements = new Achievements();
            myFrameMain.Content = achievements;
        }

        private void goToProfile(object sender, EventArgs e)
        {
            VisualStateManager.GoToState(profileBtn, "Pressed");
            Profile profile = new Profile();
            myFrameMain.Content = profile;
        }

        private void goToRaiting(object sender, EventArgs e)
        {
            VisualStateManager.GoToState(profileBtn, "Pressed");
            Raiting raiting = new Raiting();
            myFrameMain.Content = raiting;
        }

        private void goToLibrary(object sender, EventArgs e)
        {
            VisualStateManager.GoToState(profileBtn, "Pressed");
            Library library = new Library();
            myFrameMain.Content = library;
        }

        private void goToShop(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            myFrameMain.Content = shop;
        }
        
        private void goToTest(object sender, EventArgs e)
        {
            Test test = new Test();
            myFrameMain.Content = test;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Messanger messanger = new Messanger();
            myFrameMain.Content = messanger;
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            myFrameMain.Content = notification;
        }
    }
}
