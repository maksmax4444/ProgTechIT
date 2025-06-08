using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    class StateModel : IStateModel
    {
        public StateModel(int i, int n, int c)
        {
            stateId = i;
            nrOfBooks = n;
            catalogId = c;
        }
        public int stateId { get; set; }
        public int nrOfBooks { get; set; }
        public int catalogId { get; set; }
    }
}
