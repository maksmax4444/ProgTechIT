using LibraryDataLayer;

namespace DataLayerTest;

[TestClass]
public class DataAPITest
{
    /*
    [TestMethod]
    public void TestAddCatalog()
    {
        DataContext context = new DataContext();

        string title = "Alan";
        string author = "Makot"; 
        int nrOfPages = 68;
        context.AddCatalog(title, author, nrOfPages);
        Assert.IsTrue(context.catalogs[0].title == "Alan");
    }

    [TestMethod]
    public void TestAddUsers()
    {
        DataContext context = new DataContext();

        string fName = "Alan";
        string lName = "Makot";
        context.AddUser(fName, lName);
        Assert.IsTrue(context.users[0].firstName == "Alan");
    }

    [TestMethod]
    public void TestAddState()
    {
        DataContext context = new DataContext();

        string title = "Alan";
        string author = "Makot";
        int nrOfPages = 68;
        context.AddCatalog(title, author, nrOfPages);

        int nrOfBooks = 68;
        int catalogId = 0; 
        context.AddState(nrOfBooks, catalogId);
        Assert.IsTrue(context.catalogs[0].title == "Alan");
    }

    [TestMethod]
    public void TestAddUserEvent()
    {
        DataContext context = new DataContext();

        string title = "Alan";
        string author = "Makot";
        int nrOfPages = 68;
        context.AddCatalog(title, author, nrOfPages);

        int nrOfBooks = 68;
        context.AddState(nrOfBooks, 0);

        string fName = "Alicja";
        string lName = "Makota";
        context.AddUser(fName, lName);
        context.AddUserEvent(0,0);
        Assert.IsTrue(context.events[0].state.nrOfBooks == 68);
    }

    [TestMethod]
    public void TestAddDatabaseEvent()
    {
        DataContext context = new DataContext();

        string title = "Alan";
        string author = "Makot";
        int nrOfPages = 68;
        context.AddCatalog(title, author, nrOfPages);

        int nrOfBooks = 68;
        context.AddState(nrOfBooks, 0);
        
        context.AddDatabaseEvent(0);
        Assert.IsTrue(context.events[0].state.nrOfBooks == 68);
    }

    [TestMethod]
    public void ChangeState()
    {
        DataContext context = new DataContext();

        string title = "Alan";
        string author = "Makot";
        int nrOfPages = 68;
        context.AddCatalog(title, author, nrOfPages);

        int nrOfBooks = 68;
        context.AddState(nrOfBooks, 0);

        context.ChangeState(0, 4);
        Assert.IsTrue(context.states[0].nrOfBooks == 72);
    }
    */
}
