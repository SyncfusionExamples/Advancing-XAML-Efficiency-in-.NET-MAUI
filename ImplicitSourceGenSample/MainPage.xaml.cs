using ImplicitSourceGenSample.ViewModels;

namespace ImplicitSourceGenSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}