using LibraryModel;

namespace LibraryViewModel
{
    public class StateViewModel : PropertyChange, IStateModel
    {
        public int stateId { get; set; }
        public int nrOfBooks { get; set; }
        public int catalogId { get; set; }
        public StateViewModel(int stateId, int nrOfBooks, int catalogId)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalogId = catalogId;
        }
        public StateViewModel()
        {
            StateId = 0;
            NrOfBooks = 0;
            CatalogId = 0;
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
        public int CatalogId
        {
            get
            {
                return this.catalogId;
            }

            set
            {
                this.catalogId = value;
                OnPropertyChanged(nameof(CatalogId));
            }
        }
    }
}
