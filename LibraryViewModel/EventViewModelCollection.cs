using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryLogicLayer;
using LibraryModel;

namespace LibraryViewModel
{
    public class EventViewModelCollection : PropertyChange
    {
        private int eventId;
        private int nrOfBooks;
        private static IDataModel ids;
        public EventViewModelCollection()
        {
            Events = new ObservableCollection<EventViewModel> { };
            Add = new RelayCommand(() => add());
            Delete = new RelayCommand(() => delete());
            Update = new RelayCommand(() => update());
            Load = new RelayCommand(() => load());
            ids = IDataModel.CreateNewDataModel();
        }

        public EventViewModelCollection(string connectionString)
        {
            Events = new ObservableCollection<EventViewModel> { };
            Add = new RelayCommand(() => add());
            Delete = new RelayCommand(() => delete());
            Update = new RelayCommand(() => update());
            Load = new RelayCommand(() => load());
            ids = IDataModel.CreateNewDataModel(connectionString);
        }
        public EventViewModel _detail;
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
        public void add()
        {
            Events.Add(new EventViewModel(EventId, NrOfBooks));
        }

        public void delete()
        {
            for (int i = Events.Count - 1; i >= 0; i--)
                {
                    if (Events[i].EventId == EventId)
                    {
                        Events.RemoveAt(i);
                        break;
                    }
                }
        }

        public void update()
        {
            delete();
            add();
        }
        public void load()
        {
            Events.Clear();
            foreach (var item in ids.GetAllEvent())
            {
                Events.Add(new EventViewModel(item.eventId, item.nrOfBooks));
            }
        }
    }
}
