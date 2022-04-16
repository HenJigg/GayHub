using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Prism.DryIoc;
using Prism.Ioc; 

namespace GayHub
{
    public partial class App
    {
        protected override async void OnInitialized()
        {
            InitializeComponent();
            AppSettings.OnInitialized();
            await NavigationService.NavigateAsync(AppViewKeys.Index);
        }

        protected override IContainerExtension CreateContainerExtension()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddAutoMapper(config =>
            {
                config.AddProfile<AppMapper>();
            });
            return new DryIocContainerExtension(new Container(CreateContainerRules())
                .WithDependencyInjectionAdapter(serviceCollection));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterAppServices();
        }
    }
}
