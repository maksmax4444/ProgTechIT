using System.Windows.Input;

namespace PresentationLayer.ViewModel
{
    internal class UsersViewModelCollection : PropertyChange
    {
        private int userId;
        private string firstName;
        private string lastName;
        public ICommand commandAdd { get; }
        public ICommand commandDelete { get; }
        private List<UsersViewModel> users;

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

        public List<UsersViewModel> Users
        {
            get
            {
                return this.users;
            }

            set
            {
                this.users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        public UsersViewModelCollection()
        {
            users = new List<UsersViewModel>();
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
