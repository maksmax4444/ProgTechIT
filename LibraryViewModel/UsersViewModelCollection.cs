using System.Collections.ObjectModel;
using System.Windows.Input;
using LibraryModel;

namespace LibraryViewModel
{
    public class UsersViewModelCollection : PropertyChange
    {
        private int userId;
        private string firstName;
        private string lastName;
        private static IDataModel ids;
        public UsersViewModelCollection()
        {
            Users = new ObservableCollection<UsersViewModel> { };
            Add = new RelayCommand(() => add());
            Delete = new RelayCommand(() => delete());
            Update = new RelayCommand(() => update());
            Load = new RelayCommand(() => load());
            ids = IDataModel.CreateNewDataModel();
        }

        public UsersViewModelCollection(IDataModel m)
        {
            Users = new ObservableCollection<UsersViewModel> { };
            Add = new RelayCommand(() => add());
            Delete = new RelayCommand(() => delete());
            Update = new RelayCommand(() => update());
            Load = new RelayCommand(() => load());
            ids = m;
        }
        public UsersViewModel _detail;
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
                if (value != null)
                {
                    UserId = value.UserId;
                    FirstName = value.FirstName;
                    LastName = value.LastName;
                }
            }
        }
        public void add()
        {
            Users.Add(new UsersViewModel(UserId, FirstName, LastName));
            ids.AddUser(UserId, FirstName, LastName);
        }
        public void delete()
        {
            for (int i = Users.Count - 1; i >= 0; i--)
            {
                if (Users[i].UserId == UserId)
                {
                    Users.RemoveAt(i);
                    break;
                }
            }
            ids.RemoveUser(UserId);
        }
        public void update()
        {
            delete();
            add();
        }
        public void load()
        {
            Users.Clear();
            foreach (var user in ids.GetAllUser())
            {
                Users.Add(new UsersViewModel(UserId = user.userId, FirstName = user.firstName, LastName = user.lastName));
            }
        }
    }
}
