using System;
using AppGPS.Interfaces;
using Xamarin.Forms;

namespace AppGPS.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Title = "GPS";
            CheckGPSCommand = new Command(() => ExecuteCheckGPSCommand());
        }

        public Command CheckGPSCommand { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private void ExecuteCheckGPSCommand()
        {
            DependencyService.Get<IGPSAndroid>().CheckGPSEnabled();
        }
    }
}
