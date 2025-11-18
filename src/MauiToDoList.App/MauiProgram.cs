using MauiToDoList.App.Extensions;

namespace MauiToDoList.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .AddFonts();

            return builder.Build();
        }
    }
}
