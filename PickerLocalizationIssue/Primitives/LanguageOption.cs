namespace PickerLocalizationIssue.Primitives;

public class LanguageOption
{
    public ELanguage Language { get; set; }
    public string Localization { get; set; }

    public LanguageOption(ELanguage language, string localization)
    {
        Language = language;
        Localization = localization;
    }
}