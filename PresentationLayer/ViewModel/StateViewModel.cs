namespace PresentationLayer.ViewModel
{
    internal class StateViewModel : PropertyChange
    {
        private int stateId;
        private int nrOfBooks;
        private CatalogViewModel catalog;

        public StateViewModel(int stateId, int nrOfBooks, CatalogViewModel catalog)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalog = catalog;
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
    }
}
