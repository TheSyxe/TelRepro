using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using TelRepro.Models;
using TelRepro.ViewModels;
using Xamarin.Forms;

namespace TelRepro.Views
{
    public partial class MainPage : ContentPage
    {
        private bool _isSwiping;
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ForceLayout();
        }

        private void List_OnItemTapped(object sender, ItemTapEventArgs args)
        {
            if (!_isSwiping)
            {
                var item = args.Item as ActionItem;
                var bc = BindingContext as MainPageViewModel;
                var listView = sender as RadListView;
                if (item == null || bc == null || listView == null) return;
                listView.SelectedItems.Clear();
                bc.NavigateToActionItem(item);
            }
            else _isSwiping = false;
        }

        private void ActionListView_OnItemSwiping(object sender, ItemSwipingEventArgs e)
        {
            var item = e.Item as ActionItem;
            var bc = BindingContext as MainPageViewModel;
            if (bc == null || item == null) return;
            var listView = sender as RadListView;
            if (listView != null)
            {
                listView.SelectedItems.Clear();
            }
            bc.IsUtilityAlertSwiped = item.ActionType == ActionItemType.UtilityAlert;
            bc.IsPrebillingSwiped = item.ActionType == ActionItemType.PrebillingApproval;
            bc.SwipedItem = item;
            _isSwiping = true;

        }
        private void ActionListView_OnRefreshRequested(object sender, PullToRefreshRequestedEventArgs e)
        {
            var s = sender as RadListView;
            if (s != null) s.EndRefresh(true);
            var listView = sender as RadListView;
            if (listView != null) listView.SelectedItems.Clear();
            var bc = BindingContext as MainPageViewModel;
            if (bc != null) bc.LoadData();
        }
    }
}
