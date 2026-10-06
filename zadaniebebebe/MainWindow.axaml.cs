using Avalonia.Controls;

namespace zadaniebebebe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowLogin();
        }

        private void ShowLogin()
        {
            var login = new Login();
            login.LoggedIn += (_, _) => ShowShell();
            Root.Content = login;
        }

        private void ShowShell()
        {
            var shell = new ShellView();
            shell.LoggedOut += (_, _) => ShowLogin();
            Root.Content = shell;
        }
    }
}