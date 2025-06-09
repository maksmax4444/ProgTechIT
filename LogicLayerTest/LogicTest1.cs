using LibraryLogicLayer;

namespace LogicLayerTest
{
    [TestClass]
    public sealed class LogicTest1
    {
        
        [TestMethod]
        public void CatalogTests()
        {
            TestDataContext context = new TestDataContext();
            DataService service = new DataService(context);
            service.AddCatalog(0, "t", "a", 1);
            Assert.IsTrue(service.GetCatalog(0).title == "t");
            Assert.IsTrue(service.GetCatalog(0).author == "a");
            Assert.IsTrue(service.GetCatalog(0).nrOfPages == 1);
        }
        [TestMethod]
        public void UserTests()
        {
            TestDataContext context = new TestDataContext();
            DataService service = new DataService(context);
            service.AddUser(0, "f", "l");
            Assert.IsTrue(service.GetUser(0).fName == "f");
            Assert.IsTrue(service.GetUser(0).lName == "l");
        }
        [TestMethod]
        public void EventTests()
        {
            TestDataContext context = new TestDataContext();
            DataService service = new DataService(context);
            service.AddCatalog(0, "t", "a", 1);
            service.AddState(0, 1, 0);
            service.AddEvent(0, 0);
            Assert.IsTrue(service.GetEvent(0).stateId == service.GetState(0).id);
        }
        [TestMethod]
        public void StateTests()
        {
            TestDataContext context = new TestDataContext();
            DataService service = new DataService(context);
            service.AddCatalog(0, "t", "a", 1);
            service.AddState(0, 1, 0);
            Assert.IsTrue(service.GetState(0).noBooks == 1);
            Assert.IsTrue(service.GetState(0).catalogId == service.GetCatalog(0).id);
        }
    }
}
