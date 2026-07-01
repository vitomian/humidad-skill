using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace Layout3_Hybrid
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand<string> NavigateCommand { get; }
        public DelegateCommand RefreshCommand { get; }
        public DelegateCommand NotificationCommand { get; }

        private string _statusText = "就绪";
        public string StatusText
        {
            get => _statusText;
            set => SetProperty(ref _statusText, value);
        }

        public MainWindowViewModel()
        {
            NavigateCommand = new DelegateCommand<string>(ExecuteNavigate);
            RefreshCommand = new DelegateCommand(ExecuteRefresh);
            NotificationCommand = new DelegateCommand(ExecuteNotification);
        }

        private void ExecuteNavigate(string viewName)
        {
            StatusText = $"导航到: {viewName}";
            MessageBox.Show($"导航到: {viewName}");
        }

        private void ExecuteRefresh() => StatusText = "正在刷新...";
        private void ExecuteNotification() => StatusText = "显示通知";
    }
}
