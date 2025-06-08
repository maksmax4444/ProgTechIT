using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    public interface IEventModel
    {
        public int eventId { get; set; }
        public int nrOfBooks { get; set; }
    }
}
