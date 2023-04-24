namespace TFG.Core.MVVM
{
    using System;
    using NLog;
    using Prism.Events;
    using Prism.Mvvm;
    using Prism.Navigation;
    using Prism.Services.Dialogs;
    using TFG.Core.Services.Interfaces;

    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        protected readonly IEventAggregator _eventAggregator;
        protected readonly IDialogService _dialogService;
        protected readonly IAppLogger _logger;

        protected ViewModelBase(IEventAggregator eventAggregator, IDialogService dialogService, IAppLogger logger)
        {
            _eventAggregator = eventAggregator;
            _dialogService = dialogService;
            _logger = logger;
        }

        protected abstract void InitializeEvents();

        protected abstract void InitializeProperties();

        protected virtual void InitializeViewModel()
        {
            InitializeEvents();
            InitializeProperties();
        }

        protected virtual void OnErrorOccured(Exception exp) => _logger.LogException(LogLevel.Error, exp);

        protected virtual void OnErrorOccured(Exception exp, string message) => _logger.LogException(LogLevel.Error, exp, message);

        public virtual void Destroy()
        {
        }
    }
}