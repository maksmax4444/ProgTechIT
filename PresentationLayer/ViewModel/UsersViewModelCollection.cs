using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryDataLayer;
using LibraryLogicLayer;

namespace PresentationLayer.ViewModel
{
    internal class UsersViewModelCollection : PropertyChange
    {
        private int userId;
        private string firstName;
        private string lastName;
        private const string connectionString = "";
        private IDataService ids = IDataService.CreateNewDataService(connectionString);
        private UsersViewModel _detail;
        public ObservableCollection<UsersViewModel> Users { get; set; }
        public ICommand Add { get; }
        public ICommand Delete { get; }
        public ICommand Update { get; }
        public ICommand Load { get; }
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
        public string FirstName
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
        public string LastName
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
        public UsersViewModel Detail
        {
            get
            {
                return _detail;
            }

            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
                UserId = value.UserId;
                FirstName = value.FirstName;
                LastName = value.LastName;
            }
        }
        public UsersViewModelCollection()
        {
            Users = new ObservableCollection<UsersViewModel> { };
            Add = new RelayCommand(_ => add());
            Delete = new RelayCommand(_ => delete());
            Update = new RelayCommand(_ => update());
            Load = new RelayCommand(_ => load());
        }
        public void add()
        {
            if (connectionString == "")
            {
                Users.Add(new UsersViewModel(UserId, FirstName, LastName));
            }
            else ids.AddUser(UserId, FirstName, LastName);
        }
        public void delete()
        {
            if (connectionString == "")
            {
                for (int i = Users.Count - 1; i >= 0; i--)
                {
                    if (Users[i].UserId == UserId)
                    {
                        Users.RemoveAt(i);
                        break;
                    }
                }
            }
            else ids.RemoveUser(UserId);
        }
        public void update()
        {
            if (connectionString == "")
            {
                delete();
                add();
            }
            else ids.UpdateUser(UserId, FirstName, LastName);
        }
        public void load()
        {
            Users.Clear();
            foreach (var user in ids.GetAllUser())
            {
                Users.Add(new UsersViewModel(UserId = user.id, FirstName = user.fName, LastName = user.lName));
            }
        }
    }
}
