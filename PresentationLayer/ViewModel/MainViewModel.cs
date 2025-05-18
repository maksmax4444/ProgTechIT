using System.Windows.Input;

namespace PresentationLayer.ViewModel
{
    internal class MainViewModel : PropertyChange
    {
        private int whatClass = 0;
        private int whatElement = 0;
        private PropertyChange currentView;
        public ICommand newView { get; }
        public ICommand previous { get; }
        public ICommand next { get; }
        public ICommand left { get; }
        public ICommand right { get; }

        public PropertyChange CurrentView
        {
            get
            {
                return this.currentView;
            }

            set
            {
                this.currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public MainViewModel()
        {
            newView = new RelayCommand(NextView);
            previous = new RelayCommand(Previous);
            next = new RelayCommand(Next);
            left = new RelayCommand(Left);
            right = new RelayCommand(Right);
            CurrentView = new UsersViewModelCollection();
        }

        public int getElement()
        { 
            return whatElement; 
        }

        private void NextView(object parameter) 
        {
            switch (whatClass)
            {
                case 0:
                    //Users
                    currentView = new UsersViewModelCollection();
                    break;
                case 1:
                    //Catalogs
                    currentView = new CatalogViewModelCollection();
                    break;
                case 2:
                    //States
                    currentView = new StateViewModelCollection();
                    break;
                case 3:
                    //Events
                    currentView = new EventViewModelCollection();
                    break;
            }
        }

        private void Previous(object parameter)
        {
            if (whatElement == 0)
            {
                whatElement = 3;
            }
            else
            {
                whatElement--;
            }
        }

        private void Next(object parameter)
        {
            if (whatElement == 3)
            {
                whatElement = 0;
            }
            else
            {
                whatElement++;
            }
        }

        private void Left(object parameter)
        {
            whatElement--;
        }

        private void Right(object parameter)
        {
            whatElement++;
        }
    }
}
