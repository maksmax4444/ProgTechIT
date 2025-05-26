using LibraryDataLayer;

namespace LogicLayerTest
{
    internal class TestLibraryEvent : IEvent
    {
        public int eventId { get; set; }
        public IState state { get; set; }

        public TestLibraryEvent(int eventId, TestLibraryState state)
        {
            this.eventId = eventId;
            this.state = state;
        }
    }
}
