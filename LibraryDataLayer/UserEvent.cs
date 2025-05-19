namespace LibraryDataLayer
{
    internal class UserEvent: LibraryEvent
    {
        public LibraryUser user { get; set; }

        public UserEvent(int eventId, LibraryState state, LibraryUser user) : base(eventId, state)
        {
            this.user = user;
        }
    }
}
