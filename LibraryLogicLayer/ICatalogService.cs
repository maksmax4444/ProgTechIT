namespace LibraryLogicLayer
{
    public interface ICatalogService
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int nrOfPages { get; set; }
    }
}
