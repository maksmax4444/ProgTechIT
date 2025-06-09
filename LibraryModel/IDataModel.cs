using LibraryDataLayer;
using LibraryLogicLayer;

namespace LibraryModel
{
    public interface IDataModel
    {
        public void AddCatalog(int id, string title, string author, int nOfPages);
        public void AddUser(int id, string fName, string lName);
        public void AddEvent(int id, int stateId);
        public void AddState(int id, int nrOfBooks, int catalogId);

        public void RemoveCatalog(int id);
        public void RemoveUser(int id);
        public void RemoveEvent(int id);
        public void RemoveState(int id);

        public ICatalogModel GetCatalog(int id);
        public IUsersModel GetUser(int id);
        public IEventModel GetEvent(int id);
        public IStateModel GetState(int id);

        public ICatalogModel[] GetAllCatalog();
        public IUsersModel[] GetAllUser();
        public IEventModel[] GetAllEvent();
        public IStateModel[] GetAllState();

        public void UpdateCatalog(int id, string title, string author, int nOfPages);
        public void UpdateUser(int id, string fName, string lName);
        public void UpdateEvent(int id, int stateId);
        public void UpdateState(int id, int nrOfBooks, int catalogId);

        //factory
        public static IDataModel CreateNewDataModel()
        {
            return new DataModel();
        }
        public static IDataModel CreateNewDataModel(IDataService s)
        {
            return new DataModel(s);
        }
    }
}
