﻿using Money_Manager.Models;
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
        public static ObservableCollection<string> Icons { get; set; } = new ObservableCollection<string>()
        {
           "BabyFaceOutline", "Badminton", "BacteriaOutline", "BasketFill",
           "BankOutline", "BathtubOutline", "BedSingle","Billboard","BottleTonicPlus","BottleWineOutline",
           "BowlMixOutline","BusDoubleDecker","CakeVariantOutline","CandelabraFire","Campfire",
           "CarConvertible","CardsHeart","CardsPlayingSpadeMultiple","Cart","Cat","Charity","SackPercent",
           "ChessQueen","Church","Cigar","HomeHeart","PaletteOutline","FormatPaint","GiftOpenOutline",
           "Basketball","SchoolOutline","CoffeeOutline","BottleTonicPlusOutline","Lipstick","HandCoinOutline",
           "CurrencyUsd", "CreditCard", "Dog", "DogService", "Laptop", "PercentOutline", "Gift", "GiftOpen", "Home"
        };

        #region Properties
        private string? selectedIcon;
        public string? SelectedIcon
        {
            get => selectedIcon; 
            set 
            {
                base.PropertyChangeMethod(out selectedIcon, value);
            }
        }

        private string? categoryName;
        public string? CategoryName {
            get => categoryName; 
            set
            {
                base.PropertyChangeMethod(out categoryName, value);
            }
        }

        private TransactionType type;
        public TransactionType Type
        {
            get => type;
            set
            {
                base.PropertyChangeMethod(out type, value);
            }
        }
        #endregion

        #region Command
        private CommandBase? saveCategoryCommand;
        public CommandBase? SaveCategoryCommand => this.saveCategoryCommand ??= new CommandBase(
            () => 
            {
                categoryRepository.CreateCategory(new Category()
                {
                    CategoryName = this.CategoryName,
                    Icon = this.SelectedIcon,
                    TransactionType = this.Type
                });
                this.CategoryName = string.Empty;
            }, 
            () => true);
        #endregion

        public CategoriesViewModel(ICategoryRepository categoryRepository) 
        {
            this.categoryRepository = categoryRepository;
        }

    }
}
