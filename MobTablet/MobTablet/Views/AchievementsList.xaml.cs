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
	public partial class AchievementsList : ContentView
	{
		public AchievementsList ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
			Navigation.ShowPopup(new PopupAchievements());
        }
    }
}