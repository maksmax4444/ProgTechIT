namespace LibraryLogicLayer
{
    internal class CatalogService : ICatalogService
    {
        public CatalogService(int i, string t, string a, int n)
        {
            id = i;
            title = t;
            author = a;
            nrOfPages = n;
        }
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int nrOfPages { get; set; }
    }
}
