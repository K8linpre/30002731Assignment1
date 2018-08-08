using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Car
    {
        private string colour;
        private string make;
        private string gearbox;


        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
            }
        }
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public string Gearbox
        {
            get
            {
                return gearbox;
            }
            set
            {
                gearbox = value;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {  
            Car one = new Car();
            
            Console.WriteLine("Enter new car details below");
            Console.WriteLine($"Colour: ");
            one.Colour = (Console.ReadLine());
            Console.WriteLine($"Make: ");
            one.Make = (Console.ReadLine());
            Console.WriteLine($"Gearbox type: ");
            one.Gearbox = (Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine($"This car is a {one.Colour} {one.Make} with a {one.Gearbox} transmission");
        }
    }
}
