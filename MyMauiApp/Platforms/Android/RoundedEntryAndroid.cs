using Android.Content;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using MyMauiApp.Platforms.Android;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics.Platform;

namespace MyMauiApp.Platforms.Android
{

    public class RoundedEntryAndroid : EntryRenderer
    {
        public RoundedEntryAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);

            }
        }
    }
}
