using LibraryDataLayer;
using System;

namespace DataLayerTest
{
    internal static class TestDataGenerator
    {
        internal static void PrepareCatalogData(IDataContext c)
        {
             c.AddCatalog(123, "A", "Barbara", 2);
        }

        private class testCatalog : ICatalog
        {
            public int CatalogId { get; set; }
            public string Title { get; set; }
            public string Autor { get; set; }
            public int NrOfPages { get; set; }
            
            public testCatalog(int i, string t, string a, int n)
            {
                CatalogId = i;
                Title = t;
                Autor = a;
                NrOfPages = n;
            }
        }
    }
}
