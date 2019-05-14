using Autofac;
using System.Windows;
using TestAutoFac_SingleInstance.Models;
using TestAutoFac_SingleInstance.Startup;
using TestAutoFac_SingleInstance.Views;

namespace TestAutoFac_SingleInstance
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MyClassList myClassList = new MyClassList();
            var bs = new Bootstrapper();
            var container = bs.Bootstrap(myClassList);
            var mainView = container.Resolve<MainView>();
            mainView.ShowDialog();
        }
    }
}
