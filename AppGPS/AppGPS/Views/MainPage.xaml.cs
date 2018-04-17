using AppGPS.ViewModels;
using Xamarin.Forms;

namespace AppGPS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
