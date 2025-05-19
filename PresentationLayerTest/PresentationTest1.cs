using LibraryDataLayer;
using LibraryLogicLayer;
using PresentationLayer;

namespace PresentationLayerTest
{
    [TestClass]
    public sealed class PresentationTest1
    {
        [TestMethod]
        public void CatalogModuleTest()
        {
            TestCatalogModel t = new TestCatalogModel(0, "TestCatalog", "TestAuthor", 10);
            Assert.IsTrue(t.nrOfPages == 10);
            Assert.IsTrue(t.catalogId == 0);
            Assert.IsTrue(t.title == "TestCatalog");
        }
        [TestMethod]
        public void UserModuleTest()
        {
            TestUserModel t = new TestUserModel(0, "TestName", "TestLastName");
            Assert.IsTrue(t.userId == 0);
            Assert.IsTrue(t.firstName == "TestName");
            Assert.IsTrue(t.lastName == "TestLastName");
        }
        [TestMethod]
        public void EventModuleTest()
        {
            TestEventModel t = new TestEventModel(0, 10);
            Assert.IsTrue(t.eventId == 0);
            Assert.IsTrue(t.state == 10);
        }
        [TestMethod]
        public void StateModuleTest()
        {
            TestStateModel t = new TestStateModel(0, 1, 5);
            Assert.IsTrue(t.stateId == 0);
            Assert.IsTrue(t.nrOfBooks == 1);
            Assert.IsTrue(t.catalog == 5);
        }
    }
}
