using EcoMeChan_Mobile.Resources.Languages;

namespace EcoMeChan_Mobile.Views
{
    public partial class LanguageSelectionPage : ContentPage
    {
        public LanguageSelectionPage()
        {
            InitializeComponent();
        }

        private async void ChangeLanguageToEnglish(object sender, EventArgs e)
        {
            AppResources.Culture = new System.Globalization.CultureInfo("en");
            await Navigation.PopAsync();
        }

        private async void ChangeLanguageToUkrainian(object sender, EventArgs e)
        {
            AppResources.Culture = new System.Globalization.CultureInfo("uk");
            await Navigation.PopAsync();
        }
    }
}