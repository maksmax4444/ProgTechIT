using LibraryModel;

namespace PresentationLayerTest
{
    internal class TestDataModel : IDataModel
    {
        public List<TestCatalogModel> Catalogs  = new List<TestCatalogModel>();
        public List<TestUsersModel> Users = new List<TestUsersModel>();
        public List<TestEventModel> Events = new List<TestEventModel>();
        public List<TestStateModel> States = new List<TestStateModel>();

        public void AddCatalog(int id, string title, string author, int nOfPages)
        {
            TestCatalogModel i = new TestCatalogModel(id, title, author, nOfPages);
            Catalogs.Add(i);
        }
        public void AddUser(int id, string fName, string lName)
        {
            TestUsersModel i = new TestUsersModel(id, fName, lName);
            Users.Add(i);
        }
        public void AddEvent(int id, int stateId)
        {
            TestEventModel i = new TestEventModel(id, stateId);
            Events.Add(i);
        }
        public void AddState(int id, int nrOfBooks, int catalogId)
        {
            TestStateModel i = new TestStateModel(id, nrOfBooks, catalogId);
            States.Add(i);
        }

        public void RemoveCatalog(int id)
        {
            id = GetCatalogIndexFromId(id);
            Catalogs.RemoveAt(id);
        }
        public void RemoveUser(int id)
        {
            id = GetUsersIndexFromId(id);
            Users.RemoveAt(id);
        }
        public void RemoveEvent(int id)
        {
            id = GetEventIndexFromId(id);
            Events.RemoveAt(id);
        }
        public void RemoveState(int id)
        {
            id = GetStateIndexFromId(id);
            States.RemoveAt(id);
        }

        public ICatalogModel GetCatalog(int id)
        {
            id = GetCatalogIndexFromId(id);
            return Catalogs[id];
        }
        public IUsersModel GetUser(int id)
        {
            id = GetUsersIndexFromId(id);
            return Users[id];
        }
        public IEventModel GetEvent(int id)
        {
            id = GetEventIndexFromId(id);
            return Events[id];
        }
        public IStateModel GetState(int id)
        {
            id = GetStateIndexFromId(id);
            return States[id];
        }

        public ICatalogModel[] GetAllCatalog()
        {
            return Catalogs.ToArray();
        }
        public IUsersModel[] GetAllUser()
        {
            return Users.ToArray();
        }
        public IEventModel[] GetAllEvent()
        {
            return Events.ToArray();
        }
        public IStateModel[] GetAllState()
        {
            return States.ToArray();
        }

        public void UpdateCatalog(int id, string title, string author, int nOfPages)
        {
            RemoveCatalog(id);
            AddCatalog(id, title, author, nOfPages);
        }
        public void UpdateUser(int id, string fName, string lName)
        {
            RemoveUser(id);
            AddUser(id, fName, lName);
        }
        public void UpdateEvent(int id, int stateId)
        {
            RemoveEvent(id);
            AddEvent(id, stateId);
        }
        public void UpdateState(int id, int nrOfBooks, int catalogId)
        {
            RemoveState(id);
            AddState(id, nrOfBooks, catalogId);
        }

        int GetCatalogIndexFromId(int id)
        {
            int i = 0;
            foreach (TestCatalogModel t in Catalogs)
            {
                if(t.catalogId == i) return i;
                i++;
            }
            return 0;
        }

        int GetUsersIndexFromId(int id)
        {
            int i = 0;
            foreach (TestUsersModel t in Users)
            {
                if (t.userId == i) return i;
                i++;
            }
            return 0;
        }

        int GetEventIndexFromId(int id)
        {
            int i = 0;
            foreach (TestEventModel t in Events)
            {
                if (t.eventId == i) return i;
                i++;
            }
            return 0;
        }

        int GetStateIndexFromId(int id)
        {
            int i = 0;
            foreach (TestStateModel t in States)
            {
                if (t.stateId == i) return i;
                i++;
            }
            return 0;
        }
    }
}
