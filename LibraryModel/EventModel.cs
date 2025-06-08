using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    class EventModel : IEventModel
    {
        public EventModel(int i, int s)
        {
            eventId = i;
            nrOfBooks = s;
        }
        public int eventId { get; set; }
        public int nrOfBooks { get; set; }
    }
}
