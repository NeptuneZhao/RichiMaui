using RichiMaui.Models;
using RichiMaui.PageModels;

namespace RichiMaui.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}