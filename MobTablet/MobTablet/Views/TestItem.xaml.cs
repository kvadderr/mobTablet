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
	public partial class TestItem : ContentView
	{
		public TestItem ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
			firstFrame.BackgroundColor = Color.FromHex("#dfdcfe");
            secondFrame.BackgroundColor = Color.Transparent;
            thirdFrame.BackgroundColor = Color.Transparent;
            fourFrame.BackgroundColor = Color.Transparent;
            fiveFrame.BackgroundColor = Color.Transparent;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            firstFrame.BackgroundColor = Color.Transparent;
            secondFrame.BackgroundColor = Color.FromHex("#dfdcfe");
            thirdFrame.BackgroundColor = Color.Transparent;
            fourFrame.BackgroundColor = Color.Transparent;
            fiveFrame.BackgroundColor = Color.Transparent;
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            firstFrame.BackgroundColor = Color.Transparent;
            secondFrame.BackgroundColor = Color.Transparent;
            thirdFrame.BackgroundColor = Color.FromHex("#dfdcfe");
            fourFrame.BackgroundColor = Color.Transparent;
            fiveFrame.BackgroundColor = Color.Transparent;
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            firstFrame.BackgroundColor = Color.Transparent;
            secondFrame.BackgroundColor = Color.Transparent;
            thirdFrame.BackgroundColor = Color.Transparent;
            fourFrame.BackgroundColor = Color.FromHex("#dfdcfe");
            fiveFrame.BackgroundColor = Color.Transparent;
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            firstFrame.BackgroundColor = Color.Transparent;
            secondFrame.BackgroundColor = Color.Transparent;
            thirdFrame.BackgroundColor = Color.Transparent;
            fourFrame.BackgroundColor = Color.Transparent;
            fiveFrame.BackgroundColor = Color.FromHex("#dfdcfe");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var frameData = Parent.FindByName<Frame>("myFrameMain");
            TestResult testResult = new TestResult();
            frameData.Content = testResult;
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopupCancel());
        }
    }
}