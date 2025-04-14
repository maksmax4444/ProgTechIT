using LibraryLogicLayer;
using LibraryDataLayer;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace LogicLayerTest
{
    [TestClass]
    public sealed class LogicTest1
    {
        DataContext InitializeDataContext()
        {
            DataContext context = new DataContext();
            string title = "Alan";
            string author = "Makot";
            int nrOfPages = 68;
            context.AddCatalog(title, author, nrOfPages);

            int nrOfBooks = 68;
            int catalogId = 0;
            context.AddState(nrOfBooks, catalogId);

            string fName = "Alan";
            string lName = "Makot";
            context.AddUser(fName, lName);

            return context;
        }

        [TestMethod]
        public void TestBorrowCatalog()
        {
            DataContext context = InitializeDataContext();
            DataRepository dr = new DataRepository(context);

            dr.BorrowCatalog(0, 0);
            Assert.IsTrue(context.events.Count>0);
        }

        [TestMethod]
        public void TestReturnCatalogEmpty()
        {
            DataContext context = InitializeDataContext();
            DataRepository dr = new DataRepository(context);

            dr.ReturnCatalog(0, 0);
            Assert.IsTrue(context.events.Count > 0);
        }

        [TestMethod]
        public void TestDestroyCatalog()
        {
            DataContext context = InitializeDataContext();
            DataRepository dr = new DataRepository(context);

            dr.DestroyCatalog(0);
            Assert.IsTrue(context.events.Count > 0);
        }

        [TestMethod]
        public void TestAddCatalog()
        {
            DataContext context = InitializeDataContext();
            DataRepository dr = new DataRepository(context);

            dr.AddCatalog(0);
            Assert.IsTrue(context.events.Count > 0);
        }
        [TestMethod]
        public void TestAddNewCatalogType()
        {
            DataContext context = InitializeDataContext();
            DataRepository dr = new DataRepository(context);

            dr.AddNewCatalogType("Alaicja", "Makota", 55);
            Assert.IsTrue(context.catalogs.Count == 2);
        }
    }
}
