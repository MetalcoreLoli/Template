using System;
using System.Globalization;
using Template.Models.DataModels;
using Template.Views.Pages;

namespace Template.Models.ValueConverters
{
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (ApplicationPage) value switch
            {
                ApplicationPage.Login => new LoginPage(),
                ApplicationPage.ManagerMain => new ManagerPage(),
                //_ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
                _ => null 
            };
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}