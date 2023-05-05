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
	public partial class Messanger : ContentView
	{
		public Messanger ()
		{
			InitializeComponent ();
            List<Dialogs> profileRaitings = new List<Dialogs>
            {
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=true, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=true, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=true, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=true},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
               new Dialogs { FIO = "Анна Горякова", Message="Спасибо! Это приятно слышать", isIdea=false, isUnread=false},
            };

            MyListView.ItemsSource = profileRaitings;
        }

        private void MyListView_Scrolled(object sender, ScrolledEventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupSendIdea());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupSendMessage());
        }
    }
}