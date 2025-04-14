namespace LibraryDataLayer
{
    public abstract class DataContextI
    {
        public abstract void AddCatalog(string title, string author, int nrOfPages);
        public abstract void AddUser(string firstName, string lastName);
        public abstract void AddUserEvent(int stateId, int userId);
        public abstract void AddDatabaseEvent(int stateId);
        public abstract void AddState(int nrOfBooks, int catalogId);

        public abstract void ChangeState(int stateId, int change);
    }
}
