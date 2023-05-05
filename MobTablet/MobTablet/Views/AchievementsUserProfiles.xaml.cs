using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobTablet.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AchievementsUserProfiles : ContentView
	{
		public AchievementsUserProfiles ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var frameData = App.Current.MainPage.FindByName<Frame>("achievementsFrame");
            AchievementsUserList achievementsUserList = new AchievementsUserList();
            frameData.Content = achievementsUserList;
        }
    }
}