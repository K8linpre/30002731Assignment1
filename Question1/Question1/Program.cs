using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Car
    {
        private string col;
        private string mk;
        private string gbox;


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
    
    class Program
    {
        static void Main(string[] args)
        {  
            Car one = new Car();
            
            Console.WriteLine("Enter new car details below");
            Console.WriteLine("Colour: ");
            one.Colour = (Console.ReadLine());
            Console.WriteLine("Make: ");
            one.Make = (Console.ReadLine());
            Console.WriteLine("Gearbox type: ");
            one.Gearbox = (Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine($"This car is a {one.Colour} {one.Make} with a {one.Gearbox} transmission");
        }
    }
}
