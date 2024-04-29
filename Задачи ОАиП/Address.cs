using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи_ОАиП
{
    class Address
    {
        private double index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;
        public Address() { }
        public double Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }
        public Address(double index, string country, string city, string street, int house, int apartment)
        {
            this.Index = index;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.House = house;
            this.Apartment = apartment;
        }

    }
}
