using CommunityToolkit.Maui;
using MauiToDoList.App.Extensions.AppBuilder;

namespace MauiToDoList.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .AddFonts()
                .AddPages()
                .UseMauiCommunityToolkit();

            return builder.Build();
        }
    }
}