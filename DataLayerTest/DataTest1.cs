namespace DataLayerTest
{
    [TestClass]
    public sealed class DataTest1
    {
        [TestMethod]
        public void TestConstructorCatalog()
        {
            Catalog c = new Catalog(1, "TestTitle", "TestAuthor", 10);
            Assert.IsTrue(c.catalogId == 1 && c.title == "TestTitle" && 
                            c.author == "TestAuthor" && c.nrOfPages == 10);
        }

        [TestMethod]
        public void TestConstructorState()
        {
            Catalog c = new Catalog(1, "TestTitle", "TestAuthor", 10);
            State s = new State(1, 10, c);
            Assert.IsTrue(s.stateId == 1 && s.nrOfBooks == 10 && s.catalog == c);
        }

        [TestMethod]
        public void TestConstructorEvent()
        {
            Catalog c = new Catalog(1, "TestTitle", "TestAuthor", 10);
            State s = new State(1, 10, c);
            Event e = new Event(1, s);
            Assert.IsTrue(e.eventId == 1 && e.state == s);
        }

        [TestMethod]
        public void TestConstructorUserEvent()
        {
            Catalog c = new Catalog(1, "TestTitle", "TestAuthor", 10);
            Users u = new Users(1, "Alicja", "Makota");
            State s = new State(1, 10, c);
            UserEvent e = new UserEvent(1, s, u);
            Assert.IsTrue(e.eventId == 1 && e.state == s && e.user == u);
        }

        [TestMethod]
        public void TestConstructorDatabaseEvent()
        {
            Catalog c = new Catalog(1, "TestTitle", "TestAuthor", 10);
            State s = new State(1, 10, c);
            DatabaseEvent e = new DatabaseEvent(1, s);
            Assert.IsTrue(e.eventId == 1 && e.state == s);
        }

        [TestMethod]
        public void TestConstructorUsers()
        {
            Users u = new Users(1, "Jan", "Kowalski");
            Assert.IsTrue(u.userId == 1 && u.firstName == "Jan" && u.lastName == "Kowalski");
        }
    }
}
