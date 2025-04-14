using LibraryDataLayer;

namespace LibraryLogicLayer
{
    public abstract class DataServiceI
    {
        public abstract void BorrowCatalog(int StateId, int UserId);
        public abstract void ReturnCatalog(int StateId, int UserId);
        public abstract void DestoryCatalog(int StateId);
        public abstract void AddCatalog(int StateId);
    }
}
