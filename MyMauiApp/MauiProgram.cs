
using MyMauiApp.Controls;
using MyMauiApp.Data;
using Microsoft.Maui;
using Microsoft.Maui.Accessibility;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Xaml;
using MyMauiApp.Views;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MyMauiApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCompatibility()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .ConfigureMauiHandlers((handlers) => {
#if __ANDROID__
                handlers.AddCompatibilityRenderer(typeof(RoundedEntry), typeof(MyMauiApp.Platforms.Android.RoundedEntryAndroid));
                handlers.AddCompatibilityRenderer(typeof(RoundedPicker), typeof(MyMauiApp.Platforms.Android.RoundedPickerAndroid));

#endif



            })
            
            ;
        builder.Services.AddSingleton<RegisterTable>();
        Routing.RegisterRoute("login", typeof(SignUp));
        

        return builder.Build();
    }
}
