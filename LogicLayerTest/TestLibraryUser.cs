using LibraryDataLayer;

namespace LogicLayerTest
{
    internal class TestLibraryUser : IUser
    {
        public TestLibraryUser(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
