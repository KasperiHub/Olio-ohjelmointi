namespace VehicleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehicle Vehicle1 = new Vehicle("Toyota", "Avensis", "2007", 900); // Pitää antaa default valuet aka. this.price = 0; 

            Car Car1 = new Car("Toyota", "Corolla", "2005", 800, "Sedan");
            Car Car4 = new Car("Toyota", "Avencis", "2008", 1000, "Hatchback");
            Car Car2 = new Car("Toyota", "Corolla", "2005", 1500, "Sedan");

            Truck Truck1 = new Truck("Scania", "R500", "2020", 75300, "Vetopöytäauto", "5000kg", 21);

            Console.WriteLine("Car");
            Car1.PrintInformation();
            Console.WriteLine(); Console.WriteLine("Truck:");
            Console.WriteLine(Truck1.ToString());
            // Console.WriteLine(); Console.WriteLine("Vehicle:");
            // Vehicle1.PrintInformation();
            Console.WriteLine();


            Console.WriteLine("Equals");
            Car Car3 = Car2;
            if (Car3.Equals(Car1))
            {
                Console.WriteLine( $"Tieto toistuu, auto {Car3.brand} {Car3.model} ({Car3.modelYear}) " +
                $"ja auto {Car1.brand} {Car1.model} ({Car1.modelYear}) ovat samat."
);

            }
            else
            { 
                Console.WriteLine(Car1.ToString()); 
            }
            Console.WriteLine();



            Console.WriteLine("Anna matkan pituus");
            string luku = Console.ReadLine(); 

            double distance;
            if (double.TryParse(luku, out distance)) 
            { 
            double fuel = Truck1.CalculateConsumption(distance); 
            Console.WriteLine($"Kulutus: {fuel} litraa"); 
            }
            else
            {
                Console.WriteLine("Virheellinen syöte, anna numeroina.");
                return;
            }
            







        }
    }
}
