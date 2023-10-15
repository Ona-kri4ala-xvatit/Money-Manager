using MvvmApp.Mediator.Base;
using MvvmApp.Mediator;
using MvvmApp.ViewModels.Base;
using SimpleInjector;
using System.Windows;
using Money_Manager.ViewModels;
using Money_Manager.Context;
using Money_Manager.Repositories.Base;
using Money_Manager.Repositories;
using Money_Manager.Converters;
using Money_Manager.Services;

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
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<IAccountRepository, AccountEFRepository>();
            Container.RegisterSingleton<IIncomeRepository, IncomeEFRepository>();
            Container.RegisterSingleton<ICategoryRepository, CategoryEFRepository>();

            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<OverviewViewModel>();
            Container.RegisterSingleton<IncomeViewModel>();
            Container.RegisterSingleton<ExpensesViewModel>();
            Container.RegisterSingleton<AccountsViewModel>();
            Container.RegisterSingleton<CategoriesViewModel>();

            Container.RegisterSingleton<MoneyManagerDbContext>();

            Container.RegisterSingleton<SharedDataCategories>();
            Container.RegisterSingleton<SharedDataAccounts>();
            Container.Verify();
        }

    }
}
