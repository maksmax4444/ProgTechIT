namespace LibraryDataLayer
{
    public abstract class IState
    {
        public int stateId { get; set; }
        public int nrOfBooks { get; set; }
        public ICatalog catalog { get; set; }
    }
}
