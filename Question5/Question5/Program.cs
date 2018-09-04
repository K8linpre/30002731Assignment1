using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question5;

namespace Question5
{   //main program
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            //displays on console and allows user to input data and the data entered goes to the Person.cs
            Console.WriteLine("Enter the name of the new student below");
            Console.WriteLine("Enter first name: ");
            stud1.FirstName = (Console.ReadLine());
            Console.WriteLine("Enter last name: ");
            stud1.LastName = (Console.ReadLine());
            Console.WriteLine("Enter campus: ");
            stud1.Campus = (Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Creating new person record ...");
            Console.WriteLine("");
            Console.WriteLine($"Adding new student record to {stud1.Campus} ...");
            Console.WriteLine("");
            //uses Person.cs to access the GetFullName method and StudentID method and print it in th console
            Console.WriteLine($"{stud1.GetFullName()} of {stud1.Campus} Campus has a student ID of {stud1.EnrollStudent(1000,9999)}");//sets the range for the random number to be four digits and between 1000 and 9999
            Console.WriteLine();
        }
    }
}
