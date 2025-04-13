namespace LibraryDataLayer
{
    public class State
    {
        public int stateId { get; set; }
        public int nrOfBooks { get; set;}
        public Catalog catalog { get; set;}

        public State(int stateId, int nrOfBooks, Catalog catalog)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalog = catalog;
        }
    }
}
