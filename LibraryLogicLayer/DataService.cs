using LibraryDataLayer;
using System.Data.Linq.SqlClient;
using System.Diagnostics;

namespace LibraryLogicLayer
{
    internal class DataService: IDataService
    {
        static IDataContext _context;

        public DataService()
        {
            _context = IDataContext.CreateNewContext();
        }

        public DataService(IDataContext dataContext)
        {
            _context = dataContext;
        }
        //conversions
        private CatalogService CatalogServiceConversion(ICatalog c) => new CatalogService(c.catalogId, c.title, c.author, c.nrOfPages);
        private UserService UserServiceConversion(IUser c) => new UserService(c.userId, c.firstName, c.lastName);
        private EventService EventServiceConversion(IEvent c) => new EventService(c.eventId, c.state.stateId, 0);
        private StateService StateServiceConversion(IState c) => new StateService(c.stateId, c.nrOfBooks, c.catalog.catalogId);

        //Create
        public void AddCatalog(int id, string title, string author, int nOfPages)
        {
            _context.AddCatalog(id, title, author, nOfPages);
        }
        public void AddUser(int id, string fName, string lName)
        {
            _context.AddUser(id, fName, lName);
        }
        public void AddUserEvent(int id, int stateId, int userId)
        {
            _context.AddUserEvent(id, stateId, userId);
        }
        public void AddDatabaseEvent(int id, int stateId)
        {
            _context.AddDatabaseEvent(id, stateId);
        }
        public void AddState(int id, int nrOfBooks, int catalogId)
        {
            _context.AddState(id, nrOfBooks, catalogId);
        }
        //Delete
        public void RemoveCatalog(int id)
        {
            _context.RemoveCatalog(id);
        }
        public void RemoveUser(int id)
        {
            _context.RemoveUser(id);
        }
        public void RemoveEvent(int id)
        {
            _context.RemoveEvent(id);
        }
        public void RemoveState(int id)
        {
            _context.RemoveState(id);
        }
        //Read
        public ICatalogService GetCatalog(int id)
        {
            return CatalogServiceConversion(_context.GetCatalog(id));
        }
        public IUserService GetUser(int id)
        {
            return UserServiceConversion(_context.GetUser(id));
        }
        public IEventService GetEvent(int id)
        {
            return EventServiceConversion(_context.GetEvent(id));
        }
        public IStateService GetState(int id)
        {
            return StateServiceConversion(_context.GetState(id));
        }
        //Update
        public void UpdateCatalog(int id, string title, string author, int nOfPages)
        {
            _context.RemoveCatalog(id);
            _context.AddCatalog(id, title, author, nOfPages);
        }
        public void UpdateUser(int id, string fName, string lName)
        {
            _context.RemoveUser(id);
            _context.AddUser(id, fName, lName);
        }
        public void UpdateEvent(int id, int stateId)
        {
            _context.RemoveEvent(id);
            _context.AddDatabaseEvent(id, stateId);
        }
        public void UpdateState(int id, int nrOfBooks, int catalogId)
        {
            _context.RemoveState(id);
            _context.AddState(id, nrOfBooks, catalogId);
        }
    }
}
