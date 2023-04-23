namespace TFG.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Prism.Ioc;

    public static class DependencyInjection
    {
        public static IContainerRegistry RegisterCoreServices(this IContainerRegistry registry)
        {

            return registry;
        }
    }
}
