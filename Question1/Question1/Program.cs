using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Car
    {   //private so users cannot access this section - unaccessible strings
        private string col;
        private string mk;
        private string gbox;

        //get and set methods for colour, make and gearbox. 
        //public so users can access this section
        public string Colour
        {
            get
            {
                return col;
            }
            set
            {
                col = value;
            }
        }
        public string Make
        {
            get
            {
                return mk;
            }
            set
            {
                mk = value;
            }
        }
        public string Gearbox
        {
            get
            {
                return gbox;
            }
            set
            {
                gbox = value;
            }
        }
    }
    //main program
    class Program
    {
        static void Main(string[] args)
        {  
            Car one = new Car();
            //displays on console - lets users input information
            Console.WriteLine("Enter new car details below");
            Console.WriteLine("Colour: ");
            //links users input to the public string Colour for Car one 
            one.Colour = (Console.ReadLine());
            Console.WriteLine("Make: ");
            one.Make = (Console.ReadLine());
            Console.WriteLine("Gearbox type: ");
            one.Gearbox = (Console.ReadLine());
            Console.WriteLine("");
            //prints out the answers for Car one
            Console.WriteLine($"This car is a {one.Colour} {one.Make} with a {one.Gearbox} transmission");
        }
    }
}
