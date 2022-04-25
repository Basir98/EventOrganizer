using System;
using System.Collections.Generic;
using System.Text;

namespace EventOrganizer
{
    class Participant
    {
        private Address address;
        private string firstName;
        private string lastName;

        public Address Address
        {
            get { return address; }
            set { this.address = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }
        public string FullName
        {
            get { return firstName + ", " + lastName; }
        }

        public Participant(string firstname, string lastname, Address adr)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = adr;
        }
    }
}
