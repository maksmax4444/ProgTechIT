using LibraryLogicLayer;

namespace LogicLayerTest
{
    [TestClass]
    public sealed class LogicTest1
    {

        [TestMethod]
        public void TestBorrowCatalog()
        {
            DataService ds = new DataService();
            try
            {
                ds.BorrowCatalog(1,1);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is NullReferenceException);
            }
        }

        [TestMethod]
        public void TestReturnCatalog()
        {
            DataService ds = new DataService();
            try
            {
                ds.ReturnCatalog(1, 1);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is NullReferenceException);
            }
        }

        [TestMethod]
        public void TestDestroyCatalog()
        {
            DataService ds = new DataService();
            try
            {
                ds.DestoryCatalog(1);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is NullReferenceException);
            }
        }

        [TestMethod]
        public void TestAddCatalog()
        {
            DataService ds = new DataService();
            try
            {
                ds.AddCatalog(1);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is NullReferenceException);
            }
        }
    }
}
