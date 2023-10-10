using Money_Manager.Services;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Money_Manager.Converters
{
    public class TransactionTypeToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((TransactionType)value == TransactionType.Expenses) return true;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value == false) return TransactionType.Income;
            return TransactionType.Expenses;
        }
    }
}
