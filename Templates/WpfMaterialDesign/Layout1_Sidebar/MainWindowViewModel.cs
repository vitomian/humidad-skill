using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Layout1_Sidebar
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public void ExecuteNavigate(string viewName)
        {
            MessageBox.Show($"Navigate to: {viewName}");
        }

        public void ExecuteRefresh()
        {
            MessageBox.Show("Refresh content");
        }

        public void ExecuteNotification()
        {
            MessageBox.Show("Show notifications");
        }

        public void ExecuteUser()
        {
            MessageBox.Show("User settings");
        }
    }
}