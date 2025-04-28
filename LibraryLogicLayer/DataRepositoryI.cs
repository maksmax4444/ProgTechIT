using LibraryDataLayer;

namespace LibraryLogicLayer
{
    public abstract class DataRepositoryI
    {
        public abstract void BorrowCatalog(int stateId, int userId);

        public abstract void ReturnCatalog(int stateId, int userId);

        public abstract void DestroyCatalog(int stateId);

        public abstract void AddCatalog(int stateId);

        public abstract void AddNewCatalogType(string title, string author, int nrOfPages);
    }
}
