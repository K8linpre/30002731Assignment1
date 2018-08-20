using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    public class Person
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
    public class Student : Person
    {
        public string campus;

        public string Campus
        {
            get
            {
                return campus;
            }
            set
            {
                campus = value;
            }
        }
        public int StudentID(int min, int max)
        {    
            Random rnd = new Random();           
            lock (rnd) // synchronize
            {
                return rnd.Next(min, max);
            }
        }          
    }
}

            

