using ConsoleApp1.Inheritance;

namespace ConsoleApp1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //var car = new Car();
            //car.Drive(10);

            var lexus = new Lexus();
            lexus.Drive(100);
            Console.WriteLine();

            var honda = new Honda();
            honda.Drive(200);
            honda.DisplayTimesDrove();
            Console.WriteLine();

            honda.Drive(20);
            honda.DisplayTimesDrove();
            Console.WriteLine();

            honda.Drive(50);
            honda.DisplayTimesDrove();
            Console.WriteLine();

            honda.Drive(100);
            honda.DisplayTimesDrove();
            Console.WriteLine();

            var carFactory = new CarFactory();

            carFactory.BuildHonda(honda);
            Console.WriteLine();
            carFactory.BuildLexus(lexus);
            Console.WriteLine();
            carFactory.BuildCar(honda);
            Console.WriteLine();
            carFactory.BuildCar(lexus);
            Console.WriteLine();

            var susuki = new Susuki();

            carFactory.BuildCar(susuki);
        }
    }
}