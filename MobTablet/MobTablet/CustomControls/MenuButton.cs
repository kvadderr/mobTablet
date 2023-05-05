using MobTablet.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobTablet.CustomControls
{
    class MenuButton : Frame
    {
        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(MenuButton), default(string));
        public static readonly BindableProperty PlaceholderColorProperty = BindableProperty.Create(nameof(PlaceholderColor), typeof(Color), typeof(MenuButton), Color.Default);
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(MenuButton), default(ImageSource));
        public static readonly BindableProperty ImageHeightRequestProperty = BindableProperty.Create(nameof(ImageHeightRequest), typeof(double), typeof(MenuButton), 40.0);
        public static readonly BindableProperty ImageWidthRequestProperty = BindableProperty.Create(nameof(ImageWidthRequest), typeof(double), typeof(MenuButton), 40.0);
        public static readonly BindableProperty ImageSpacingProperty = BindableProperty.Create(nameof(ImageSpacing), typeof(double), typeof(MenuButton), 5.0);
        public static readonly BindableProperty LabelTextData = BindableProperty.Create(nameof(LabelText), typeof(string), typeof(MenuButton), "default");
        public static readonly BindableProperty LabelFontSize = BindableProperty.Create(nameof(LabelTextSize), typeof(int), typeof(MenuButton), 16);
        public static readonly BindableProperty goToPage = BindableProperty.Create(nameof(PageData), typeof(string), typeof(MenuButton), string.Empty);

        public MenuButton()
        {
            Achievements achievements = new Achievements();
            Home home = new Home();

            var entry = new Entry();

            entry.SetBinding(Entry.PlaceholderProperty, new Binding(nameof(Placeholder), source: this));
            entry.SetBinding(Entry.PlaceholderColorProperty, new Binding(nameof(PlaceholderColor), source: this));

            var label = new Label();
            label.SetBinding(Label.TextProperty, new Binding(nameof(LabelText), source: this));
            label.SetBinding(Label.FontSizeProperty, new Binding(nameof(LabelTextSize), source: this));
            label.Style = (Style)App.Current.Resources["RegularText"];
            label.VerticalOptions = LayoutOptions.Center;

            var image = new Image();
            image.SetBinding(Image.SourceProperty, new Binding(nameof(ImageSource), source: this));
            image.VerticalOptions = LayoutOptions.Center;
            image.HorizontalOptions = LayoutOptions.Center;



            var imageStackLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = { image },
            };


            var frame = new Frame();
            frame.WidthRequest = 18;
            frame.HeightRequest = 18;
            frame.CornerRadius = 12;
            frame.Margin = 7;
            frame.Padding = 0;
            frame.HasShadow = false;
            frame.BackgroundColor = Color.Transparent; //(Brush)App.Current.Resources["blockGradient"];
            frame.HorizontalOptions = LayoutOptions.Center;
            frame.VerticalOptions = LayoutOptions.Center;
            
            frame.Content = imageStackLayout;

            var stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Spacing = ImageSpacing,
                Children = { frame, label },
                BackgroundColor = Color.Transparent,
            };

            var tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.Tapped += async (s, e) =>
            {
                System.Diagnostics.Debug.WriteLine("CLICK");
                VisualStateManager.GoToState(stackLayout, "Pressed");
                var menuStackLayout = App.Current.MainPage.FindByName<StackLayout>("MenuStackLayout");
                var frameData = App.Current.MainPage.FindByName<Frame>("myFrame");

                switch (goToPage)
                {
               

                }

                foreach(var child in menuStackLayout.Children)
                {
                    System.Diagnostics.Debug.WriteLine("dadad");
                    VisualStateManager.GoToState(child, "Normal");
                }
                
                frameData.Content = achievements;

            };


            //stackLayout.GestureRecognizers.Add(tapGestureRecognizer);

            var mainFrame = new Frame();
            mainFrame.Content = stackLayout;
            mainFrame.CornerRadius = 12;
            mainFrame.Padding = 0;
            mainFrame.HasShadow = false;

            Content = mainFrame;
        }

        public string PageData
        {
            get { return (string)GetValue(goToPage); }
            set { SetValue(goToPage, value); }
        }

        public string LabelText
        {
            get { return (string)GetValue(LabelTextData); }
            set { SetValue(LabelTextData, value); }
        }

        public int LabelTextSize
        {
            get { return (int)GetValue(LabelFontSize); }
            set { SetValue(LabelFontSize, value); }
        }

        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        public Color PlaceholderColor
        {
            get { return (Color)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }

        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public double ImageHeightRequest
        {
            get { return (double)GetValue(ImageHeightRequestProperty); }
            set { SetValue(ImageHeightRequestProperty, value); }
        }

        public double ImageWidthRequest
        {
            get { return (double)GetValue(ImageWidthRequestProperty); }
            set { SetValue(ImageWidthRequestProperty, value); }
        }

        public double ImageSpacing
        {
            get { return (double)GetValue(ImageSpacingProperty); }
            set { SetValue(ImageSpacingProperty, value); }
        }

    }
}
