namespace TFG
{
    using System.Windows;
    using Prism.DryIoc;
    using Prism.Ioc;
    using TFG.Core;
    using TFG.Core.Common.Enums;
    using TFG.ViewModels;
    using TFG.Views;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell() => Container.Resolve<MainWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register Services
            containerRegistry.RegisterCoreServices();

            //Register Views & ViewModels
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowVM>(ViewType.Shell.ToString());
        }
    }
}