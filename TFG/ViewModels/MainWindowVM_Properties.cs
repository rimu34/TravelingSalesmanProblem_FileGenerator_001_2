namespace TFG.ViewModels
{
    using System.Security.Cryptography.X509Certificates;

    public sealed partial class MainWindowVM
    {
        #region UI Properties

        private string _title = "MainWindow";

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #endregion UI Properties

        #region Selected Page

        private bool _isDashBoardSelected = true;

        public bool IsDashBoardSelected
        {
            get => _isDashBoardSelected;
            set
            {
                SetProperty(ref _isDashBoardSelected, value);
            }
        }

        #endregion
    }
}