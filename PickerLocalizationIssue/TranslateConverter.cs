using PickerLocalizationIssue.Resources.Localization;
using System.Globalization;

namespace PickerLocalizationIssue;

public class TranslateConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null) return null;

        if (value is string s)
        {
            return AppResources.ResourceManager.GetString(s);
        }

        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
