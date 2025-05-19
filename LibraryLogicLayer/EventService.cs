namespace LibraryLogicLayer
{
    internal class EventService : IEventService
    {
        public EventService(int i, int s, int u)
        {
            id = i;
            stateId = s;
            userId = u;
        }
        public int id { get; set; }
        public int stateId { get; set; }
        public int userId { get; set; }
    }
}
