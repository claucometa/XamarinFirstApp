using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamarinFirstApp.Pages;
using XamarinFirstApp.Services;

namespace XamarinFirstApp.ViewModels
{
    public class MenuItemViewModel
    {
        NavigationService nav;

        public MenuItemViewModel()
        {
            nav = new NavigationService();
        }


        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(() => nav.Navigate(PageName));
            }
        }
    }
}
