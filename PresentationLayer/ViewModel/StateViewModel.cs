using System.Windows.Input;
using LibraryLogicLayer;

namespace PresentationLayer.ViewModel
{
    internal class StateViewModel : PropertyChange
    {
        private int stateId;
        private int nrOfBooks;
        private int catalog;
        private IDataService ids = IDataService.CreateNewDataService();
        private StateViewModel s; public ICommand AddSmth { get; }
        public ICommand DeleteSmth { get; }
        public ICommand UpdateSmth { get; }

        public StateViewModel(int stateId, int nrOfBooks, int catalog)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalog = catalog;

            AddSmth = new RelayCommand(_ => add());
            DeleteSmth = new RelayCommand(_ => delete());
            UpdateSmth = new RelayCommand(_ => update());
        }

        public StateViewModel()
        {
            StateId = 0;
            NrOfBooks = 0;
            Catalog = 0;

            AddSmth = new RelayCommand(_ => add());
            DeleteSmth = new RelayCommand(_ => delete());
            UpdateSmth = new RelayCommand(_ => update());
        }

        public int StateId
        {
            get
            {
                return this.stateId;
            }

            set
            {
                this.stateId = value;
                OnPropertyChanged(nameof(StateId));
            }
        }

        public int NrOfBooks
        {
            get
            {
                return this.nrOfBooks;
            }

            set
            {
                this.nrOfBooks = value;
                OnPropertyChanged(nameof(NrOfBooks));
            }
        }

        public int Catalog
        {
            get
            {
                return this.catalog;
            }

            set
            {
                this.catalog = value;
                OnPropertyChanged(nameof(Catalog));
            }
        }
        public void add()
        {
            ids.AddState(stateId, nrOfBooks, catalog);
        }

        public void delete()
        {
            ids.RemoveState(stateId);
        }

        public void update()
        {
            ids.UpdateState(stateId, nrOfBooks, catalog);
        }
    }
}
