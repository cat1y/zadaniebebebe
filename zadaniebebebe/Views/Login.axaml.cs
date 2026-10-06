using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace zadaniebebebe;

public partial class Login : UserControl
{

    public event EventHandler? LoggedIn;
    public Login() => InitializeComponent();
    private void Login_Click(object? sender, RoutedEventArgs e) => LoggedIn?.Invoke(this, EventArgs.Empty);
}