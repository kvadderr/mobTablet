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
    public partial class Shop : ContentView
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupViewProduct());
            Navigation.ShowPopup(new PopupConfirmation());
            Navigation.ShowPopup(new PopupConfirm());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupMyOrder());
            Navigation.ShowPopup(new PopupEmpty());
        }
    }
}