namespace PresentationLayer.ViewModel
{
    internal class EventViewModel : PropertyChange
    {
        private int eventId;
        private int nrOfBooks;
        public EventViewModel()
        {
            EventId = 0;
            nrOfBooks = 0;
        }
        public EventViewModel(int e, int s)
        {
            EventId = e;
            nrOfBooks = s;
        }
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
        public int NrOfBooks
        {
            get
            {
                return this.nrOfBooks;
            }

            set
            {
                this.nrOfBooks = value;
                OnPropertyChanged(nameof(nrOfBooks));
            }
        }
    }
}
