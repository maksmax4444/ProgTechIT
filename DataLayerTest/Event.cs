using LibraryDataLayer;

namespace DataLayerTest
{
    internal class Event : EventI
    {
        public Event(int eventId, State state)
        {
            this.eventId = eventId;
            this.state = state;
        }
    }
}
