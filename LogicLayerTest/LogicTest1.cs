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
            IDataService service = IDataService.CreateNewDataService(context);
            service.AddCatalog(0, "TestTitle", "TestAuthor", 66);
            Assert.IsTrue(service.GetCatalog(0).title == "TestTitle");
            Assert.IsTrue(service.GetCatalog(0).author == "TestAuthor");
            Assert.IsTrue(service.GetCatalog(0).nrOfPages == 66);
        }
        [TestMethod]
        public void UserTests()
        {
            TestDataContext context = new TestDataContext();
            IDataService service = IDataService.CreateNewDataService(context);
            service.AddUser(0, "TestFirstName", "TestLastName");
            Assert.IsTrue(service.GetUser(0).fName == "TestFirstName");
            Assert.IsTrue(service.GetUser(0).lName == "TestLastName");
        }
        [TestMethod]
        public void EventTests()
        {
            TestDataContext context = new TestDataContext();
            IDataService service = IDataService.CreateNewDataService(context);
            service.AddCatalog(0, "TestTitle", "TestAuthor", 66);
            service.AddState(0, 5, 0);
            service.AddEvent(0, 0);
            Assert.IsTrue(service.GetEvent(0).stateId == service.GetState(0).id);
        }
        [TestMethod]
        public void StateTests()
        {
            TestDataContext context = new TestDataContext();
            IDataService service = IDataService.CreateNewDataService(context);
            service.AddCatalog(0, "TestTitle", "TestAuthor", 66);
            service.AddState(0, 5, 0);
            Assert.IsTrue(service.GetState(0).noBooks == 5);
            Assert.IsTrue(service.GetState(0).catalogId == service.GetCatalog(0).id);
        }
    }
}
