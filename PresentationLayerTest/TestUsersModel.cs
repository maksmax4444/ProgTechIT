using LibraryModel;

namespace PresentationLayerTest
{
    internal class TestUsersModel: IUsersModel
    {
        public TestUsersModel(int i, string f, string l)
        {
            userId = i;
            firstName = f;
            lastName = l;
        }
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
