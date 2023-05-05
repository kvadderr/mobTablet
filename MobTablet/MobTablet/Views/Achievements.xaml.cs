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
    public partial class Achievements : ContentView
    {
        public Achievements()
        {
            InitializeComponent();
            AchievementsList achievementsList = new AchievementsList();
            achievementsFrame.Content = achievementsList;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            AchievementsList achievementsList = new AchievementsList();
            achievementsFrame.Content = achievementsList;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            AchievementsUserProfiles achievementsUserProfiles = new AchievementsUserProfiles();
            achievementsFrame.Content = achievementsUserProfiles;
        }
    }
}