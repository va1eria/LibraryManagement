using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Member
    {
        int? id;
        string firstName, lastName;

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
        public string FirstName
        {
            get => firstName;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 64)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("The first name is required and cannot be longer than 64 characters");
                }
            }
        }
        public string LastName
        {
            get => lastName;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 64)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("The last name is required and cannot be longer than 64 characters");
                }
            }
        }

        public Member(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Member(int? id, string firstName, string lastName) : this(firstName, lastName)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
