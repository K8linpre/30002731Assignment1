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
            //Constructor
            Person one = new Person();
            int Age = 0;
            bool addPerson = false;
            bool New = false;

            //Pops up after the first person and when the user chooses "y" for new person.
            string again;
            do
            {
                if (New)
                {
                    Console.WriteLine("Enter the name of the new person below");
                }
                else
                {
                    Console.WriteLine("Enter the name of the person below");
                }
                //Displayed on console
                Console.WriteLine($"First name: ");
                one.FirstName = (Console.ReadLine());
                Console.WriteLine($"Last name: ");
                one.LastName = (Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Creating new person record ...");
                Console.WriteLine("Enter year of birth: ");
                //to calculate the age of the person using this year minus the birth year entered
                Age = DateTime.Now.Year - Convert.ToInt32(Console.ReadLine());
                //sets the SetYearofBirth to the Age that was calcualted above
                one.SetYearofBirth(Age);
                Console.WriteLine("");
                //Displayed on console
                Console.WriteLine($"Person: {one.GetFullName()} is {one.GetYearofBirth()} years old.");

                //User can choose if they want to enter another person
                Console.WriteLine("Do you want to enter another person? (y/n)");
                again = Console.ReadLine();
                //makes in not case-sensitive so user can enter Y or y
                addPerson = (again == "y" || again == "Y");
                New = true;
            } while (addPerson);
            //Exits the program
            Console.WriteLine("Press any key to exit program");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
