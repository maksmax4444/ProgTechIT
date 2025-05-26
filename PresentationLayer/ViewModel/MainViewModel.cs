using System.Windows.Input;

namespace PresentationLayer.ViewModel
{
    internal class MainViewModel : PropertyChange
    {
        private PropertyChange _currentView;
        public ICommand showCatalogs { get; }
        public ICommand showEvents { get; }
        public ICommand showStates { get; }
        public ICommand showUsers { get; }
        public PropertyChange CurrentView
        {
            get
            {
                return _currentView;
            }

            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }
        public MainViewModel()
        {
            showCatalogs = new RelayCommand(_ => showC());
            showEvents = new RelayCommand(_ => showE());
            showStates = new RelayCommand(_ => showS());
            showUsers = new RelayCommand(_ => showU());
            CurrentView = new CatalogViewModelCollection();
        }
        public void showC()
        {
            CurrentView = new CatalogViewModelCollection();
        }
        public void showE()
        {
            CurrentView = new EventViewModelCollection();
        }
        public void showS()
        {
            CurrentView = new StateViewModelCollection();
        }
        public void showU()
        {
            CurrentView = new UsersViewModelCollection();
        }
    }
}
