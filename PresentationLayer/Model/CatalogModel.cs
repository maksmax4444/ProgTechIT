﻿namespace PresentationLayer.Model
{
    internal class CatalogModel : ICatalogModel
    {
        public CatalogModel(int catalogId, string title, string author, int nrOfPages)
        {
            this.catalogId = catalogId;
            this.title = title;
            this.author = author;
            this.nrOfPages = nrOfPages;
        }

        public int catalogId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int nrOfPages { get; set; }
    }
}
