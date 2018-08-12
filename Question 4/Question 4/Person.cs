using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int YearOfBirth;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }
    }
}
