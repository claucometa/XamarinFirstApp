using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinFirstApp.Pages;

namespace XamarinFirstApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new WelcomePage();
            MainPage = new MasterPage();
        }

        public static async Task sleep(int ms)
        {
            await Task.Delay(ms);
        }

        public static MasterPage Master { get; internal set; }
        public static NavigationPage Navigator { get; internal set; }
    }
}
