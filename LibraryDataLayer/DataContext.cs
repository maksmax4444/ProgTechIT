using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataLayer
{
    public class DataContext : DataContextI
    {
        internal List<Catalog> catalogs { get; } = new List<Catalog>();
        internal List<Event> events { get; } = new List<Event>();
        internal List<Users> users { get; } = new List<Users>();
        internal List<State> states { get; } = new List<State>();

        public override void AddCatalog(string title, string author, int nrOfPages)
        {
            Catalog c = new Catalog(catalogs.Count, title, author, nrOfPages);
            catalogs.Add(c);
        }
        public override void AddUser(string firstName, string lastName)
        {
            Users u = new Users(users.Count, firstName, lastName);
            users.Add(u);
        }
        public override void AddUserEvent(int stateId, int userId)
        {
            UserEvent e = new UserEvent(events.Count, GetStateFromId(stateId), GetUsersFromId(userId));
            events.Add(e);
        }
        public override void AddDatabaseEvent(int stateId)
        {
            DatabaseEvent e = new DatabaseEvent(events.Count, GetStateFromId(stateId));
            events.Add(e);
        }
        public override void AddState(int nrOfBooks, int catalogId)
        {
            State s = new State(states.Count, nrOfBooks, GetCatalogFromId(catalogId));
            states.Add(s);
        }

        public override void ChangeState(int stateId, int change)
        {
            GetStateFromId(stateId).nrOfBooks += change;
        }

        Users GetUsersFromId(int id)
        {
            foreach (Users users in users)
            {
                if (users.userId == id) return users;
            }
            throw new Exception("No user with that id in database.");
        }

        Event GetEventFromId(int id)
        {
            foreach (Event e in events)
            {
                if (e.eventId == id) return e;
            }
            throw new Exception("No event with that id in database.");
        }

        State GetStateFromId(int id)
        {
            foreach (State state in states)
            {
                if (state.stateId == id) return state;
            }
            throw new Exception("No state with that id in database.");
        }

        Catalog GetCatalogFromId(int id)
        {
            foreach (Catalog catalog in catalogs)
            {
                if (catalog.catalogId == id) return catalog;
            }
            throw new Exception("No catalog with that id in database.");
        }
    }
}
