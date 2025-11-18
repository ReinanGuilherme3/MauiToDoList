using MauiToDoList.App.Constants;

namespace MauiToDoList.App.Extensions;

public static class Fonts
{
    public static void AddFonts(this MauiAppBuilder builder)
    {
        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("Poppins-Black.ttf", FontFamily.POPPINS_BLACK);
            fonts.AddFont("Poppins-Regular.ttf", FontFamily.POPPINS_REGULAR);
            fonts.AddFont("Poppins-Thin.ttf", FontFamily.POPPINS_THIN);
        });
    }
}
