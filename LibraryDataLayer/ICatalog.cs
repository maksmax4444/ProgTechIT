﻿namespace LibraryDataLayer
{
    public abstract class ICatalog
    {
        public int catalogId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int nrOfPages { get; set; }
    }
}
