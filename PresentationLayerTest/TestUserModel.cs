using PresentationLayer.Model;

namespace PresentationLayerTest
{
    internal class TestUserModel : IUsersModel
    {
        public TestUserModel(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
