using LibraryDataLayer;

namespace LogicLayerTest
{
    internal class TestLibraryEvent : IEvent
    {
        public TestLibraryEvent(int eventId, TestLibraryState state)
        {
            this.eventId = eventId;
            this.state = state;
        }
    }
}
