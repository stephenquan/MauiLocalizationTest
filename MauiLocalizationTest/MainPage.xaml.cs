using MauiLocalizationTest.Resources.Strings;
using System.Globalization;

namespace MauiLocalizationTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public string MAIN_PAGE_TITLE => AppStrings.MAIN_PAGE_TITLE;
        public string LBL_HELLO_WORLD => AppStrings.LBL_HELLO_WORLD;
        public string LBL_WELCOME => AppStrings.LBL_WELCOME;
        public string BTN_CLICK_ME => AppStrings.BTN_CLICK_ME;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = string.Format(AppStrings.BTN_CLICKED_1_TIME, count);
            else
                CounterBtn.Text = string.Format(AppStrings.BTN_CLICKED_N_TIMES, count);

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnLanguageClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string lang = btn.Text;
            CultureInfo cultureInfo = new CultureInfo(lang);
            CultureInfo.CurrentUICulture = cultureInfo;
            CultureInfo.CurrentUICulture.ClearCachedData();
            OnPropertyChanged(nameof(MAIN_PAGE_TITLE));
            OnPropertyChanged(nameof(LBL_HELLO_WORLD));
            OnPropertyChanged(nameof(LBL_WELCOME));
            OnPropertyChanged(nameof(BTN_CLICK_ME));
        }
    }

}
