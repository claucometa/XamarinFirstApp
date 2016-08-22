using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace XamarinFirstApp.ViewModels
{
    public class MainViewModel
    {
        Services.NavigationService nav;

        public MainViewModel()
        {
            nav = new Services.NavigationService();
            LoadMenu();
            LoadData();
        }

        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public ObservableCollection<OrderViewModel> Orders { get; set; }
        #endregion

        #region Commands
        public ICommand GoToCommand
        {
            get
            {
                return new RelayCommand<string>(GoTo);
            }
        }

        private void GoTo(string pageName)
        {
            nav.Navigate(pageName);
        }

        #endregion

        #region MyRegion
        private void LoadData()
        {
            Orders = new ObservableCollection<OrderViewModel>();
            for (int i = 0; i < 5; i++)
            {
                Orders.Add(new OrderViewModel
                {
                    Title = "Lorem Ipsum",
                    DeliveryDate = DateTime.Today,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                });
            }
        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel { Icon = "ic_action_orders", Title = "Pedidos", PageName = "MainPage" });
            Menu.Add(new MenuItemViewModel { Icon = "ic_action_clients", Title = "Clientes", PageName = "ClientPage" });
            Menu.Add(new MenuItemViewModel { Icon = "ic_action_alarm", Title = "Alarme", PageName = "AlarmPage" });
            Menu.Add(new MenuItemViewModel { Icon = "ic_action_settings", Title = "Ajustes", PageName = "SettingsPage" });
        }
        #endregion
    }
}
