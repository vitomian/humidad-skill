using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace Layout2_TopNav
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly LoginWindow _loginWindow;

        [ObservableProperty]
        private string _username = "";

        [ObservableProperty]
        private string _password = "";

        public IRelayCommand LoginCommand { get; }

        public LoginViewModel(LoginWindow loginWindow)
        {
            _loginWindow = loginWindow;
            LoginCommand = new RelayCommand(ExecuteLogin);
        }

        private void ExecuteLogin()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("请输入账号和密码", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (var db = new AppDbContext())
            {
                if (!db.Users.Any())
                {
                    db.Users.Add(new User { Username = "123", Password = "123" });
                    db.SaveChanges();
                }

                var user = db.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);
                
                if (user != null)
                {
                    _loginWindow.OnLoginSuccess();
                }
                else
                {
                    MessageBox.Show("账号或密码错误", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}