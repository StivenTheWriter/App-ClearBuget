using ProyectMoney.FrontView.Models;
using ProyectMoney.FrontView.PageModels;

namespace ProyectMoney.FrontView.Pages
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