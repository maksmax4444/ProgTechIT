namespace LibraryDataLayer
{
    internal class LibraryCatalog: ICatalog
    {

        public LibraryCatalog(int catalogId, string title, string author, int nrOfPages)
        {
            this.catalogId = catalogId;
            this.title = title;
            this.author = author;
            this.nrOfPages = nrOfPages;
        }
    }
}
