using System.Runtime.CompilerServices;

namespace LibraryLogicLayer
{
    internal class UserService : IUserService
    {
        public UserService(int i, string f, string l)
        {
            id = i;
            fName = f;
            lName = l;
        }
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
    }
}
