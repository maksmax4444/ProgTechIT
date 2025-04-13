using LibraryDataLayer;

namespace LibraryLogicLayer
{
    public class DataRepository
    {
        public DataContext dataContext;
        public void initRepository() 
        {
            List<Catalog> catalogList = new List<Catalog>();
            List<State> stateList = new List<State>();
            List<Users> usersList = new List<Users>();
            List<Event> eventList = new List<Event>();
            dataContext = new DataContext(catalogList, eventList, usersList, stateList);
        }

        public void BorrowCatalog(int stateId, int userId)
        {
            Users u = GetUsersFromId(userId);
            State s = GetStateFromId(stateId);
            s.nrOfBooks--;
            if (s.nrOfBooks < 0) 
            {
                s.nrOfBooks = 0;
                throw new Exception("Not enought books to borrow!");
            }
            UserEvent userEvent = new UserEvent(dataContext.events.Count, s, u, true);
            dataContext.events.Add(userEvent);
        }

         public void ReturnCatalog(int stateId, int userId)
        {
            Users u = GetUsersFromId(userId);
            State s = GetStateFromId(stateId);
            s.nrOfBooks++;
            UserEvent userEvent = new UserEvent(dataContext.events.Count, s, u, true);
            dataContext.events.Add(userEvent);
        }

        public void DestoryCatalog(int stateId)
        {
            State s = GetStateFromId(stateId);
            s.nrOfBooks--;
            if (s.nrOfBooks < 0)
            {
                throw new Exception("Not enought books to destroy!");
            }
            DatabaseEvent databaseEvent = new DatabaseEvent(dataContext.events.Count, s, true);
            dataContext.events.Add(databaseEvent);
        }

        public void AddCatalog(int stateId)
        {
            State s = GetStateFromId(stateId);
            s.nrOfBooks++;
            DatabaseEvent databaseEvent = new DatabaseEvent(dataContext.events.Count, s, true);
            dataContext.events.Add(databaseEvent);
        }

        public void AddNewCatalogType(string title, string author, int nrOfPages)
        {
            Catalog c = new Catalog(dataContext.catalogs.Count, title, author, nrOfPages);
            dataContext.catalogs.Add(c);
            State s = new State(dataContext.states.Count, 0, c);
            dataContext.states.Add(s);
        }

        Users GetUsersFromId(int id)
        {
            foreach (Users users in dataContext.users)
            {
                if(users.userId == id) return users;
            }
            throw new Exception("No user with that id in database.");
        }

        Event GetEventFromId(int id)
        {
            foreach (Event e in dataContext.events)
            {
                if (e.eventId == id) return e;
            }
            throw new Exception("No event with that id in database.");
        }

        State GetStateFromId(int id)
        {
            foreach (State state in dataContext.states)
            {
                if (state.stateId == id) return state;
            }
            throw new Exception("No state with that id in database.");
        }

        Catalog GetCatalogFromId(int id)
        {
            foreach (Catalog catalog in dataContext.catalogs)
            {
                if (catalog.catalogId == id) return catalog;
            }
            throw new Exception("No catalog with that id in database.");
        }

    }
}
