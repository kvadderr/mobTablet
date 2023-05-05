using MobTablet.Model;
using MobTablet.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobTablet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Raiting : ContentView
    {
        public Raiting()
        {
            InitializeComponent();
            List<ProfileRaiting> profileRaitings = new List<ProfileRaiting>
            {
                new ProfileRaiting { notifi ="gold", FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
                new ProfileRaiting { notifi ="silver", FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
                new ProfileRaiting { notifi ="bronze", FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
                new ProfileRaiting { FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
                new ProfileRaiting { FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
                new ProfileRaiting { FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
                new ProfileRaiting { FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
                new ProfileRaiting { FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
                new ProfileRaiting { FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
                new ProfileRaiting { FIO = "Мария Иванова", Position="Официант", Address="Koffein, г. Нальчик, ул. Ленина 145", level = 1, Coin = 1346, Karma = 4567, Karma_Total = 17834 },
            };

            MyListView.ItemsSource = profileRaitings;
            MyListView.ItemTapped += MyListView_ItemTapped;
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var frameData = App.Current.MainPage.FindByName<Frame>("myFrameMain");
            SelectProfile selectProfile = new SelectProfile();
            frameData.Content = selectProfile;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupSort());
        }
    }
}