using LibraryDataLayer;
using System.Xml.Serialization;

namespace DataLayerTest
{
    [TestClass]
    public sealed class DataTest1
    {[TestMethod]
        public void CatalogTests()
        {
            IDataContext repo = IDataContext.CreateNewContext(connectionString);
            repo.CleanData();
            Assert.IsNull(repo.GetCatalog(1));
            repo.AddCatalog(1, "TestTitle", "TestAuthor", 66);
            Assert.IsNotNull(repo.GetCatalog(1));
            Assert.IsTrue(repo.GetCatalog(1).title == "TestTitle");
            Assert.IsTrue(repo.GetCatalog(1).author == "TestAuthor");
            Assert.IsTrue(repo.GetCatalog(1).nrOfPages == 66);
            repo.RemoveCatalog(1);
            Assert.IsNull(repo.GetCatalog(1));
            repo.CleanData();
        }
        [TestMethod]
        public void UserTests()
        {
            IDataContext repo = IDataContext.CreateNewContext(connectionString);
            repo.CleanData();
            Assert.IsNull(repo.GetUser(1));
            repo.AddUser(1, "Skibidi", "Sigma");
            Assert.IsNotNull(repo.GetUser(1));
            Assert.IsTrue(repo.GetUser(1).firstName == "Skibidi");
            Assert.IsTrue(repo.GetUser(1).lastName == "Sigma");
            repo.RemoveUser(1);
            Assert.IsNull(repo.GetUser(1));
            repo.CleanData();
        }
        [TestMethod]
        public void EventTests()
        {
            IDataContext repo = IDataContext.CreateNewContext(connectionString);
            repo.CleanData();
            Assert.IsNull(repo.GetEvent(1));
            repo.AddCatalog(2, "TestTitle", "TestAuthor", 66);
            repo.AddState(1, 5, 2);
            repo.AddEvent(1, 1);
            Assert.IsNotNull(repo.GetEvent(1));
            Assert.IsTrue(repo.GetEvent(1).state.nrOfBooks == repo.GetState(1).nrOfBooks);
            repo.RemoveEvent(1);
            repo.RemoveState(1);
            repo.RemoveCatalog(2);
            Assert.IsNull(repo.GetEvent(1));
            repo.CleanData();
        }
        [TestMethod]
        public void StateTests()
        {
            IDataContext repo = IDataContext.CreateNewContext(connectionString);
            repo.CleanData();
            Assert.IsNull(repo.GetState(2));
            repo.AddCatalog(3, "TestTitle", "TestAuthor", 66);
            repo.AddState(2, 5, 3);
            Assert.IsNotNull(repo.GetState(2));
            Assert.IsTrue(repo.GetState(2).nrOfBooks == 5);
            Assert.IsTrue(repo.GetState(2).catalog.title == repo.GetCatalog(3).title);
            repo.RemoveState(2);
            repo.RemoveCatalog(3);
            Assert.IsNull(repo.GetState(2));
            repo.CleanData();
        }

        [TestMethod]
        public void GetAllTest()
        {
            IDataContext repo = IDataContext.CreateNewContext(connectionString);
            repo.CleanData();
            repo.AddCatalog(13, "TestTitle", "TestAuthor", 66);
            repo.AddCatalog(24, "TestTitle", "TestAuthor", 67);
            ICatalog[] array = repo.GetAllCatalog();
            Assert.IsNotNull(array);
            repo.RemoveCatalog(13);
            repo.RemoveCatalog(24);
            repo.CleanData();
        }

        [TestMethod]
        public void OtherGenerationMethod()
        {
            IDataContext repo = IDataContext.CreateNewContext(connectionString);
            repo.CleanData();
            TestDataGenerator.PrepareCatalogData(repo);
            Assert.IsNotNull (repo.GetAllCatalog());
            repo.RemoveCatalog(123);
            repo.CleanData();
        }
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Maksym\\Documents\\ProgTechRepo\\ProgTechIT\\LibraryDataLayer\\LibraryDatabase.mdf;Integrated Security = True";

        
    }
}
