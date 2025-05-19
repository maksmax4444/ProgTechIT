using System.Windows.Input;
using LibraryLogicLayer;

namespace PresentationLayer.ViewModel
{
    internal class UsersViewModel : PropertyChange
    {
        int userId;
        string firstName;
        string lastName;
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Maksym\\Documents\\ProgTechRepo\\ProgTechIT\\LibraryDataLayer\\LibraryDatabase.mdf";
        private IDataService ids = IDataService.CreateNewDataService(connectionString);
        private UsersViewModel u;
        public ICommand AddSmth { get; }
        public ICommand DeleteSmth { get; }
        public ICommand UpdateSmth { get; }

        public UsersViewModel(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;

            AddSmth = new RelayCommand(_ => add());
            DeleteSmth = new RelayCommand(_ => delete());
            UpdateSmth = new RelayCommand(_ => update());
        }

        public UsersViewModel()
        {
            UserId = 0;
            FirstName = "";
            LastName = "";

            AddSmth = new RelayCommand(_ => add());
            DeleteSmth = new RelayCommand(_ => delete());
            UpdateSmth = new RelayCommand(_ => update());
        }

        public int UserId
        {
            get
            {
                return this.userId;
            }

            set
            {
                this.userId = value;
                OnPropertyChanged(nameof(UserId));
            }
        }

        public String FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public String LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
        public void add()
        {
            ids.AddUser(userId, firstName, lastName);
        }

        public void delete()
        {
            ids.RemoveUser(userId);
        }

        public void update()
        {
            ids.UpdateUser(UserId, firstName, lastName);
        }
    }
}
