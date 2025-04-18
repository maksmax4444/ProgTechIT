﻿namespace LibraryDataLayer
{
    internal class UserEvent: Event
    {
        public Users user { get; set; }

        public UserEvent(int eventId, State state, Users user) : base(eventId, state)
        {
            this.user = user;
        }
    }
}
