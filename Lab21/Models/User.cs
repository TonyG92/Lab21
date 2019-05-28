using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab22.Models
{
    public class User
    {
        private string userInput;
        private string firstName;
        private string middleName;
        private string lastName;
        private string favoriteAnimal;
        private string email;
        private string phoneNumber;
        private string password;

        public string UserInput
        {
            set { value = userInput; }
            get { return userInput; }
        }

        public string FirstName
        {
            set { value = firstName; }
            get { return firstName; }
        }

        public string MiddleName
        {
            set { value = middleName; }
            get { return middleName; }
        }

        public string LastName
        {
            set { value = lastName; }
            get { return firstName; }
        }

        public string FavoriteAnimal { set; get; }

        public string Email { set; get; }

        public string PhoneNumber { set; get; }

        public string Password { set; get; }

        public User()
        {

        }

        public User(string userInput, string firstName, string middleName, string lastName, string favoriteAnimal, string email, string phoneNumber, string password)
        {
            UserInput = userInput;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            FavoriteAnimal = favoriteAnimal;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;

        }

    }
}