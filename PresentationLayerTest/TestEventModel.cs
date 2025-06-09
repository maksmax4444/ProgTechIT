using LibraryModel;

namespace PresentationLayerTest
{
    internal class TestEventModel: IEventModel
    {
        public TestEventModel(int i, int s)
        {
            eventId = i;
            nrOfBooks = s;
        }
        public int eventId { get; set; }
        public int nrOfBooks { get; set; }
    }
}
