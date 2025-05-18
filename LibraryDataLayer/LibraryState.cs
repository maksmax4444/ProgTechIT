namespace LibraryDataLayer
{
    internal class LibraryState : IState
    {
        public LibraryState(int stateId, int nrOfBooks, LibraryCatalog catalog)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalog = catalog;
        }
    }
}
