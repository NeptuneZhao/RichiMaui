using RichiMaui.Models;
using RichiMaui.PageModels;

namespace RichiMaui.Pages
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (count < 2147483647) count++;
            else count = 0;
                messageLabel.Text = $"你点了{count}下！😊";
        }
    }
}