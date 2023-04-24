namespace TFG.Core.MVVM
{
    using System;
    using Prism.Events;
    using Prism.Services.Dialogs;
    using TFG.Core.Services.Interfaces;

    public abstract class DialogViewModelBase : ViewModelBase, IDialogAware
    {
        protected DialogViewModelBase(IEventAggregator eventAggregator, IDialogService dialogService, IAppLogger logger)
            : base(eventAggregator, dialogService, logger)
        {
        }

        public abstract event Action<IDialogResult> RequestClose;

        public string Title { get; protected set; } = string.Empty;

        public virtual bool CanCloseDialog() => true;

        public virtual void OnDialogClosed()
        { }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        { }
    }
}