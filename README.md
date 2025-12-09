# Binding Bug Reproduction Repository
This contains the app you can use to debug the MVUX binding bug.

Project specs:
- Made in Visual Studio 2026
- MVUX selected
- .NET 10
- Fluent Design (WinUI) picked
- Navigation set to None (in the setup—I didn't choose Regions)

## Running and testing:
> [!NOTE]
> You might need to adjust some Debug and Output settings in Visual Studio (like Output logging verbosity) to see the error or find useful information.

### `AppModel.cs`
The minimal application MVUX ViewModel, with an example variable.

### `MainPage.xaml` and `MainPage.xaml.cs`
The page where the bound value from the variable in `AppModel` should show (in the button).
