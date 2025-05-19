using LibraryDataLayer;

namespace LogicLayerTest
{
    internal class TestLibraryState : IState
    {
        public TestLibraryState(int stateId, int nrOfBooks, TestLibraryCatalog catalog)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalog = catalog;
        }
    }
}
