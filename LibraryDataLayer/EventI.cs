namespace LibraryDataLayer
{
    public abstract class EventI
    {
        public int eventId { get; set; }
        public StateI state { get; set; }
    }
}
