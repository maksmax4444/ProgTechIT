﻿namespace LibraryDataLayer
{
    public abstract class DataContextI
    {
        public List<Catalog> catalogs;
        public List<Event> events;
        public List<Users> users;
        public List<State> states;

        public DataContextI(List<Catalog> catalogs, List<Event> events, 
                                List<Users> users, List<State> states)
        {
            this.catalogs = catalogs;
            this.events = events;
            this.users = users;
            this.states = states;
        }
    }
}
