using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("SpaceGrotesk-Bold.ttf", "SpaceGrotesk-Bold");
                    fonts.AddFont("SpaceGrotesk-Light.ttf", "SpaceGrotesk-Light");
                    fonts.AddFont("SpaceGrotesk-Medium.ttf", "SpaceGrotesk-Medium");
                    fonts.AddFont("SpaceGrotesk-SemiBold.ttf", "SpaceGrotesk-SemiBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
