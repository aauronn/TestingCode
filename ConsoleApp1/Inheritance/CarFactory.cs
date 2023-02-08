using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public class CarFactory
    {
        public void BuildLexus(Lexus car)
        {
            Console.WriteLine($"I am building a Lexus of Color: {car.Color}");
        }

        public void BuildHonda(Honda car)
        {
            Console.WriteLine($"I am building a Honda of Color: {car.Color}");
        }

        public void BuildCar(Car car)
        {
            Console.WriteLine($"I am building a {car.CarType} of Color: {car.Color}");
        }
    }
}
