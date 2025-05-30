﻿namespace PresentationLayer.Model
{
    internal class UsersModel : IUsersModel
    {
        public UsersModel(int userId, string firstName, string lastName)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
