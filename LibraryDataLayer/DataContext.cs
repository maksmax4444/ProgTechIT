using Microsoft.EntityFrameworkCore;

namespace LibraryDataLayer
{
    internal class DataContext : DbContext, IDataContext
    {
        private LibraryDataLinqClassesDataContext _context;
            
        public DataContext(string? customConnectionString = null)
        {
            if (customConnectionString != null)
            {
                _context = new LibraryDataLinqClassesDataContext(customConnectionString);
            }
            else
            {
                _context = new LibraryDataLinqClassesDataContext();
            }
        }

        //lists
        internal List<LibraryCatalog> catalogs { get; } = new List<LibraryCatalog>();
        internal List<LibraryEvent> events { get; } = new List<LibraryEvent>();
        internal List<LibraryUser> users { get; } = new List<LibraryUser>();
        internal List<LibraryState> states { get; } = new List<LibraryState>();

        //add methods
        public void AddCatalog(int id, string title, string author, int nrOfPages)
        {
            LibraryCatalog c = new LibraryCatalog(id, title, author, nrOfPages);
            catalogs.Add(c);
            Catalog dbEntry = new() { catalogId = id, title = c.title, author = c.author, nrOfPages = c.nrOfPages };
            _context.Catalogs.InsertOnSubmit(dbEntry);
            _context.SubmitChanges();
        }

        public void AddUser(int id, string firstName, string lastName)
        {
            LibraryUser u = new LibraryUser(id, firstName, lastName);
            users.Add(u);
            User dbEntry = new() { userId = id, firstName = u.firstName, lastName = u.lastName };
            _context.Users.InsertOnSubmit(dbEntry);
            _context.SubmitChanges();
        }
        public void AddEvent(int id, int stateId)
        {
            LibraryEvent e = new LibraryEvent(id, GetStateFromId(stateId));
            events.Add(e);
            Event dbEntry = new() { eventId = id, StateId = e.state.stateId};
            _context.Events.InsertOnSubmit(dbEntry);
            _context.SubmitChanges();
        }
        public void AddState(int id, int nrOfBooks, int catalogId)
        {
            LibraryState s = new LibraryState(id, nrOfBooks, GetCatalogFromId(catalogId));
            states.Add(s);
            State dbEntry = new() { StateId = id, NrOfBooks = s.nrOfBooks, catalogId = s.catalog.catalogId };
            _context.States.InsertOnSubmit(dbEntry);
            _context.SubmitChanges();
        }

        //remove methods
        public void RemoveCatalog(int id)
        {
            Catalog dbEntry = _context.Catalogs.Single(entry => entry.catalogId == id);
            _context.Catalogs.DeleteOnSubmit(dbEntry);
            _context.SubmitChanges();
        }

        public void RemoveUser(int id)
        {
            User dbEntry = _context.Users.Single(entry => entry.userId == id);
            _context.Users.DeleteOnSubmit(dbEntry);
            _context.SubmitChanges();
        }

        public void RemoveEvent(int id)
        {
            Event dbEntry = _context.Events.Single(entry => entry.eventId == id);
            _context.Events.DeleteOnSubmit(dbEntry);
            _context.SubmitChanges();
        }

        public void RemoveState(int id)
        {
            State dbEntry = _context.States.Single(entry => entry.StateId == id);
            _context.States.DeleteOnSubmit(dbEntry);
            _context.SubmitChanges();
        }

        //get methods
        public ICatalog? GetCatalog(int id)
        {
            var catalogQuery = _context.Catalogs.ToArray().Where<Catalog>(cat => cat.catalogId == id).Select<Catalog, Catalog>(cat => cat).SingleOrDefault<Catalog>();
            if (catalogQuery == null)
            {
                return null;
            }
            else
            {
                return new LibraryCatalog(catalogQuery.catalogId, catalogQuery.title, catalogQuery.author, catalogQuery.nrOfPages);
            }
        }
        public IUser? GetUser(int id)
        {
            var entity = (from User
                       in _context.Users
                       where User.userId == id
                       select User).FirstOrDefault();
            if (entity == null)
            {
                return null;
            }
            else
            {
                return new LibraryUser(entity.userId, entity.firstName, entity.lastName);
            }
        }
        public IEvent? GetEvent(int id)
        {
            var entity = (from Event
                       in _context.Events
                          where Event.eventId == id
                          select Event).FirstOrDefault();
            if (entity == null)
            {
                return null;
            }
            else
            {
                return new LibraryEvent(entity.eventId, GetStateFromId(entity.StateId));
            }
        }
        public IState? GetState(int id)
        {
            var entity = (from State
                       in _context.States
                          where State.StateId == id
                          select State).FirstOrDefault();
            if (entity == null)
            {
                return null;
            }
            else
            {
                return new LibraryState(entity.StateId, entity.NrOfBooks, GetCatalogFromId((int)entity.catalogId));
            }
        }

        //private get from id methods
        LibraryUser GetUsersFromId(int id)
        {
            foreach (LibraryUser users in users)
            {
                if (users.userId == id) return users;
            }
            throw new Exception("No user with that id in database.");
        }

        LibraryEvent GetEventFromId(int id)
        {
            foreach (LibraryEvent e in events)
            {
                if (e.eventId == id) return e;
            }
            throw new Exception("No event with that id in database.");
        }

        LibraryState GetStateFromId(int id)
        {
            foreach (LibraryState state in states)
            {
                if (state.stateId == id) return state;
            }
            throw new Exception("No state with that id in database.");
        }

        LibraryCatalog GetCatalogFromId(int id)
        {
            foreach (LibraryCatalog catalog in catalogs)
            {
                if (catalog.catalogId == id) return catalog;
            }
            throw new Exception("No catalog with that id in database.");
        }
        public void CleanData()
        {
            _context.ExecuteCommand("DELETE FROM Events");
            _context.ExecuteCommand("DELETE FROM States");
            _context.ExecuteCommand("DELETE FROM Users");
            _context.ExecuteCommand("DELETE FROM Catalogs");
        }
    }
}
