using LibraryDataLayer;

namespace DataLayerTest
{
    internal class Catalog: CatalogI
    {
        public Catalog(int catalogId, string title, string author, int nrOfPages)
        {
            this.catalogId = catalogId;
            this.title = title;
            this.author = author;
            this.nrOfPages = nrOfPages;
        }
    }
}
