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
using MobTablet.CustomControls;

namespace MobTablet
{
    public partial class MainPage : ContentPage
    {
        CustomMenuButton pressedCustomMenuButton;

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
            homeBtn.OnPressed();

            homeBtn.PressedAction = () =>
            {
                goToNormalState();
                pressedCustomMenuButton = homeBtn;
                Home home = new Home();
                myFrameMain.Content = home;
            };

            profileBtn.PressedAction = () =>
            {
                goToNormalState();
                pressedCustomMenuButton = profileBtn;
                Profile profile = new Profile();
                myFrameMain.Content = profile;
            };
            achievementsBtn.PressedAction = () =>
            {
                goToNormalState();
                pressedCustomMenuButton = achievementsBtn;
                Achievements achievements = new Achievements();
                myFrameMain.Content = achievements;
            };
            raitingBtn.PressedAction = () =>
            {
                goToNormalState();
                pressedCustomMenuButton = raitingBtn;
                Raiting raiting = new Raiting();
                myFrameMain.Content = raiting;
            };
            testBtn.PressedAction = () =>
            {
                goToNormalState();
                pressedCustomMenuButton = testBtn;
                Test test = new Test();
                myFrameMain.Content = test;
            };
            libraryBtn.PressedAction = () =>
            {
                goToNormalState();
                pressedCustomMenuButton = libraryBtn;
                Library library = new Library();
                myFrameMain.Content = library;
            };
            shopBtn.PressedAction = () =>
            {
                goToNormalState();
                pressedCustomMenuButton = shopBtn;
                Shop shop = new Shop();
                myFrameMain.Content = shop;
            };

        }

        private void goToNormalState()
        {
           if (pressedCustomMenuButton != null)  pressedCustomMenuButton.normalState();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
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
