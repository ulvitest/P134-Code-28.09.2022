using System;
using System.Collections.Generic;
using System.Text;

namespace ContactPractise
{
    internal class Contact
    {
        public string name;
        public string surname;
        public string email;
        public string phoneNumber;
        public string message;
        public Contact()
        {

        }

        public Contact(string name, string surname, string email, string phoneNumber, string message)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.message = message;
        }
        public string Info()
        {
            return $"name :{name} surname:{surname} email:{email} phoneNumber:{phoneNumber} message:{message}";
        }
    }
}
