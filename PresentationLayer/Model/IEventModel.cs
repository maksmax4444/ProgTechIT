namespace PresentationLayer.Model
{
    internal class IEventModel
    {
        public int eventId { get; set; }
        public IStateModel state { get; set; }
    }
}
