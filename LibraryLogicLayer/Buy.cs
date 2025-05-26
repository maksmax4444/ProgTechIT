using LibraryDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    internal class Buy : IBuy
    {
        public int eventId { get; set; }
        public IState state { get; set; }

        private DataService myDataService = new DataService();

        public void BuyUnit(int amount)
        {
            int newStateNum = myDataService.GetState(state.stateId).noBooks + amount;
            int catalogId = myDataService.GetState(state.stateId).catalogId;
            myDataService.RemoveState(state.stateId);
            myDataService.AddState(state.stateId, newStateNum, catalogId);
            myDataService.AddEvent(eventId, state.stateId);
        }
    }
}
