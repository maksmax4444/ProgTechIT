using LibraryDataLayer;

namespace LibraryLogicLayer
{
    internal class DataRepository
    {
        DataContext dataContext = new DataContext();

        void BorrowCatalog(State s, Users u)
        {
            UserEvent userEvent = new UserEvent();
            userEvent.eventId = dataContext.events.Count;
            userEvent.user = u;
            userEvent.state = s;
            userEvent.borrowing = true;
            dataContext.events.Add(userEvent);
        }

        void ReturnCatalog(State s, Users u)
        {
            UserEvent userEvent = new UserEvent();
            userEvent.eventId = dataContext.events.Count;
            userEvent.user = u;
            userEvent.state = s;
            userEvent.borrowing = false;
            dataContext.events.Add(userEvent);
        }

        void DestoryCatalog(State s)
        {
            DatabaseEvent databaseEvent = new DatabaseEvent();
            databaseEvent.eventId = dataContext.events.Count;
            databaseEvent.state = s;
            databaseEvent.addition = true;
            dataContext.events.Add(databaseEvent);
        }

        void AddCatalog(State s)
        {
            DatabaseEvent databaseEvent = new DatabaseEvent();
            databaseEvent.eventId = dataContext.events.Count;
            databaseEvent.state = s;
            databaseEvent.addition = false;
            dataContext.events.Add(databaseEvent);
        }

        public Users GetUsersFromId(int id)
        {
            foreach (Users users in dataContext.users)
            {
                if(users.userId == id) return users;
            }
            throw new Exception("No user with that id in database.");
        }

        public Event GetEventFromId(int id)
        {
            foreach (Event e in dataContext.events)
            {
                if (e.eventId == id) return e;
            }
            throw new Exception("No event with that id in database.");
        }

        public State GetStateFromId(int id)
        {
            foreach (State state in dataContext.states)
            {
                if (state.stateId == id) return state;
            }
            throw new Exception("No state with that id in database.");
        }

        public Catalog GetCatalogFromId(int id)
        {
            foreach (Catalog catalog in dataContext.catalogs)
            {
                if (catalog.catalogId == id) return catalog;
            }
            throw new Exception("No catalog with that id in database.");
        }

    }
}
