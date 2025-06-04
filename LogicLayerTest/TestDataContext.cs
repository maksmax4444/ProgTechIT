using LibraryDataLayer;
using Microsoft.EntityFrameworkCore;

namespace LogicLayerTest
{
    internal class TestDataContext: IDataContext
    {
        //lists
        internal List<TestLibraryCatalog> catalogs { get; } = new List<TestLibraryCatalog>();
        internal List<TestLibraryEvent> events { get; } = new List<TestLibraryEvent>();
        internal List<TestLibraryUser> users { get; } = new List<TestLibraryUser>();
        internal List<TestLibraryState> states { get; } = new List<TestLibraryState>();

        //add methods
        public void AddCatalog(int id, string title, string author, int nrOfPages)
        {
            TestLibraryCatalog c = new TestLibraryCatalog(id, title, author, nrOfPages);
            catalogs.Add(c);
        }

        public void AddUser(int id, string firstName, string lastName)
        {
            TestLibraryUser u = new TestLibraryUser(id, firstName, lastName);
            users.Add(u);
        }
        public void AddEvent(int id, int stateId)
        {
            TestLibraryEvent e = new TestLibraryEvent(id, GetStateFromId(stateId));
            events.Add(e);
        }
        public void AddState(int id, int nrOfBooks, int catalogId)
        {
            TestLibraryState s = new TestLibraryState(id, nrOfBooks, GetCatalogFromId(catalogId));
            states.Add(s);
        }

        //remove methods
        public void RemoveCatalog(int id)
        {
            catalogs.Remove(GetCatalogFromId(id));
        }

        public void RemoveUser(int id)
        {
            users.Remove(GetUsersFromId(id));
        }

        public void RemoveEvent(int id)
        {
            events.Remove(GetEventFromId(id));
        }

        public void RemoveState(int id)
        {
            states.Remove(GetStateFromId(id));
        }

        //get methods
        public ICatalog? GetCatalog(int id)
        {
            return GetCatalogFromId(id);
        }
        public IUser? GetUser(int id)
        {
            return GetUsersFromId(id);
        }
        public IEvent? GetEvent(int id)
        {
            return GetEventFromId(id);
        }
        public IState? GetState(int id)
        {
            return GetStateFromId(id);
        }

        public ICatalog[]? GetAllCatalog()
        {
            return catalogs.ToArray();
        }
        public IUser[]? GetAllUser()
        {
            return users.ToArray();
        }
        public IEvent[]? GetAllEvent()
        {
            return events.ToArray();
        }
        public IState[]? GetAllState()
        {
            return states.ToArray();
        }

        //private get from id methods
        TestLibraryUser GetUsersFromId(int id)
        {
            foreach (TestLibraryUser users in users)
            {
                if (users.userId == id) return users;
            }
            return users[0];
        }

        TestLibraryEvent GetEventFromId(int id)
        {
            foreach (TestLibraryEvent e in events)
            {
                if (e.eventId == id) return e;
            }
            return events[0];
        }

        TestLibraryState GetStateFromId(int id)
        {
            foreach (TestLibraryState state in states)
            {
                if (state.stateId == id) return state;
            }
            return states[0];
        }

        TestLibraryCatalog GetCatalogFromId(int id)
        {
            foreach (TestLibraryCatalog catalog in catalogs)
            {
                if (catalog.catalogId == id) return catalog;
            }
            return catalogs[0];
        }
        
        public void CleanData()
        {
            catalogs.Clear();
            users.Clear();
            events.Clear();
            states.Clear();
        }
    }
}
