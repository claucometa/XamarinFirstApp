using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFirstApp.Pages;

namespace XamarinFirstApp.Services
{
    public class NavigationService
    {
        public async void Navigate(string PageName)
        {
            App.Master.IsPresented = false;

            switch (PageName)
            {
                case "OrderPage":
                    await navigate(new OrderPage());
                    break;
                case "AlarmPage":
                    await navigate(new AlarmPage());
                    break;
                case "ClientPage":
                    await navigate(new ClientPage());
                    break;
                case "SettingsPage":
                    await navigate(new SettingsPage());
                    break;
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
                default:
                    break;
            }
        }

        private static async Task navigate<T>(T page) where T : Page
        {
            NavigationPage.SetHasBackButton(page, false);
            NavigationPage.SetBackButtonTitle(page, "Voltar");
            await App.Navigator.PushAsync(page);
        }
    }
}
