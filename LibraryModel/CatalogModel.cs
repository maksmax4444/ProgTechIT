namespace LibraryModel
{
    class CatalogModel : ICatalogModel
    {
        public CatalogModel(int i, string t, string a, int n)
        {
            catalogId = i;
            title = t;
            author = a;
            nrOfPages = n;
        }
        public int catalogId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int nrOfPages { get; set; }
    }
}
