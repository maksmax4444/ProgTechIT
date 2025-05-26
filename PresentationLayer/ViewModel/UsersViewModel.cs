namespace PresentationLayer.ViewModel
{
    internal class UsersViewModel : PropertyChange
    {
        int userId;
        string firstName;
        string lastName;
        public UsersViewModel(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public UsersViewModel()
        {
            UserId = 0;
            FirstName = "";
            LastName = "";
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
    }
}
