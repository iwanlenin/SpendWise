using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;
using SpendWise.Helpers.Services;
using SpendWise.ViewModels;
using SpendWise.Views;

namespace SpendWise
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit by adding the below line of code
                .UseMauiCommunityToolkit()
                
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            

            // Pages
            builder.Services.AddTransient<AddExpensePage>();

            // ViewModels
            builder.Services.AddTransient<MainPageViewModel>();

            // Services
            //builder.Services.AddSingleton<ILocalizationService>();

            //builder.Services.Add<LocalizationService>();
            //Interfaces
            

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
