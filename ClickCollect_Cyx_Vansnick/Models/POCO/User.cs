using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClickCollect_Cyx_Vansnick.Models.POCO
{
    public abstract class User
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public User(string u, string pw, string fn, string ln, string e, string ph)
        {
            username = u;
            password = pw;
            firstName = fn;
            lastName = ln;
            email = e;
            phoneNumber = ph;
        }
    }
}
