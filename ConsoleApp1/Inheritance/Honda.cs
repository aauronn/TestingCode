namespace ConsoleApp1.Inheritance
{
    public class Honda : Car
    {
        public override string CarType { get; set; } = "Honda";

        private string Cups { get; set; }

        private int TimesDrove { get; set; }

        private int Mileage { get; set; }

        public override void Drive(int milesToDrive)
        {
            Console.WriteLine($"The car color is: {Color}");
            Console.WriteLine($"The Honda car drove: {milesToDrive} miles");

            TimesDrove++;
            Mileage += milesToDrive;
        }

        public void DisplayTimesDrove()
        {
            Console.WriteLine($"Times drove: {TimesDrove}");
            Console.WriteLine($"The car has a mileage of: {Mileage}");
        }
    }
}
