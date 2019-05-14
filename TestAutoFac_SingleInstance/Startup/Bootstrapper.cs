using Autofac;
using TestAutoFac_SingleInstance.Models;
using TestAutoFac_SingleInstance.ViewModels;
using TestAutoFac_SingleInstance.Views;

namespace TestAutoFac_SingleInstance.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap(MyClassList myClassList)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainView>().AsSelf();

            //register viewmodels
            builder.RegisterType<MainViewModel>().As<IMainViewModel>();
            builder.RegisterType<ViewModelA>().As<IViewModelA>();
            builder.RegisterType<ViewModelB>().As<IViewModelB>();

            //register models
            //fake data
            builder.RegisterInstance<MyClassList>(myClassList);
            //builder.RegisterType<MyClassList>().AsSelf().SingleInstance();

            return builder.Build();
        }
    }
}
