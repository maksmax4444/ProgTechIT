using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataLayer
{
    public class DataContext : DataContextI
    {
        public DataContext(List<Catalog> catalogs, List<Event> events,
                                List<Users> users, List<State> states): base(catalogs, events, users, states)
        {
        }
    }
}
