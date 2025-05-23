﻿namespace PresentationLayer.Model
{
    internal class EventModel : IEventModel
    {
        public EventModel(int eventId, int state)
        {
            this.eventId = eventId;
            this.state = state;
        }

        public int eventId { get; set; }
        public int state { get; set; }
    }
}
