using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace Layout2_TopNav
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand FileCommand { get; }
        public DelegateCommand EditCommand { get; }
        public DelegateCommand ViewCommand { get; }
        public DelegateCommand HelpCommand { get; }
        public DelegateCommand SearchCommand { get; }

        public MainWindowViewModel()
        {
            FileCommand = new DelegateCommand(ExecuteFile);
            EditCommand = new DelegateCommand(ExecuteEdit);
            ViewCommand = new DelegateCommand(ExecuteView);
            HelpCommand = new DelegateCommand(ExecuteHelp);
            SearchCommand = new DelegateCommand(ExecuteSearch);
        }

        private void ExecuteFile() => MessageBox.Show("文件菜单");
        private void ExecuteEdit() => MessageBox.Show("编辑菜单");
        private void ExecuteView() => MessageBox.Show("视图菜单");
        private void ExecuteHelp() => MessageBox.Show("帮助菜单");
        private void ExecuteSearch() => MessageBox.Show("搜索功能");
    }
}
