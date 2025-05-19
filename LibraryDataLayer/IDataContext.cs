using Microsoft.EntityFrameworkCore;

namespace LibraryDataLayer
{
    public interface IDataContext
    {
        //addition
        void AddCatalog(int id, string title, string author, int nrOfPages);
        void AddUser(int id, string firstName, string lastName);
        void AddUserEvent(int id, int stateId, int userId);
        void AddDatabaseEvent(int id, int stateId);
        void AddState(int id, int nrOfBooks, int catalogId);
        //removal
        void RemoveCatalog(int catalogId);
        void RemoveUser(int userId);
        void RemoveEvent(int eventId);
        void RemoveState(int stateId);
        //get
        public ICatalog? GetCatalog(int id);
        public IUser? GetUser(int id);
        public IEvent? GetEvent(int id);
        public IState? GetState(int id);

        public void CleanData();

        //factory
        public static IDataContext CreateNewContext()
        {
            return new DataContext();
        }

        public static IDataContext CreateNewContext(string connectionString)
        {
            return new DataContext(connectionString);
        }
    }
}
