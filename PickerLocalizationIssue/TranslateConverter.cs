using System.Globalization;
namespace PickerLocalizationIssue;
public class TranslateConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        => (value is string s) ? PickerLocalizationIssue.Resources.Localization.AppResources.ResourceManager.GetString(s) : null;
    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotImplementedException();
}
