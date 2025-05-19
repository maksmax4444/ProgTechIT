using LibraryDataLayer;

namespace LogicLayerTest
{
    internal class TestLibraryCatalog : ICatalog
    {
        public TestLibraryCatalog(int catalogId, string title, string author, int nrOfPages)
        {
            this.catalogId = catalogId;
            this.title = title;
            this.author = author;
            this.nrOfPages = nrOfPages;
        }
    }
}
