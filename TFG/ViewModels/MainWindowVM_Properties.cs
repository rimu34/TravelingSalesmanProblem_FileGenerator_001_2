namespace TFG.ViewModels
{
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
    }
}