using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace zadaniebebebe;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();

        ThemeSwitch.IsChecked = Application.Current!.ActualThemeVariant == ThemeVariant.Dark;

        ThemeSwitch.IsCheckedChanged += (_, _) =>
            Application.Current!.RequestedThemeVariant =
                ThemeSwitch.IsChecked == true ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}