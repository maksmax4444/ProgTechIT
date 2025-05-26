namespace PresentationLayer.Model
{
    internal class EventModel : IEventModel
    {
        public EventModel(int eventId, int nrOfBooks)
        {
            this.eventId = eventId;
            this.nrOfBooks = nrOfBooks;
        }

        public int eventId { get; set; }
        public int nrOfBooks { get; set; }
    }
}
