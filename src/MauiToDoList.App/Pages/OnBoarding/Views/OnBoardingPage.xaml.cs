using MauiToDoList.App.Pages.OnBoarding.ViewModels;

namespace MauiToDoList.App.Pages.OnBoarding.Views;

public partial class OnBoardingPage : ContentPage
{
    public OnBoardingPage(OnBoardingViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}