using CommunityToolkit.Mvvm.ComponentModel;
using MauiToDoList.App.Enums;

namespace MauiToDoList.App.Bases;

public abstract partial class ViewModelBase : ObservableObject
{
    [ObservableProperty]
    public StatusPageEnum statusPage;

    protected ViewModelBase()
    {
        StatusPage = StatusPageEnum.Default;
    }
}
