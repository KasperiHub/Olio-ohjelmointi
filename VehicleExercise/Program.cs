using System.Runtime.CompilerServices;

namespace VehicleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehicle Vehicle1 = new Vehicle("Toyota", "Avensis", "2007", 900); // Pitää antaa default valuet aka. this.price = 0; 

            Car Car1 = new Car("Toyota", "Corolla", "2005", 800, "Sedan", "1.9L", 4);
            Car Car4 = new Car("Toyota", "Avencis", "2008", 1000, "Hatchback", "2.0L", 4);
            Car Car2 = new Car("Toyota", "Corolla", "2005", 1500, "Sedan", "1.9L", 4);



            Truck Truck1 = new Truck("Scania", "R500", "2020", 75300, "Vetopöytäauto","9", 2, "5000kg", 21);
            Truck Truck2 = new Truck("Sisu", "E-sarja", "1997", 60300, "Vetopöytäauto", "9", 2, "4500kg", 23);
            Truck Truck3 = new Truck("Sisu", "S-sarja", "1995", 50100, "Vetopöytäauto", "9", 2, "4000kg", 22);


            Console.WriteLine("Car");
            Car1.PrintInformation();
            Console.WriteLine("Car2");
            Car2.PrintInformation();
            Console.WriteLine("Car3");
            Car4.PrintInformation();

            Console.WriteLine("Truck");
            Console.WriteLine(Truck1.ToString());
            Console.WriteLine();
            Console.WriteLine("Truck2");
            Console.WriteLine(Truck2.ToString());
            Console.WriteLine();
            Console.WriteLine("Truck3");
            Console.WriteLine(Truck3.ToString());
            // Console.WriteLine(); Console.WriteLine("Vehicle:");
            // Vehicle1.PrintInformation();
            Console.WriteLine();

            Console.WriteLine("Equals funktio");
            if (Car2.Equals(Car1))
            {
                Console.WriteLine( $"Tieto toistuu, auto {Car2.brand} {Car2.model} ({Car2.modelYear}). Hinta: {Car2.price}" +
                $"ja auto {Car1.brand} {Car1.model} ({Car1.modelYear}) ovat samat. Hinta :{Car1.price} ");
            }
            else
            {
                return;
            }
            Console.WriteLine();

            Console.WriteLine("Equals funktio");
            if (Car4.Equals(Car1))
            {
                Console.WriteLine($"Tieto toistuu, auto {Car4.brand} {Car4.model} ({Car4.modelYear}, Hinta: {Car4.price}) " +
                $"ja auto {Car1.brand} {Car1.model} ({Car1.modelYear}) ovat samat. Hinta:{Car1.price}");
            }
            else
            {
                Console.WriteLine("Autot eivät ole samoja.");
                return;
            }
            Console.WriteLine();

            Truck truck4 = new Truck("Volvo", "FH13", "2015", 69025, "Vetopöytäauto", "12.8", 2, "6000kg", 20);

            Console.WriteLine("Suoritetaan tyyppimuunnokset auto- ja kuorma-auton välillä");
            Car car3 = truck4 as Car;
            Console.WriteLine(car3.ToString());

            Console.WriteLine("Suoritetun tyyppimuunnoksen tulos");
            if (car3 == truck4)
            {
                Console.WriteLine("Tyyppimuunnos onnistui");
            }
            else
            {
                Console.WriteLine("Tyyppimuunnos epäonnistui");
            }

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
