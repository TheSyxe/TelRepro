using System;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace TelRepro.ViewModels
{
    public class MyBindableBase : BindableBase, IConfirmNavigation
    {

        // ReSharper disable once InconsistentNaming
        public bool IsiOS
        {
            get { return Device.OS == TargetPlatform.iOS; }
        }

        public bool IsAndroid
        {
            get { return Device.OS == TargetPlatform.Android; }
        }

        public readonly INavigationService NavService;
        public readonly IEventAggregator EventAgg;
        private bool _isLoading;

        public bool IsLoading
        {
            get { return _isLoading; }
            set { SetProperty(ref _isLoading, value); }
        }

        public MyBindableBase(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            NavService = navigationService;
            EventAgg = eventAggregator;
        }
        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            return true;
        }
    }

}