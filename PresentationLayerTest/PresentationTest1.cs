using LibraryViewModel;

namespace PresentationLayerTest
{
    [TestClass]
    public sealed class PresentationTest1
    {
        [TestMethod]
        public void CatalogCollectionTest()
        {
            TestDataModel model = new TestDataModel();
            CatalogViewModelCollection vm = new CatalogViewModelCollection(model);
            vm.CatalogId = 0;
            vm.Title = "Title";
            vm.Author = "Author";
            vm.NrOfPages = 1;
            vm.add();
            Assert.IsTrue(model.GetAllCatalog().Length == 1);
            vm.delete();
            Assert.IsTrue(model.GetAllCatalog().Length == 0);
        }
        [TestMethod]
        public void UsersCollectionTest()
        {
            TestDataModel model = new TestDataModel();
            UsersViewModelCollection vm = new UsersViewModelCollection(model);
            vm.UserId = 0;
            vm.FirstName = "f";
            vm.LastName = "l";
            vm.add();
            Assert.IsTrue(model.GetAllUser().Length == 1);
            vm.delete();
            Assert.IsTrue(model.GetAllUser().Length == 0);
        }
        [TestMethod]
        public void EventCollectionTest()
        {
            TestDataModel model = new TestDataModel();
            EventViewModelCollection vm = new EventViewModelCollection(model);
            vm.EventId = 0;
            vm.NrOfBooks = 1;
            vm.add();
            Assert.IsTrue(model.GetAllEvent().Length == 1);
            vm.delete();
            Assert.IsTrue(model.GetAllEvent().Length == 0);
        }
        [TestMethod]
        public void StateCollectionTest()
        {
            TestDataModel model = new TestDataModel();
            StateViewModelCollection vm = new StateViewModelCollection(model);
            vm.StateId = 0;
            vm.Catalog = 1;
            vm.add();
            Assert.IsTrue(model.GetAllState().Length == 1);
            vm.delete();
            Assert.IsTrue(model.GetAllState().Length == 0);
        }
    }
}
