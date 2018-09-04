using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    public class Person
    {   //all are public so the users can access everything
        public string firstName;
        public string lastName;
        public int YearOfBirth;
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
            return DateTime.Now.Year - YearOfBirth;
        }
    }//derived class of person class
    public class Student : Person
    {   
        public string campus;
        public int StudentID;
        //get and set methods for Campus
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
        //method to calculate the four digit, random Student ID
        public int EnrollStudent(int min, int max)
        {
            //https://stackoverflow.com/questions/767999/random-number-generator-only-generating-one-random-number/768001
            //Creates a random number using a set minumum and maximum from program.cs and returns that random number as the StudentID.
            Random rnd = new Random();
            StudentID = rnd.Next(min, max);
            return StudentID;
            
        }          
    }
}

            

