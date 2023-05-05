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

namespace MobTablet.Table
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActiveTable : ContentView
    {
        public ActiveTable()
        {
            InitializeComponent();

            List<ActiveGoals> activeGoals = new List<ActiveGoals>
            {
                new ActiveGoals { isCounter=true, progressColor = Color.FromHex("#26E27C"), ID = 1, Detail = "Продать 100 кофе + десерт", Coin = 500, Karma = 500, Progress = 0.2, Condition = "qwdqd", Time = "До 31.07" },
                new ActiveGoals { isCounter=true, progressColor = Color.FromHex("#26E27C"), ID = 2, Detail = "Продать 100 кофе + десерт", Coin = 500, Karma = 500, Progress = 0.8, Condition = "qwdqd", Time = "До 31.07" },
                new ActiveGoals { isCounter=true, progressColor = Color.FromHex("#26E27C"), ID = 3, Detail = "Продать 100 кофе + десерт", Coin = 500, Karma = 500, Progress = 0.7, Condition = "qwdqd", Time = "До 31.07" },
                new ActiveGoals { isCounter=true, progressColor = Color.FromHex("#26E27C"), ID = 4, Detail = "Продать 100 кофе + десерт", Coin = 500, Karma = 500, Progress = 0.2, Condition = "qwdqd", Time = "До 31.07" },
                new ActiveGoals { isCounter=true, progressColor = Color.FromHex("#26E27C"), ID = 5, Detail = "Продать 100 кофе + десерт", Coin = 500, Karma = 500, Progress = 1, Condition = "qwdqd", Time = "До 31.07" },
                new ActiveGoals { isCounter=true, progressColor = Color.FromHex("#26E27C"), ID = 6, Detail = "Продать 100 кофе + десерт", Coin = 500, Karma = 500, Progress = 0.9, Condition = "qwdqd", Time = "До 31.07" },
                new ActiveGoals { isCounter=true, progressColor = Color.FromHex("#26E27C"), ID = 7, Detail = "Продать 100 кофе + десерт", Coin = 500, Karma = 500, Progress = 0.1, Condition = "qwdqd", Time = "До 31.07" },
                new ActiveGoals { isCounter=true, progressColor = Color.FromHex("#26E27C"), ID = 8, Detail = "Продать 100 кофе + десерт", Coin = 500, Karma = 500, Progress = 0.32, Condition = "qwdqd", Time = "До 31.07" },
                new ActiveGoals { isCounter=true, progressColor = Color.FromHex("#26E27C"), ID = 9, Detail = "Продать 100 кофе + десерт", Coin = 500, Karma = 500, Progress = 0.63, Condition = "qwdqd", Time = "До 31.07" },
            };
            MyListView.ItemsSource = activeGoals;
            MyListView.ItemTapped += MyListView_ItemTapped;
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.ShowPopup(new PopupContest());
        }
    }
}