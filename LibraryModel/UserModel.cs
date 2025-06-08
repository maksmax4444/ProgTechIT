using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    class UserModel : IUsersModel
    {
        public UserModel(int i, string f, string l)
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
