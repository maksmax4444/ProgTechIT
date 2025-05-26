using System.Windows.Input;
using LibraryLogicLayer;
using PresentationLayer.Model;

namespace PresentationLayer.ViewModel
{
    internal class EventViewModel : PropertyChange
    {
        private int eventId;
        private int states;
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Maksym\\Documents\\ProgTechRepo\\ProgTechIT\\LibraryDataLayer\\LibraryDatabase.mdf";
        private IDataService ids = IDataService.CreateNewDataService(connectionString);
        private IEventModel icm;
        public ICommand AddSmth { get; }
        public ICommand DeleteSmth { get; }
        public ICommand UpdateSmth { get; }

        public EventViewModel()
        {
            EventId = 0;
            States = 0;

            AddSmth = new RelayCommand(_ => add());
            DeleteSmth = new RelayCommand(_ => delete());
            UpdateSmth = new RelayCommand(_ => update());
        }

        public EventViewModel(int e, int s)
        {
            EventId = e;
            States = s;

            AddSmth = new RelayCommand(_ => add());
            DeleteSmth = new RelayCommand(_ => delete());
            UpdateSmth = new RelayCommand(_ => update());
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

        public int States
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
        public void add()
        {
            ids.AddEvent(eventId, states);
        }

        public void delete()
        {
            ids.RemoveEvent(eventId);
        }

        public void update()
        {
            ids.UpdateEvent(EventId, States);
        }
    }
}
