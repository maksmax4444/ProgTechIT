using LibraryDataLayer;
namespace DataLayerTest
{
    internal class Users: UsersI
    {
        public Users(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
