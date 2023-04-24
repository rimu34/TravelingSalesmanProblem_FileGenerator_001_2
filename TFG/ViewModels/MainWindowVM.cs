namespace TFG.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Prism.Events;
    using Prism.Services.Dialogs;
    using TFG.Core.MVVM;
    using TFG.Core.Services.Interfaces;

    public class MainWindowVM : ViewModelBase
    {
        public MainWindowVM(IEventAggregator eventAggregator, IDialogService dialogService, IAppLogger logger) 
            : base(eventAggregator, dialogService, logger)
        {
        }

        protected override void InitializeEvents()
        {
            throw new NotImplementedException();
        }

        protected override void InitializeProperties()
        {
            throw new NotImplementedException();
        }
    }
}
