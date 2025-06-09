using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryModel;

namespace LibraryViewModel
{
    public class StateViewModelCollection : PropertyChange
    {
        private int stateId;
        private int nrOfBooks;
        private int catalog;
        private static IDataModel ids;
        public StateViewModelCollection()
        {
            States = new ObservableCollection<StateViewModel> { };
            Add = new RelayCommand(() => add());
            Delete = new RelayCommand(() => delete());
            Update = new RelayCommand(() => update());
            Load = new RelayCommand(() => load());
            ids = IDataModel.CreateNewDataModel();
        }

        public StateViewModelCollection(IDataModel m)
        {
            States = new ObservableCollection<StateViewModel> { };
            Add = new RelayCommand(() => add());
            Delete = new RelayCommand(() => delete());
            Update = new RelayCommand(() => update());
            Load = new RelayCommand(() => load());
            ids = m;
        }
        public StateViewModel _detail;
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
                if (value != null)
                {
                    StateId = value.StateId;
                    NrOfBooks = value.NrOfBooks;
                }
            }
        }
        public void add()
        {
            States.Add(new StateViewModel(StateId, NrOfBooks, Catalog));
            ids.AddState(Catalog, NrOfBooks, StateId);
        }

        public void delete()
        {
            for (int i = States.Count - 1; i >= 0; i--)
            {
                if (States[i].StateId == StateId)
                {
                    States.RemoveAt(i);
                    break;
                }
            }
            ids.RemoveState(StateId);
        }

        public void update()
        {
            delete();
            add();
        }
        public void load()
        {
            States.Clear();
            foreach (var state in ids.GetAllState())
            {
                States.Add(new StateViewModel(StateId = state.stateId, NrOfBooks = state.nrOfBooks, Catalog = state.catalogId));
            }
        }
    }
}
