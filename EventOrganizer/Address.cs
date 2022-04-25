using System;
using System.Collections.Generic;
using System.Text;

namespace EventOrganizer
{
    public class Address
    {
        private string city;
        private Countries countires;
        private string street;
        private string zipCode;
        
        public string City
        {
            get { return city; }
            set { this.city = value; }
        }

        public Countries Country
        {
            get { return countires; }
            set { this.countires = value; }
        }

        public string Street
        {
            get { return street; }
            set { this.street = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { this.zipCode = value; }
        }

        public Address(string street, string city, string zip, Countries country)
        {
            Street = street;
            City = city;
            ZipCode = zip;
            Country = country;
        }
    }
}
