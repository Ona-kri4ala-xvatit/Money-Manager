using MvvmApp.Mediator.Base;
using MvvmApp.Mediator;
using MvvmApp.ViewModels.Base;
using SimpleInjector;
using System.Windows;
using Money_Manager.ViewModels;

namespace Money_Manager
{
    public partial class App : Application
    {
        public static Container Container { get; set; } = new Container();

        protected override void OnStartup(StartupEventArgs e)
        {
            this.RegisterContainer();

            this.Start<OverviewViewModel>();

            base.OnStartup(e);
        }

        private void Start<T>() where T : ViewModelBase
        {
            var mainView = new MainWindow();
            var mainViewModel = Container.GetInstance<MainViewModel>();
            mainViewModel.ActiveViewModel = Container.GetInstance<T>();

            mainView.DataContext = mainViewModel;

            mainView.ShowDialog();
        }

        private void RegisterContainer()
        {
            //Container.RegisterSingleton<IProductRepository, ProductDapperRepository>();
            //Container.RegisterSingleton<IProductStatusRepository, ProductStatusDapperRepository>();
            Container.RegisterSingleton<IMessenger, Messenger>();

            Container.RegisterSingleton<OverviewViewModel>();
            Container.RegisterSingleton<IncomeViewModel>();
            //Container.RegisterSingleton<CategoriesViewModel>();
            Container.RegisterSingleton<MainViewModel>();

            Container.Verify();
        }

    }
}
