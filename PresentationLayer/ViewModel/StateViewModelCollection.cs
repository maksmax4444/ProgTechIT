using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryLogicLayer;
using PresentationLayer.Model;

namespace PresentationLayer.ViewModel
{
    internal class StateViewModelCollection : PropertyChange
    {
        private int stateId;
        private int nrOfBooks;
        private CatalogViewModel catalog;
        public ObservableCollection<StateViewModel> States { get; set; }
        public ICommand commandAdd { get; }
        public ICommand commandDelete { get; }

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
        public CatalogViewModel Catalog
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
        public StateViewModelCollection()
        {
            States = new ObservableCollection<StateViewModel> { };
            //Place for commands
        }
    }
}
