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
	public partial class Notification : ContentView
	{
		public Notification ()
		{
			InitializeComponent ();
			NotificationList notificationList = new NotificationList();
			notFrame.Content = notificationList;

		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            NotificationList notificationList = new NotificationList();
            notFrame.Content = notificationList;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            NewsList notificationList = new NewsList();
            notFrame.Content = notificationList;
        }
    }
}