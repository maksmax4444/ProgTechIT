using System.Windows.Input;

namespace PresentationLayer.ViewModel
{
    internal class MainViewModel : PropertyChange
    {
        private int v = 1;
        private PropertyChange _currentView;
        public ICommand showCatalogs { get; }
        public ICommand showEvents { get; }
        public ICommand showStates { get; }
        public ICommand showUsers { get; }
        public ICommand Detail { get; }

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
            Detail = new RelayCommand(_ => detail());
            CurrentView = new CatalogViewModelCollection();
        }

        public void detail() 
        {
            switch (v)
            {
                case 1:
                    CurrentView = new CatalogViewModel();
                    break;
                case 2:
                    CurrentView = new EventViewModel();
                    break;
                case 3:
                    CurrentView = new StateViewModel();
                    break;
                case 4:
                    CurrentView = new UsersViewModel();
                    break;
            }
        }

        public void showC()
        {
            v = 1;
            CurrentView = new CatalogViewModelCollection();
        }

        public void showE()
        {
            v = 2;
            CurrentView = new EventViewModelCollection();
        }

        public void showS()
        {
            v = 3;
            CurrentView = new StateViewModelCollection();
        }

        public void showU()
        {
            v = 4;
            CurrentView = new UsersViewModelCollection();
        }
    }
}
