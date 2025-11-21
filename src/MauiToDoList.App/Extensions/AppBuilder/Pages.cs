using CommunityToolkit.Maui;
using MauiToDoList.App.Navigation;
using MauiToDoList.App.Pages.Home.ViewModels;
using MauiToDoList.App.Pages.Home.Views;
using MauiToDoList.App.Pages.OnBoarding.ViewModels;
using MauiToDoList.App.Pages.OnBoarding.Views;

namespace MauiToDoList.App.Extensions.AppBuilder;

public static class Pages
{
    public static MauiAppBuilder AddPages(this MauiAppBuilder appBuilder)
    {

        appBuilder.Services.AddTransient<OnBoardingViewModel>();

        appBuilder.Services.AddTransientWithShellRoute<OnBoardingPage, OnBoardingViewModel>(RoutePages.ONBOARDING_PAGE);
        appBuilder.Services.AddTransientWithShellRoute<HomePage, HomeViewModel>(RoutePages.HOME_PAGE);

        return appBuilder;
    }
}
