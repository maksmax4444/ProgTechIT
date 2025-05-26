using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryLogicLayer;

namespace PresentationLayer.ViewModel
{
    internal class EventViewModelCollection : PropertyChange
    {
        private int eventId;
        private int nrOfBooks;
        private const string connectionString = "";
        private IDataService ids = IDataService.CreateNewDataService(connectionString);
        private EventViewModel _detail;
        public ObservableCollection<EventViewModel> Events { get; set; }
        public ICommand Add { get; }
        public ICommand Delete { get; }
        public ICommand Update { get; }
        public ICommand Load { get; }
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
                OnPropertyChanged(nameof(NrOfBooks));
            }
        }
        public EventViewModel Detail
        {
            get
            {
                return _detail;
            }

            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
                EventId = value.EventId;
                NrOfBooks = value.NrOfBooks;
            }
        }
        public EventViewModelCollection()
        {
            Events = new ObservableCollection<EventViewModel> { };
            Add = new RelayCommand(_ => add());
            Delete = new RelayCommand(_ => delete());
            Update = new RelayCommand(_ => update());
        }
        public void add()
        {
            ids.AddEvent(EventId, NrOfBooks);
        }

        public void delete()
        {
            ids.RemoveEvent(EventId);
        }

        public void update()
        {
            ids.UpdateEvent(EventId, NrOfBooks);
        }
        public void load()
        {
            Events.Clear();
            foreach (var item in ids.GetAllEvent())
            {
                Events.Add(new EventViewModel(item.id, item.stateId));
            }
        }
    }
}
