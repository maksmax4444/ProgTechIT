namespace LibraryDataLayer
{
    public abstract class StateI
    {
        public int stateId { get; set; }
        public int nrOfBooks { get; set; }
        public CatalogI catalog { get; set; }
    }
}
