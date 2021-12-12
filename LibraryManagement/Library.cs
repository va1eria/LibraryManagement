using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Library
    {
        int? id;
        string name, owner, region, city, postal_code, street, houseNumber;
        List<Member> members;
        List<Book> books;

        public int? Id
        {
            get => id;
            set
            {
                if (id == 0)
                {
                    id = value;
                }
                else
                {
                    throw new InvalidOperationException("The ID can only receive values once!");
                }
            }
        }
        public string Name 
        { 
            get => name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 64)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("The name is required and cannot be longer than 64 characters");
                }
            }
        }
        public string Owner 
        { 
            get => owner;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 64)
                {
                    owner = value;
                }
                else
                {
                    throw new ArgumentException("The owner name is required and cannot be longer than 64 characters");
                }
            }
        }
        public string Region 
        {
            get => region;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 64)
                {
                    region = value;
                }
                else
                {
                    throw new ArgumentException("The region is required and cannot be longer than 64 characters");
                }
            }
        }
        public string City 
        { 
            get => city;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 64)
                {
                    city = value;
                }
                else
                {
                    throw new ArgumentException("The city is required and cannot be longer than 64 characters");
                }
            }
        }
        public string Postal_code 
        { 
            get => postal_code;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 16)
                {
                    postal_code = value;
                }
                else
                {
                    throw new ArgumentException("The postal code is required and cannot be longer than 16 characters");
                }
            }
        }
        public string Street 
        { 
            get => street;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 64)
                {
                    street = value;
                }
                else
                {
                    throw new ArgumentException("The street is required and cannot be longer than 64 characters");
                }
            }
        }
        public string HouseNumber 
        { 
            get => houseNumber;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 8)
                {
                    houseNumber = value;
                }
                else
                {
                    throw new ArgumentException("The house number is required and cannot be longer than 8 characters");
                }
            }
        }
        internal List<Member> Members { get => members;}
        internal List<Book> Books { get => books;}

        public Library(string name, string owner, string region, string city, string postal_code, string street, string houseNumber)
        {
            Name = name;
            Owner = owner;
            Region = region;
            City = city;
            Postal_code = postal_code;
            Street = street;
            HouseNumber = houseNumber;
            members = new List<Member>();
            books = new List<Book>();
        }

        public Library(int? id, string name, string owner, string region, string city, string postal_code, string street, string houseNumber) : this(name, owner, region, city, postal_code, street, houseNumber)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"{name} {city}";
        }
    }
}
