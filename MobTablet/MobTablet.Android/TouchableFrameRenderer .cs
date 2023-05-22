using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Views;
using MobTablet;
using MobTablet.CustomControls;
using MobTablet.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomMenuButton), typeof(TouchableFrameRenderer))]
namespace MobTablet.Droid
{
    class TouchableFrameRenderer: ViewRenderer
    {
        public TouchableFrameRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);
            var touchableRelativeLayout = e.NewElement as CustomMenuButton;

            var thisView = this;
            thisView.Touch += (object sender, TouchEventArgs args) =>
            {
                if (args.Event.Action == MotionEventActions.Down)
                {
                    touchableRelativeLayout.OnPressed();
                }

                else if (args.Event.Action == MotionEventActions.Up || args.Event.Action == MotionEventActions.Move)
                {
                    touchableRelativeLayout.OnReleased();
                }
            };
        }
    }
}