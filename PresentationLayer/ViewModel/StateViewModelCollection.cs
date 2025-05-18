using System.Windows.Input;

namespace PresentationLayer.ViewModel
{
    internal class StateViewModelCollection : PropertyChange
    {
        private int stateId;
        private int nrOfBooks;
        private CatalogViewModel catalog;
        private List<StateViewModel> states;
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
            states = new List<StateViewModel>();
            //Place for commands
        }
        private async Task Add()
        {
            //Placeholder for commandAdd
        }
        private async Task Delete()
        {
            //Placeholder for commandDelete
        }
    }
}
