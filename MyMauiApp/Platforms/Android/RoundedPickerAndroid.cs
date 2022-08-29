using Android.Content;
using Microsoft.Maui.Controls.Compatibility.Platform.Android.AppCompat;
using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiApp.Platforms.Android
{
    public class RoundedPickerAndroid:PickerRenderer
    {
        public RoundedPickerAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
            }
        }
    }
}
