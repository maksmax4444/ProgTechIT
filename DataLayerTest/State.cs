using LibraryDataLayer;
namespace DataLayerTest
{
    internal class State : StateI
    {
        public State(int stateId, int nrOfBooks, Catalog catalog)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalog = catalog;
        }
    }
}
