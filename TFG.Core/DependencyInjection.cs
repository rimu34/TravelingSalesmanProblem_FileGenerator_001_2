namespace TFG.Core
{
    using Prism.Ioc;
    using TFG.Core.Services;
    using TFG.Core.Services.Interfaces;

    public static class DependencyInjection
    {
        public static IContainerRegistry RegisterCoreServices(this IContainerRegistry registry)
        {
            // Register Services
            registry.Register<IAppLogger, ApplicationLogger>();

            return registry;
        }
    }
}