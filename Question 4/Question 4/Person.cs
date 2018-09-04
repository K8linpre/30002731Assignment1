using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class Person
    {   //all are public so the users can access everything
        public string firstName;
        public string lastName;
        public int YearofBirth;
        //get and set methods for FirstName and LastName
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
        
        //combines the first name and lastname together so you can just call the GetFullName and it will print both.
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
        //works out the age of the person by minusing the user input off the current date
        public int GetAge()
        {
            return DateTime.Now.Year - YearofBirth;
        }

    }
}
