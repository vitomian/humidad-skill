using System.Windows;
using System.Windows.Controls;

namespace Layout2_TopNav
{
    public partial class LoginWindow : Window
    {
        public bool LoginSuccess { get; private set; }
        private LoginViewModel ViewModel => DataContext as LoginViewModel;

        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel(this);
        }

        public void OnLoginSuccess()
        {
            LoginSuccess = true;
            Close();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (ViewModel != null)
            {
                ViewModel.Password = (sender as PasswordBox)?.Password ?? string.Empty;
            }
        }
    }
}