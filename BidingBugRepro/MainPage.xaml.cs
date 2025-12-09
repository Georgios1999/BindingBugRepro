using BindingBugRepro.Models;
using Windows.System;

namespace BidingBugRepro;

public sealed partial class MainPage : Page
{
    public AppModel Model { get; } = new();

    public MainPage()
    {
        this.InitializeComponent();
        this.DataContext = Model;
    }

    private async void IssueLinkButton_Click(object sender, RoutedEventArgs e)
    {
        await Launcher.LaunchUriAsync(new Uri("https://github.com/unoplatform/uno/issues/22068"));
    }

    private async void RepoLinkButton_Click(object sender, RoutedEventArgs e)
    {
        await Launcher.LaunchUriAsync(new Uri("https://github.com/Georgios1999/BindingBugRepro.git"));
    }
}
