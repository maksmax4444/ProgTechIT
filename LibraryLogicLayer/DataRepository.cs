using LibraryDataLayer;

namespace LibraryLogicLayer
{
    internal class DataRepository : DataRepositoryI
    {
        DataContextI dataContext;

        public DataRepository(DataContextI dataContexI)
        {
            dataContext = dataContexI;
        }

        public override void BorrowCatalog(int stateId, int userId)
        {
            dataContext.ChangeState(stateId, -1);
            dataContext.AddUserEvent(stateId, userId);
        }

         public override void ReturnCatalog(int stateId, int userId)
        {
            dataContext.ChangeState(stateId, 1);
            dataContext.AddUserEvent(stateId, userId);
        }

        public override void DestroyCatalog(int stateId)
        {
            dataContext.ChangeState(stateId, -1);
            dataContext.AddDatabaseEvent(stateId);
        }

        public override void AddCatalog(int stateId)
        {
            dataContext.ChangeState(stateId, 1);
            dataContext.AddDatabaseEvent(stateId);
        }

        public override void AddNewCatalogType(string title, string author, int nrOfPages)
        {
            dataContext.AddCatalog(title, author, nrOfPages);
        }

    }
}
