using MauiToDoList.App.Pages.Home.ViewModels;

namespace MauiToDoList.App.Pages.Home.Views;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}