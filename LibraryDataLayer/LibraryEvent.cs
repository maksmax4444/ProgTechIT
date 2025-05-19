namespace LibraryDataLayer
{
    internal class LibraryEvent : IEvent
    {
        public LibraryEvent(int eventId, LibraryState state)
        {
            this.eventId = eventId;
            this.state = state;
        }
    }
}
