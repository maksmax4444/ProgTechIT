using PresentationLayer.ViewModel;

namespace PresentationLayerTest
{
    [TestClass]
    public sealed class PresentationTest1
    {
        [TestMethod]
        public void CatalogModuleTest()
        {
            CatalogViewModel t = new CatalogViewModel(0, "TestCatalog", "TestAuthor", 10);
            Assert.IsTrue(t.NrOfPages == 10);
            Assert.IsTrue(t.CatalogId == 0);
            Assert.IsTrue(t.Title == "TestCatalog");
        }
        [TestMethod]
        public void UserModuleTest()
        {
            UsersViewModel t = new UsersViewModel(0, "TestName", "TestLastName");
            Assert.IsTrue(t.UserId == 0);
            Assert.IsTrue(t.FirstName == "TestName");
            Assert.IsTrue(t.LastName == "TestLastName");
        }
        [TestMethod]
        public void EventModuleTest()
        {
            EventViewModel t = new EventViewModel(0, 10);
            Assert.IsTrue(t.EventId == 0);
            Assert.IsTrue(t.NrOfBooks == 10);
        }
        [TestMethod]
        public void StateModuleTest()
        {
            StateViewModel t = new StateViewModel(0, 1, 5);
            Assert.IsTrue(t.StateId == 0);
            Assert.IsTrue(t.NrOfBooks == 1);
            Assert.IsTrue(t.CatalogId == 5);
        }
    }
}
