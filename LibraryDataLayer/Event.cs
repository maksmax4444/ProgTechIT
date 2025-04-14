namespace LibraryDataLayer
{
    internal class Event
    {
        public int eventId { get; set; }
        public State state { get; set; }

        public Event(int eventId, State state)
        {
            this.eventId = eventId;
            this.state = state;
        }
    }
}
