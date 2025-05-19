using System.Collections.ObjectModel;
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
        public ObservableCollection<UsersViewModel> Users { get; set; }
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
        public UsersViewModelCollection()
        {
            Users = new ObservableCollection<UsersViewModel> { };
            //Place for commands
        }
    }
}
