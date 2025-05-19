using PresentationLayer.Model;

namespace PresentationLayerTest
{
    internal class TestEventModel : IEventModel
    {
        public TestEventModel(int eventId, int state)
        {
            this.eventId = eventId;
            this.state = state;
        }

        public int eventId { get; set; }
        public int state { get; set; }
    }
}
