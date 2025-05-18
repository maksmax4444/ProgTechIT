using LibraryDataLayer;

namespace PresentationLayer.Model
{
    internal class DataContextModel : IDataContextModel
    {
        internal List<CatalogModel> catalogs { get; } = new List<CatalogModel>();
        internal List<EventModel> events { get; } = new List<EventModel>();
        internal List<UsersModel> users { get; } = new List<UsersModel>();
        internal List<StateModel> states { get; } = new List<StateModel>();
        public void AddCatalog(string title, string author, int nrOfPages)
        {
            CatalogModel c = new CatalogModel(catalogs.Count, title, author, nrOfPages);
            catalogs.Add(c);
        }
        public void AddUser(string firstName, string lastName)
        {
            UsersModel u = new UsersModel(users.Count, firstName, lastName);
            users.Add(u);
        }
        public void AddState(int nrOfBooks, int catalogId)
        {
            StateModel s = new StateModel(states.Count, nrOfBooks, GetCatalogFromId(catalogId));
            states.Add(s);
        }

        public void ChangeState(int stateId, int change)
        {
            GetStateFromId(stateId).nrOfBooks += change;
        }

        StateModel GetStateFromId(int id)
        {
            foreach (StateModel state in states)
            {
                if (state.stateId == id) return state;
            }
            throw new Exception("No state with that id in database.");
        }

        CatalogModel GetCatalogFromId(int id)
        {
            foreach (CatalogModel catalog in catalogs)
            {
                if (catalog.catalogId == id) return catalog;
            }
            throw new Exception("No catalog with that id in database.");
        }
    }
}
