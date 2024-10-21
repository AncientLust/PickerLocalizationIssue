namespace PickerLocalizationIssue;

public partial class MainPage
{
    public static readonly TranslateConverter TranslateConverter = new TranslateConverter();
    public MainPage(MainPageViewModel mainPageViewModel)
    {
        InitializeComponent();
        BindingContext = mainPageViewModel;

        mainPageViewModel.NotifyLanguagePicked += (s, e) =>
        {
            picker1.ItemDisplayBinding = new Binding("Localization", converter: TranslateConverter);
            picker2.ItemDisplayBinding = new Binding("Localization", converter: TranslateConverter);
        };
    }
}