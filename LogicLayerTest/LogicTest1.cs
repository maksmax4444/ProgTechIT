using LibraryLogicLayer;
using LibraryDataLayer;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace LogicLayerTest
{
    [TestClass]
    public sealed class LogicTest1
    {

        [TestMethod]
        public void TestBorrowCatalog()
        {
            DataRepository dr = new DataRepository();
            Catalog c = new Catalog(0, "TestTitle", "TestAuthor", 10);
            State s = new State(0, 1, c);
            Users u = new Users(0, "Jan", "Kowalski");
            dr.InitRepository();
            dr.dataContext.states.Add(s);
            dr.dataContext.users.Add(u);
            dr.dataContext.catalogs.Add(c);
            try
            {
                dr.BorrowCatalog(0, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            int x = dr.dataContext.states[0].nrOfBooks;
            Assert.IsTrue(x == 0);
        }

        [TestMethod]
        public void TestReturnCatalogEmpty()
        {
            DataRepository dr = new DataRepository();
            dr.InitRepository();
            Catalog c = new Catalog(0, "TestTitle", "TestAuthor", 10);
            dr.dataContext.catalogs.Add(c);
            State s = new State(0, 1, c);
            Users u = new Users(0, "Jan", "Kowalski");
            dr.dataContext.states.Add(s);
            dr.dataContext.users.Add(u);
            try
            {
                dr.ReturnCatalog(0, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.IsTrue(dr.dataContext.events[0] != null);
            Assert.IsTrue(dr.dataContext.events[0].state.nrOfBooks == 2);
            Assert.IsTrue(dr.dataContext.events[0].state == s);
        }

        [TestMethod]
        public void TestDestroyCatalog()
        {
            DataRepository dr = new DataRepository();
            dr.InitRepository();
            Catalog c = new Catalog(0, "TestTitle", "TestAuthor", 10);
            dr.dataContext.catalogs.Add(c);
            State s = new State(0, 1, c);
            dr.dataContext.states.Add(s);
            try
            {
                dr.DestoryCatalog(0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.IsTrue(dr.dataContext.events[0].state.nrOfBooks == 0);
        }

        [TestMethod]
        public void TestAddCatalog()
        {
            DataRepository dr = new DataRepository();
            dr.InitRepository();
            Catalog c = new Catalog(0, "TestTitle", "TestAuthor", 10);
            dr.dataContext.catalogs.Add(c);
            State s = new State(0, 1, c);
            dr.dataContext.states.Add(s);
            try
            {
                dr.AddCatalog(0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.IsTrue(dr.dataContext.events[0].state.nrOfBooks == 2);
        }
        [TestMethod]
        public void TestAddNewCatalogType()
        {
            DataRepository dr = new DataRepository();
            dr.InitRepository();
            string title = "AnimalFarm";
            string author = "Orwell";
            int nrOPages = 100;
            try
            {
                dr.AddNewCatalogType(title, author, nrOPages);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.IsTrue(dr.dataContext.catalogs[0] != null);
            Assert.IsTrue(dr.dataContext.catalogs[0].nrOfPages == 100);
        }
    }
}
