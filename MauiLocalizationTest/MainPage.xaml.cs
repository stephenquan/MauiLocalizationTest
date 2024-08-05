using MauiLocalizationTest.Resources.Strings;

namespace MauiLocalizationTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

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
    }

}
