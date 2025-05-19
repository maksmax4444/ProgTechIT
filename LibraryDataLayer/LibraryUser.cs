namespace LibraryDataLayer
{
    internal class LibraryUser : IUser
    {
        public LibraryUser(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
