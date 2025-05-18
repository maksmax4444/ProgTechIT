namespace PresentationLayer.Model
{
    internal class IStateModel
    {
        public int stateId { get; set; }
        public int nrOfBooks { get; set; }
        public ICatalogModel catalog { get; set; }
    }
}
