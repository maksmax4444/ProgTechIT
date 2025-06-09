using LibraryModel;

namespace PresentationLayerTest
{
    internal class TestStateModel :IStateModel
    {
        public TestStateModel(int i, int n, int c)
        {
            stateId = i;
            nrOfBooks = n;
            catalogId = c;
        }
        public int stateId { get; set; }
        public int nrOfBooks { get; set; }
        public int catalogId { get; set; }
    }
}
