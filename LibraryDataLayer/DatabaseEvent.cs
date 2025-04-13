namespace LibraryDataLayer
{
    public class DatabaseEvent: Event
    {
        public bool addition { get; set; } //true addition false deletion

        public DatabaseEvent(int eventId, State state, bool addition): base(eventId, state)
        {
            this.addition = addition;
        }
    }
}
