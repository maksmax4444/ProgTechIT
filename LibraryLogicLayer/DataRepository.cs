using LibraryDataLayer;

namespace LibraryLogicLayer
{
    internal class DataRepository
    {
        DataContextI dataContext;

        public DataRepository(DataContextI dataContexI)
        {
            dataContext = dataContexI;
        }

        public void BorrowCatalog(int stateId, int userId)
        {
            dataContext.ChangeState(stateId, -1);
            dataContext.AddUserEvent(stateId, userId);
        }

         public void ReturnCatalog(int stateId, int userId)
        {
            dataContext.ChangeState(stateId, 1);
            dataContext.AddUserEvent(stateId, userId);
        }

        public void DestroyCatalog(int stateId)
        {
            dataContext.ChangeState(stateId, -1);
            dataContext.AddDatabaseEvent(stateId);
        }

        public void AddCatalog(int stateId)
        {
            dataContext.ChangeState(stateId, 1);
            dataContext.AddDatabaseEvent(stateId);
        }

        public void AddNewCatalogType(string title, string author, int nrOfPages)
        {
            dataContext.AddCatalog(title, author, nrOfPages);
        }

    }
}
