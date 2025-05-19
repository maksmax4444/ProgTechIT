using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PresentationLayer.ViewModel
{
    internal class EventViewModelCollection : PropertyChange
    {
        private int eventId;
        private StateViewModel states;
        public ObservableCollection<EventViewModel> Events { get; set; }
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
            Events = new ObservableCollection<EventViewModel> { };
            //Place for commands
        }
    }
}
