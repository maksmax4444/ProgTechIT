namespace PresentationLayer.Model
{
    internal class StateModel : IStateModel
    {
        public StateModel(int stateId, int nrOfBooks, int catalog)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalog = catalog;
        }
    }
}
