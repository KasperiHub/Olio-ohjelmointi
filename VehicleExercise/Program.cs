namespace VehicleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehicle Vehicle1 = new Vehicle("Toyota", "Avensis", "2007", 900); //Pitää antaa default valuet aka. this.price = 0;

            Car Car1 = new Car("Toyota", "Corolla", "2005", 800, "Sedan");

            Truck Truck1 = new Truck("Scania", "R500", "2020", 75300, "Vetopöytäauto", "5000kg", 21);

            Console.WriteLine("Car");
            Car1.PrintInformation();
            Console.WriteLine(); Console.WriteLine("Truck:");
            Truck1.PrintInformation();
            // Console.WriteLine(); Console.WriteLine("Vehicle:");
            // Vehicle1.PrintInformation();
            Console.WriteLine();

            Console.WriteLine("Anna matkan pituus");
            double fuel = Truck1.CalculateConsumption(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Kulutus: {fuel} Litraa");







        }
    }
}
