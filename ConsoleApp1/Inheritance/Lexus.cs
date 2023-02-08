using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public class Lexus : Car
    {
        public override string CarType { get; set; } = "Lexus";
        public override string Color { get; set; } = "White";

        public override void Drive(int milesToDrive)
        {
            Console.WriteLine($"The Lexus is {Color}");
            Console.WriteLine($"The Lexus car drove: {milesToDrive} miles");
            
        }
    }
}
