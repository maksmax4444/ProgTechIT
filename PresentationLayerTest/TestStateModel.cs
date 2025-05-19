using PresentationLayer.Model;

namespace PresentationLayerTest
{
    internal class TestStateModel : IStateModel
    {
        public TestStateModel(int stateId, int nrOfBooks, int catalog)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalog = catalog;
        }

        public int stateId { get; set; }
        public int nrOfBooks { get; set; }
        public int catalog { get; set; }
    }
}
