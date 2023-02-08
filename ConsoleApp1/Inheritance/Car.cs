using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public abstract class Car
    {
        public virtual string Color { get; set; } = "Pink";
        public int NumberOfTires { get; set; }

        protected int numberOfBags { get; set; } = 1;

        public virtual string CarType { get; set; } = string.Empty;

        public virtual void Drive(int milesToDrive)
        {
            Console.WriteLine($"The car drove: {milesToDrive} miles");
        }

        public virtual void DisplayNumberOfBags ()
        {
            Console.WriteLine($"number of bags: {numberOfBags}");
        }
    }
}
