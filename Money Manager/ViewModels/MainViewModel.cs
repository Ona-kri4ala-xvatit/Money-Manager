using MvvmApp.Commands.Base;
using MvvmApp.Mediator.Base;
using MvvmApp.Messages;
using MvvmApp.ViewModels.Base;

namespace Money_Manager.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields
        private bool flag = false;
        private readonly IMessenger messenger;

        private ViewModelBase activeViewModel;

        public ViewModelBase ActiveViewModel
        {
            get => activeViewModel;
            set => base.PropertyChangeMethod(out activeViewModel, value);
        }
        #endregion

        #region Commands
        private CommandBase overviewCommand;
        public CommandBase OverviewCommand => this.overviewCommand ??= new CommandBase(
            execute: () => this.ActiveViewModel = App.Container.GetInstance<OverviewViewModel>(),
            canExecute: () => !this.flag);

        private CommandBase incomeCommand;
        public CommandBase IncomeCommand => this.incomeCommand ??= new CommandBase(
            execute: () => this.ActiveViewModel = App.Container.GetInstance<IncomeViewModel>(),
            canExecute: () => !this.flag);

        private CommandBase categoriesCommand;
        public CommandBase CategoriesCommand => this.categoriesCommand ??= new CommandBase(
            execute: () => this.ActiveViewModel = App.Container.GetInstance<CategoriesViewModel>(),
            canExecute: () => !this.flag);

        private CommandBase expensesCommand;
        public CommandBase ExpensesCommand => this.expensesCommand ??= new CommandBase(
            execute: () => this.ActiveViewModel = App.Container.GetInstance<ExpensesViewModel>(),
            canExecute: () => !this.flag);

        private CommandBase accountsCommand;
        public CommandBase AccountsCommand => this.accountsCommand ??= new CommandBase(
            execute: () => this.ActiveViewModel = App.Container.GetInstance<AccountsViewModel>(),
            canExecute: () => !this.flag);
        #endregion

        public MainViewModel(IMessenger messenger)
        {
            this.messenger = messenger;

            this.messenger.Subscribe<NavigationMessage>((message) =>
            {
                if (message is NavigationMessage navigationMessage)
                {
                    this.ActiveViewModel = navigationMessage.DestinationViewModel;
                }
            });
        }
    }
}
