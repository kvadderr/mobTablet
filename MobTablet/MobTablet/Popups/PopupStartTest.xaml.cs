using MobTablet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobTablet.Popups
{    public partial class PopupStartTest : Popup
    {
        public PopupStartTest()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var frameData = Parent.FindByName<Frame>("myFrameMain");
            TestItem testResult = new TestItem();
            frameData.Content = testResult;
        }
    }
}