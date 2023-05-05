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
    public partial class Library : ContentView
    {
        public Library()
        {
            InitializeComponent();
        }

        private void goToArticle(object sender, EventArgs e)
        {
            Article article= new Article();
            LibraryFrame.Content = article;
        }
    }
}