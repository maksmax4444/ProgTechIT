namespace PresentationLayer.ViewModel
{
    internal class EventViewModel : PropertyChange
    {
        private int eventId;
        private StateViewModel states;

        public int EventId
        {
            get
            {
                return this.eventId;
            }

            set
            {
                this.eventId = value;
                OnPropertyChanged(nameof(EventId));
            }
        }

        public StateViewModel States
        {
            get
            {
                return this.states;
            }

            set
            {
                this.states = value;
                OnPropertyChanged(nameof(States));
            }
        }
    }
}
