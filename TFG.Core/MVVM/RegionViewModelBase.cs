namespace TFG.Core.MVVM
{
    using System;
    using Prism.Events;
    using Prism.Regions;
    using Prism.Services.Dialogs;
    using TFG.Core.Services.Interfaces;

    public abstract class RegionViewModelBase : ViewModelBase, INavigationAware, IConfirmNavigationRequest
    {
        protected readonly IRegionNavigationService _navigationService;

        protected RegionViewModelBase(IEventAggregator eventAggregator, IDialogService dialogService, IAppLogger logger, IRegionNavigationService navigationService)
            : base(eventAggregator, dialogService, logger)
        {
            _navigationService = navigationService;
        }

        public virtual void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback) => continuationCallback(true);

        public virtual bool IsNavigationTarget(NavigationContext navigationContext) => true;

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        { }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        { }
    }
}