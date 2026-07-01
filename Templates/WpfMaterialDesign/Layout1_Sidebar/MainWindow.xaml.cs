using System.Windows;

namespace Layout1_Sidebar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as System.Windows.Controls.Button;
            if (button != null)
            {
                var viewModel = DataContext as MainWindowViewModel;
                viewModel?.ExecuteNavigate(button.Tag?.ToString());
            }
        }
    }
}