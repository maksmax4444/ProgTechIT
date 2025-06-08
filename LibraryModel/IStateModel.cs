using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    public interface IStateModel
    {
        public int stateId { get; set; }
        public int nrOfBooks { get; set; }
        public int catalogId { get; set; }
    }
}
