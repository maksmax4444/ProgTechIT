﻿namespace PresentationLayer.Model
{
    public interface ICatalogModel
    {
        public int catalogId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int nrOfPages { get; set; }
    }
}
