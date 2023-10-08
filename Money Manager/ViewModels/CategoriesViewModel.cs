using MvvmApp.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Money_Manager.ViewModels
{
    public class CategoriesViewModel : ViewModelBase
    {
        public static ObservableCollection<string> Icons { get; set; } = new ObservableCollection<string>()
        {
           "BabyFaceOutline", "Badminton", "BacteriaOutline", "BasketFill",
           "BankOutline", "BathtubOutline", "BedSingle","Billboard","BottleTonicPlus","BottleWineOutline",
           "BowlMixOutline","BusDoubleDecker","CakeVariantOutline","CandelabraFire","Campfire",
           "CarConvertible","CardsHeart","CardsPlayingSpadeMultiple","Cart","Cat","Charity","SackPercent",
           "ChessQueen","Church","Cigar","HomeHeart","PaletteOutline","FormatPaint","GiftOpenOutline",
           "Basketball","SchoolOutline","CoffeeOutline","BottleTonicPlusOutline","Lipstick","HandCoinOutline"
        };


    }
}
