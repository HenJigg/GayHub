using GayHub.Services.ApiConfig;
using GayHub.Services.User;
using GayHub.ViewModels;
using GayHub.Views;
using Prism.Ioc;
using Xamarin.Forms;

namespace GayHub
{
    internal static class AppServices
    {
        public static void RegisterAppServices(this IContainerRegistry services)
        {
            services.RegisterSingleton<GayhubClient>();

            services.Register<IUserService, UserService>();

            services.RegisterForNavigation<IndexView, IndexViewModel>();
            services.RegisterForRegionNavigation<MainView, MainViewModel>();
            services.RegisterForRegionNavigation<UserView, UserViewModel>();

            services.RegisterRegionServices();
            services.RegisterForNavigation<NavigationPage>();
        }
    }
}
