using Syncfusion.Licensing;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace GayHub
{ 
    [Preserve(AllMembers = true)]
    public class AppSettings
    {
        private readonly OSAppTheme currentTheme;
         
        private bool isDarkTheme;

        private int selectedPrimaryColor;
          
        static AppSettings()
        {
            Instance = new AppSettings();
        }

        private AppSettings()
        { 
            this.currentTheme = App.Current.RequestedTheme;
            this.selectedPrimaryColor = this.currentTheme == OSAppTheme.Light ? 0 : 1;
        }

        public static AppSettings Instance { get; }
         
        public static string AndroidSecretCode => "88dda0e2-da50-466e-9aa5-36fc504d9ed3";
         
        public static string IOSSecretCode => "b327e367-8f04-4efe-ad7a-85be8c828ec3";
         
        public static string UWPSecretCode => "ca0577ad-4cd2-4258-a35b-465e8f4669d9";
         
        public bool IsDarkTheme
        {
            get => this.isDarkTheme;
            set
            {
                if (this.isDarkTheme == value)
                    return;

                this.isDarkTheme = value;
                if (this.isDarkTheme)
                    App.Current.Resources.ApplyDarkTheme();
                else
                    App.Current.Resources.ApplyLightTheme();
            }
        }
          
        public int SelectedPrimaryColor
        {
            get => this.selectedPrimaryColor;
            set
            {
                if (this.selectedPrimaryColor == value)
                    return;

                this.selectedPrimaryColor = value;
                ThemePalette.ApplyColorSet(this.selectedPrimaryColor);
            }
        }

        public static void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("");
            ApplyThemes();
        }

        private static void ApplyThemes()
        {
            OSAppTheme currentTheme = App.Current.RequestedTheme;
            if (currentTheme == OSAppTheme.Light)
                App.Current.Resources.ApplyLightTheme();
            else
                App.Current.Resources.ApplyLightTheme();

            ThemePalette.ApplyColorSet(1);
        }
    }
}