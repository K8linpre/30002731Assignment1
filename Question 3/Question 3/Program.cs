using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    class Car
    {   //auto implemented properties
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Gearbox { get; set; }
    }
    //main program
    class Program
    {
        static void Main(string[] args)
        {
            Car one = new Car();
            //displays on console - lets users input information
            Console.WriteLine("Enter new car details below");
            Console.WriteLine($"Colour: ");
            //links users input to the public string Colour for Car one 
            one.Colour = (Console.ReadLine());
            Console.WriteLine($"Make: ");
            one.Make = (Console.ReadLine());
            Console.WriteLine($"Gearbox type: ");
            one.Gearbox = (Console.ReadLine());
            Console.WriteLine("");
            //prints out the answers for Car one
            Console.WriteLine($"This car is a {one.Colour} {one.Make} with a {one.Gearbox} transmission");
        }
    }
}
