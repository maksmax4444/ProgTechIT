using LibraryDataLayer;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    internal class Sell : ISell
    {
        public int eventId { get; set; }
        public IState state { get; set; }

        private DataService myDataService = new DataService();

        public bool SellUnit(int amount)
        {
            int newStateNum = myDataService.GetState(state.stateId).noBooks - amount;
            int catalogId = myDataService.GetState(state.stateId).catalogId;
            if(newStateNum <= 0) return false;
            myDataService.RemoveState(state.stateId);
            myDataService.AddState(state.stateId, newStateNum, catalogId);
            myDataService.AddEvent(eventId, state.stateId);
            return true;
        }
    }
}
