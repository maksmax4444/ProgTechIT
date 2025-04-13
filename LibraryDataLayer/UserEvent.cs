namespace LibraryDataLayer
{
    public class UserEvent: Event
    {
        public Users user { get; set; }
        public bool borrowing { get; set; } //true borrowing false returning

        public UserEvent(int eventId, State state, 
                            Users user, bool borrowing) : base(eventId, state)
        {
            this.user = user;
            this.borrowing = borrowing;
        }
    }
}
