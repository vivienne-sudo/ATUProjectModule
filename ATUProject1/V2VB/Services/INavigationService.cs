using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using V2VB.Views; 

namespace V2VB.Services
{
    public interface INavigationService
        {
            Task NavigateAsync(string route);
            Task NavigateAsync(string route, object parameter);
            Task NavigateBackAsync();

        }

        public class NavigationService : INavigationService
        {
            private readonly INavigation _navigation;

            public NavigationService(INavigation navigation)
            {
                _navigation = navigation;
            }

            public async Task NavigateAsync(string route)
            {
                await _navigation.PushAsync(CreatePage(route));
            }

            public async Task NavigateAsync(string route, object parameter)
            {
                var page = CreatePage(route);
                page.BindingContext = parameter;
                await _navigation.PushAsync(page);
            }

            public async Task NavigateBackAsync()
            {
                await _navigation.PopAsync();
            }

        private Page CreatePage(string route)
        {
            switch (route)
            {
                case "LoginPage":
                    return new LoginPage();
                case "HomePage":
                    return new HomePage();
                // add more cases for other pages
                default:
                    throw new ArgumentException("Invalid route");
            }
        }

    }

}
