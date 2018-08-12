using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question_4;

namespace Question_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Person one = new Person();

            Console.WriteLine("Enter the name of the new person below");
            Console.WriteLine("First name: ");
            one.FirstName = (Console.ReadLine());
            Console.WriteLine("Last name: ");
            one.LastName = (Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Creating new person record ...");
            Console.WriteLine("Enter year of birth: ");
            one.YearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine($"Person: {one.GetFullName()} is {one.GetAge()} years old.");

        }
    }
}
