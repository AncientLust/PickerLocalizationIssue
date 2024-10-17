namespace PickerLocalizationIssue.Primitives;

public class DummyOption
{
    public EDummyOption Option { get; set; }
    public string Localization { get; set; }

    public DummyOption(EDummyOption dummyOption, string localization)
    {
        Option = dummyOption;
        Localization = localization;
    }
}