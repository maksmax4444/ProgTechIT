using PresentationLayer.Model;

namespace PresentationLayerTest
{
    internal class TestEventModel : IEventModel
    {
        public TestEventModel(int eventId, int nrOfBooks)
        {
            this.eventId = eventId;
            this.nrOfBooks = nrOfBooks;
        }

        public int eventId { get; set; }
        public int nrOfBooks { get; set; }
    }
}
