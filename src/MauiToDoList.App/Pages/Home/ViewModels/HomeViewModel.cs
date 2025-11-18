using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiToDoList.App.Bases;
using MauiToDoList.App.Pages.Home.Models;

namespace MauiToDoList.App.Pages.Home.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    [ObservableProperty]
    public HomeModel model;

    public HomeViewModel()
    {
        Model = new();
    }

    [RelayCommand]
    public void InsertTitle()
    {
        Model.Title = "Hello, MAUI!";
    }
}
