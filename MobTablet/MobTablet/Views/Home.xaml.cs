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
    public partial class Home : ContentView
    {
        public Home()
        {
            InitializeComponent();
            Goals goals = new Goals();  
            myFrame.Content = goals;
        }
        private void openPopupContest(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupPrize());
        }
    }
}