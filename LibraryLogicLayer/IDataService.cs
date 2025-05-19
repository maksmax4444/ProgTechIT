using LibraryDataLayer;
using System.Data.Linq;

namespace LibraryLogicLayer
{
    public interface IDataService
    {
        public void AddCatalog(int id, string title, string author, int nOfPages);
        public void AddUser(int id, string fName, string lName);
        public void AddUserEvent(int id, int stateId, int userId);
        public void AddDatabaseEvent(int id, int stateId);
        public void AddState(int id, int nrOfBooks, int catalogId);

        public void RemoveCatalog(int id);
        public void RemoveUser(int id);
        public void RemoveEvent(int id);
        public void RemoveState(int id);

        public ICatalogService GetCatalog(int id);
        public IUserService GetUser(int id);
        public IEventService GetEvent(int id);
        public IStateService GetState(int id);

        public void UpdateCatalog(int id, string title, string author, int nOfPages);
        public void UpdateUser(int id, string fName, string lName);
        public void UpdateEvent(int id, int stateId);
        public void UpdateState(int id, int nrOfBooks, int catalogId);

        //factory
        public static IDataService CreateNewDataService()
        {
            return new DataService();
        }

        public static IDataService CreateNewDataService(IDataContext dataContext)
        {
            return new DataService(dataContext);
        }
    }
}
