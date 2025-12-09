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

    private void IssueLinkButton_Click(object sender, RoutedEventArgs e)
    {
        // TODO: Update with issue link after pushing and sending the issue.
        Launcher.LaunchUriAsync(new Uri("https://www.google.com"));
    }
}
