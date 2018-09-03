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
        public int yearofbirth;

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
        public int YearofBirth
        {
            get => yearofbirth;
            set => yearofbirth = value;
        }
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
        public void SetYearofBirth(int value)
        {
            yearofbirth = value;
        }
        public int GetYearofBirth()
        {
            return yearofbirth;
        }

    }
}
