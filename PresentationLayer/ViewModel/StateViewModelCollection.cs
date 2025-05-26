using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryDataLayer;
using LibraryLogicLayer;

namespace PresentationLayer.ViewModel
{
    internal class StateViewModelCollection : PropertyChange
    {
        private int stateId;
        private int nrOfBooks;
        private int catalog;
        private const string connectionString = "";
        private IDataService ids = IDataService.CreateNewDataService(connectionString);
        private StateViewModel _detail;
        public ObservableCollection<StateViewModel> States { get; set; }
        public ICommand Add { get; }
        public ICommand Delete { get; }
        public ICommand Update { get; }
        public ICommand Load { get; }
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
        public StateViewModel Detail
        {
            get
            {
                return _detail;
            }

            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
                StateId = value.StateId;
                NrOfBooks = value.NrOfBooks;
            }
        }
        public StateViewModelCollection()
        {
            States = new ObservableCollection<StateViewModel> { };
            Add = new RelayCommand(_ => add());
            Delete = new RelayCommand(_ => delete());
            Update = new RelayCommand(_ => update());
            Load = new RelayCommand(_ => load());
        }
        public void add()
        {
            if (connectionString == "")
            {
                States.Add(new StateViewModel(StateId, NrOfBooks, Catalog));
            }
            else ids.AddState(StateId, NrOfBooks, Catalog);
        }

        public void delete()
        {
            if (connectionString == "")
            {
                for (int i = States.Count - 1; i >= 0; i--)
                {
                    if (States[i].StateId == StateId)
                    {
                        States.RemoveAt(i);
                        break;
                    }
                }
            }
            else ids.RemoveState(StateId);
        }

        public void update()
        {
            if (connectionString == "")
            {
                delete();
                add();
            }
            else ids.UpdateState(stateId, nrOfBooks, Catalog);
        }
        public void load()
        {
            States.Clear();
            foreach (var state in ids.GetAllState())
            {
                States.Add(new StateViewModel(StateId = state.id, NrOfBooks = state.noBooks, Catalog = state.catalogId));
            }
        }
    }
}
