using VC22.ViewModels.Base;

namespace VC22.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Analis";

        /// <summary> Заголовок окна </summary>
        public string Title
        {
            get => _Title;
            //set
            //{
            //    //if (Equals(_Title, value)) return;
            //    //_Title= value;
            //    //OnPropertyChanged();
            //    Set(ref _Title, value);
            //}
            set => Set(ref _Title, value);
        }
        #endregion
        
        #region Статус окна
        private string _Status = "Готов!";
        /// <summary> Статус окна </summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        } 
        #endregion
    }
}
