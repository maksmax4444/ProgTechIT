namespace LibraryDataLayer
{
    internal class Users
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Users(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
