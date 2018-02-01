using Microsoft.Practices.Unity;
using Prism.Unity;
using System.Windows;
using StockTrader.Views;

namespace StockTrader
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
