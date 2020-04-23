using Prism.Ioc;
using Prism.Modularity;
using gastoss.prism.Views;
using gastoss.prism.ViewModels;

namespace gastoss.prism
{
    public class prismModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
