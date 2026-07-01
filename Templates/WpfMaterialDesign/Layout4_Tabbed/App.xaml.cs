using System.Windows;

namespace Layout4_Tabbed
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            ShutdownMode = ShutdownMode.OnExplicitShutdown;
            
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }

            var loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            
            if (loginWindow.LoginSuccess)
            {
                var mainWindow = new MainWindow();
                mainWindow.Closed += (s, args) => Current.Shutdown();
                mainWindow.Show();
            }
            else
            {
                Current.Shutdown();
            }
        }
    }
}