using Microsoft.Extensions.Logging;

namespace LibraryDataLayer
{
    internal class LibraryEvent : IEvent
    {
        public int eventId {  get; set; }
        public IState state {  get; set; }

        public LibraryEvent(int eventId, LibraryState state)
        {
            this.eventId = eventId;
            this.state = state;
        }
    }
}
