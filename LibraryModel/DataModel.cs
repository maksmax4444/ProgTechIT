using LibraryLogicLayer;

namespace LibraryModel
{
    class DataModel : IDataModel
    {
        //Conversion
        private CatalogModel CatalogModelConversion(ICatalogService c) => new CatalogModel(c.id, c.title, c.author, c.nrOfPages);
        private UserModel UserModelConversion(IUserService c) => new UserModel(c.id, c.fName, c.lName);
        private EventModel EventModelConversion(IEventService c) => new EventModel(c.id, c.stateId);
        private StateModel StateModelConversion(IStateService c) => new StateModel(c.id, c.noBooks, c.catalogId);

        static IDataService _service;
        string c = "";

        public DataModel()
        {
            _service = IDataService.CreateNewDataService();
        }

        public DataModel(IDataService s)
        {
            _service = s;
        }
        public void AddCatalog(int id, string title, string author, int nOfPages) 
        {
            if (c == "") return;
            _service.AddCatalog(id, title, author, nOfPages);
        }
        public void AddUser(int id, string fName, string lName)
        {
            if (c == "") return;
            _service.AddUser(id, fName, lName);
        }
        public void AddEvent(int id, int stateId)
        {
            if (c == "") return;
            _service.AddEvent(id, stateId);
        }
        public void AddState(int id, int nrOfBooks, int catalogId)
        {
            if (c == "") return;
            _service.AddState(id, nrOfBooks, catalogId);
        }

        public void RemoveCatalog(int id)
        {
            if (c == "") return;
            _service.RemoveCatalog(id);
        }
        public void RemoveUser(int id)
        {
            if (c == "") return;
            _service.RemoveUser(id);
        }
        public void RemoveEvent(int id)
        {
            if (c == "") return;
            _service.RemoveEvent(id);
        }
        public void RemoveState(int id)
        {
            if (c == "") return;
            _service.RemoveState(id);
        }

        public ICatalogModel GetCatalog(int id)
        {
            return CatalogModelConversion(_service.GetCatalog(id));
        }
        public IUsersModel GetUser(int id)
        {
            return UserModelConversion(_service.GetUser(id));
        }
        public IEventModel GetEvent(int id)
        {
            return EventModelConversion(_service.GetEvent(id));
        }
        public IStateModel GetState(int id)
        {
            return StateModelConversion(_service.GetState(id));
        }

        public ICatalogModel[] GetAllCatalog() {
            List<ICatalogModel> catalogList = new List<ICatalogModel>();
            foreach (ICatalogService c in _service.GetAllCatalog())
            {
                catalogList.Add(CatalogModelConversion(c));
            }
            return catalogList.ToArray();
        }
        public IUsersModel[] GetAllUser() {
            List<IUsersModel> catalogList = new List<IUsersModel>();
            foreach (IUserService c in _service.GetAllUser())
            {
                catalogList.Add(UserModelConversion(c));
            }
            return catalogList.ToArray();
        }
        public IEventModel[] GetAllEvent() {
            List<IEventModel> catalogList = new List<IEventModel>();
            foreach (IEventService c in _service.GetAllEvent())
            {
                catalogList.Add(EventModelConversion(c));
            }
            return catalogList.ToArray();
        }
        public IStateModel[] GetAllState() {
            List<IStateModel> catalogList = new List<IStateModel>();
            foreach (IStateService c in _service.GetAllState())
            {
                catalogList.Add(StateModelConversion(c));
            }
            return catalogList.ToArray();
        }

        public void UpdateCatalog(int id, string title, string author, int nOfPages) {
            if (c == "") return;
            _service.UpdateCatalog(id, title, author, nOfPages);
        }
        public void UpdateUser(int id, string fName, string lName) {
            if (c == "") return;
            _service.UpdateUser(id, fName, lName);
        }
        public void UpdateEvent(int id, int stateId) {
            if (c == "") return;
            _service.UpdateEvent(id, stateId);
        }
        public void UpdateState(int id, int nrOfBooks, int catalogId)
        {
            if (c == "") return;
            _service.UpdateState(id, nrOfBooks, catalogId);
        }

    }
}
