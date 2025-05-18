namespace PresentationLayer.Model
{
    internal class UsersModel : IUsersModel
    {
        public UsersModel(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
