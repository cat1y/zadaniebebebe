using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Linq;

namespace zadaniebebebe;

public partial class ShellView : UserControl
{
    public event EventHandler? LoggedOut;

    public ShellView()
    {
        InitializeComponent();
        Navigate("overview");
    }

    private void Nav_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Button b && b.Tag is string key) Navigate(key);
    }

    private void Navigate(string key)
    {
        PageHost.Content = key switch
        {
            "projects" => new ProjectsView(),
            "tasks" => new TasksView(),
            "calendar" => new CalendarView(),
            "team" => new TeamView(),
            "settings" => new SettingsView(),
            "profile" => new ProfileView(),
            _ => new OverviewView()
        };

        foreach (var b in NavPanel.Children.OfType<Button>())
            b.Classes.Set("active", (string?)b.Tag == key);
        ProfileBtn.Classes.Set("active", key == "profile");
    }

    private void Logout_Click(object? sender, RoutedEventArgs e) => LoggedOut?.Invoke(this, EventArgs.Empty);
}