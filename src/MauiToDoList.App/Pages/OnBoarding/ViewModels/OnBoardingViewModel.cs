using CommunityToolkit.Mvvm.Input;
using MauiToDoList.App.Bases;
using MauiToDoList.App.Navigation;

namespace MauiToDoList.App.Pages.OnBoarding.ViewModels;

public partial class OnBoardingViewModel : ViewModelBase
{
    [RelayCommand]
    public async Task GoToHomePage()
    {
        await Shell.Current.GoToAsync(RoutePages.HOME_PAGE);
    }
}
