using LibraryLogicLayer;
using LibraryDataLayer;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace LogicLayerTest
{
    [TestClass]
    public sealed class Test1
    {

        [TestMethod]
        public void testBorrowCatalogEmpty()
        {
            DataRepository dr = new DataRepository();
            Catalog c = new Catalog(0, "TestTitle", "TestAuthor", 10);
            State s = new State(0, 1, c);
            Users u = new Users(0, "Jan", "Kowalski");
            dr.initRepository();
            dr.dataContext.states.Add(s);
            dr.dataContext.users.Add(u);
            dr.dataContext.catalogs.Add(c);
            try
            {
                dr.BorrowCatalog(0, 0);
            }
            catch (Exception e)
            { 
            }
            int x = dr.dataContext.states[0].nrOfBooks;
            Assert.IsTrue(x == 0);
        }
    }
}
