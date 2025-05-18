namespace PresentationLayer.Model
{
    internal class EventModel : IEventModel
    {
        public EventModel(int eventId, StateModel state)
        {
            this.eventId = eventId;
            this.state = state;
        }
    }
}
