namespace LibraryDataLayer
{
    public interface IEvent
    {
        public int eventId { get; set; }
        public IState state { get; set; }
    }
}
