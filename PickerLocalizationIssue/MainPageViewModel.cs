using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using LocalizationResourceManager.Maui;
using PickerLocalizationIssue.Primitives;
using PickerLocalizationIssue.Resources.Localization;

namespace PickerLocalizationIssue;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private List<LanguageOption> languageOptions;
    [ObservableProperty] private List<DummyOption> dummyOptions;
    [ObservableProperty] private LanguageOption languagePicked;
    [ObservableProperty] private DummyOption dummyPicked;
    
    private readonly ILocalizationResourceManager _resourceManager;
    private readonly bool _isInitialized;
    public event EventHandler NotifyLanguagePicked;

    public MainPageViewModel(ILocalizationResourceManager resourceManager)
    {
        _resourceManager = resourceManager;
        
        LanguageOptions =
        [
            new LanguageOption(ELanguage.Polish, nameof(AppResources.Polish)),
            new LanguageOption(ELanguage.English, nameof(AppResources.English)),
        ];

        LanguagePicked = LanguageOptions.First();

        DummyOptions =
        [
            new DummyOption(EDummyOption.Option1, nameof(AppResources.DummyOption1)),
            new DummyOption(EDummyOption.Option2, nameof(AppResources.DummyOption2)),
        ];

        DummyPicked = DummyOptions.First();
        
        _isInitialized = true;
    }
    
    partial void OnLanguagePickedChanging(LanguageOption value)
    {
        if (!_isInitialized || value is null) return;
        
        switch (value.Language)
        {
            case ELanguage.English:
                _resourceManager.CurrentCulture = new CultureInfo("en");
                NotifyLanguagePicked?.Invoke(this, EventArgs.Empty);
                break;
            case ELanguage.Polish:
                _resourceManager.CurrentCulture = new CultureInfo("pl");
                NotifyLanguagePicked?.Invoke(this, EventArgs.Empty);
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}