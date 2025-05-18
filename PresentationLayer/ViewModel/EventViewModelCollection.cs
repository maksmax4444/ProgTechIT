using System.Windows.Input;

namespace PresentationLayer.ViewModel
{
    internal class EventViewModelCollection : PropertyChange
    {
        private int eventId;
        private StateViewModel states;
        private List<EventViewModel> events;
        public ICommand commandAdd { get; }
        public ICommand commandDelete { get; }

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

        public StateViewModel NrOfBooks
        {
            get
            {
                return this.states;
            }

            set
            {
                this.states = value;
                OnPropertyChanged(nameof(NrOfBooks));
            }
        }
        public EventViewModelCollection()
        {
            events = new List<EventViewModel>();
            //Place for commands
        }
        private async Task Add()
        {
            //Placeholder for commandAdd
        }
        private async Task Delete()
        {
            //Placeholder for commandDelete
        }
    }
}
