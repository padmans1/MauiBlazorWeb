using MauiBlazorWeb.Shared.UI;
using Microsoft.Extensions.Logging;
using MauiBlazorWeb.Maui.Services;
using MauiBlazorWeb.Shared.UI.Interfaces;
using Microsoft.Extensions.Configuration;
using MauiBlazorWeb.Shared;

namespace MauiBlazorWeb.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            InteractiveRenderSettings.ConfigureBlazorHybridRenderModes();

            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddHttpClientFactory(builder.Configuration);
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            return builder.Build();
        }
    }
}
