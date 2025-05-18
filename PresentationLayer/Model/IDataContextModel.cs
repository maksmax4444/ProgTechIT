namespace PresentationLayer.Model
{
    internal interface IDataContextModel
    {
        public abstract void AddCatalog(string title, string author, int nrOfPages);
        public abstract void AddUser(string firstName, string lastName);
        public abstract void AddState(int nrOfBooks, int catalogId);
        public abstract void ChangeState(int stateId, int change);
    }
}
