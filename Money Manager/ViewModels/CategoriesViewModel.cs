using Money_Manager.Models;
using Money_Manager.Repositories.Base;
using Money_Manager.Services;
using MvvmApp.Commands.Base;
using MvvmApp.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Money_Manager.ViewModels
{
    public class CategoriesViewModel : ViewModelBase
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly SharedDataCategories sharedDataCategories;

        public static ObservableCollection<string> Icons { get; set; } = new ObservableCollection<string>()
        {
           "BabyFaceOutline", "Badminton", "BacteriaOutline", "BasketFill",
           "BankOutline", "BathtubOutline", "BedSingle","Billboard","BottleTonicPlus","BottleWineOutline",
           "BowlMixOutline","BusDoubleDecker","FaceWomanOutline", "CakeVariantOutline","CandelabraFire","Campfire",
           "CarConvertible","CardsHeart","CardsPlayingSpadeMultiple","Cart","Cat","Charity","SackPercent",
           "ChessQueen","Church","Cigar","HomeHeart","PaletteOutline","FormatPaint","GiftOpenOutline",
           "Basketball","SchoolOutline","CoffeeOutline","FaceWoman","BottleTonicPlusOutline","Lipstick","HandCoinOutline",
           "CurrencyUsd", "CreditCard", "Dog", "DogService", "Laptop", "PercentOutline", "Gift", "GiftOpen", "Home"
        };

        #region Properties
        public ObservableCollection<Category> IncomeCategories { get; }
        public ObservableCollection<Category> ExpensesCategories { get; }

        private Category? selectedCategory;
        public Category? SelectedCategory { get => selectedCategory; set => base.PropertyChangeMethod(out selectedCategory, value); }

        private string? selectedIcon;
        public string? SelectedIcon
        {
            get => selectedIcon;
            set => base.PropertyChangeMethod(out selectedIcon, value);   
        }

        private string? categoryName;
        public string? CategoryName
        {
            get => categoryName;
            set => base.PropertyChangeMethod(out categoryName, value);

        }

        private TransactionType type;
        public TransactionType Type
        {
            get => type;
            set => base.PropertyChangeMethod(out type, value);
        }
        #endregion

        #region Command
        private CommandBase? saveCategoryCommand;
        public CommandBase? SaveCategoryCommand => this.saveCategoryCommand ??= new CommandBase(
            () =>
            {
                if (!string.IsNullOrEmpty(categoryName) && Icons.Count != 0)
                {
                    categoryRepository.CreateCategory(new Category()
                    {
                        CategoryName = this.CategoryName,
                        Icon = this.SelectedIcon,
                        TransactionType = this.Type
                    });
                    this.CategoryName = string.Empty;
                    GetIncomeCategories();
                    GetExpensesCategories();
                }
            },
            () => true);

        private CommandBase? deleteCategoryCommand;
        public CommandBase? DeleteCategoryCommand => this.deleteCategoryCommand ??= new CommandBase(
            () =>
            {
                if (SelectedCategory is not null)
                {
                    categoryRepository.DeleteCategory(SelectedCategory.Id);
                }
                GetIncomeCategories();
                GetExpensesCategories();
            },
            () => true);
        #endregion

        public CategoriesViewModel(ICategoryRepository categoryRepository, SharedDataCategories sharedDataCategories)
        {
            this.sharedDataCategories = sharedDataCategories;

            this.IncomeCategories = sharedDataCategories.IncomeCategories;
            this.ExpensesCategories = sharedDataCategories.ExpensesCategories;

            this.categoryRepository = categoryRepository;

            GetIncomeCategories();
            GetExpensesCategories();
        }

        private void GetIncomeCategories()
        {
            IncomeCategories.Clear();
            var categories = categoryRepository.GetIncomeCategories();

            foreach (var category in categories)
            {
                IncomeCategories.Add(category);
            }
        }

        private void GetExpensesCategories()
        {
            ExpensesCategories.Clear();
            var categories = categoryRepository.GetExpensesCategories();

            foreach (var category in categories)
            {
                ExpensesCategories.Add(category);
            }
        }

    }
}
