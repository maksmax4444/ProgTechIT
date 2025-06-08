using System.Windows.Input;

namespace LibraryViewModel
{
    public class MainViewModel : PropertyChange
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
            showCatalogs = new RelayCommand(() => showC());
            showEvents = new RelayCommand(() => showE());
            showStates = new RelayCommand(() => showS());
            showUsers = new RelayCommand(() => showU());
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
