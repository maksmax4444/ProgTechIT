﻿namespace PresentationLayer.Model
{
    internal class StateModel : IStateModel
    {
        public StateModel(int stateId, int nrOfBooks, int catalog)
        {
            this.stateId = stateId;
            this.nrOfBooks = nrOfBooks;
            this.catalog = catalog;
        }

        public int stateId { get; set; }
        public int nrOfBooks { get; set; }
        public int catalog { get; set; }
    }
}
