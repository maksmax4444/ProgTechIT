namespace LibraryDataLayer
{
    public interface IDataContext
    {
        //addition
        Task AddCatalog(string title, string author, int nrOfPages);
        Task AddUser(string firstName, string lastName);
        Task AddUserEvent(int stateId, int userId);
        Task AddDatabaseEvent(int stateId);
        Task AddState(int nrOfBooks, int catalogId);
        //removal
        Task RemoveCatalog(int catalogId);
        Task RemoveUser(int userId);
        Task RemoveEvent(int eventId);
        Task RemoveState(int stateId);
        //get
        public ICatalog? GetCatalog(int id);
        public IUser? GetUser(int id);
        public IEvent? GetEvent(int id);
        public IState? GetState(int id);
    }
}
