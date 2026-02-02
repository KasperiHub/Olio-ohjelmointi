using System.Runtime.CompilerServices;

namespace VehicleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehicle Vehicle1 = new Vehicle("Toyota", "Avensis", "2007", 900); // Turha koodi "Abstract" jälkeen

            // Autot
            Car Car1 = new Car("Toyota", "Corolla", "2005", 800, "Sedan", "1.9L", 4);
            Car Car4 = new Car("Toyota", "Avencis", "2008", 1000, "Hatchback", "2.0L", 4);
            Car Car2 = new Car("Toyota", "Corolla", "2005", 1500, "Sedan", "1.9L", 4);

            // Rekat
            Truck Truck1 = new Truck("Scania", "R500", "2020", 75300, "Vetopöytäauto","9", 2, "5000kg", 21);
            Truck Truck2 = new Truck("Sisu", "E-sarja", "1997", 60300, "Vetopöytäauto", "9", 2, "4500kg", 23);
            Truck Truck3 = new Truck("Sisu", "S-sarja", "1995", 50100, "Vetopöytäauto", "9", 2, "4000kg", 22);

            // Autot tulostettuna
            Console.WriteLine($"Car1\n{Car1.PrintInformation()}");
            Console.WriteLine($"Car2\n{Car2.PrintInformation()}");
            Console.WriteLine($"Car3\n{Car4.PrintInformation()}");

            // Rekat tulostettuna
            Console.WriteLine($"Truck1\n{Truck1.ToString()}");
            Console.WriteLine($"Truck2\n{Truck2.ToString()}");
            Console.WriteLine($"Truck3\n{Truck3.ToString()}");
            
            // Equals Funktio
            Console.WriteLine("Equals funktio");
            if (Car2.Equals(Car1))
            {
                Console.WriteLine($"Tieto toistuu \nAuto1 {Car2.brand} {Car2.model} ({Car2.modelYear}). Hinta: {Car2.price}\n" +
                $"Auto2 {Car1.brand} {Car1.model} ({Car1.modelYear}). Hinta :{Car1.price}\n" + $"Autot ovat samoja");
            }
            else
            {
                Console.WriteLine("Autot eivät ole samoja.");
            }
            Console.WriteLine();

            Console.WriteLine("Equals funktio");
            if (Car4.Equals(Car1))
            {
                Console.WriteLine($"Tieto toistuu \nAuto1 {Car2.brand} {Car2.model} ({Car2.modelYear}). Hinta: {Car2.price}\n" +
                $"ja Auto2 {Car1.brand} {Car1.model} ({Car1.modelYear}) ovat samat. Hinta :{Car1.price} ");
            }
            else
            {
                Console.WriteLine("Autot eivät ole samoja.");
            }
            Console.WriteLine();

            // Periytyminen
            Truck truck4 = new Truck("Volvo", "FH13", "2015", 69025, "Vetopöytäauto", "12.8", 2, "6000kg", 20);

            Console.WriteLine("Suoritetaan tyyppimuunnokset auto- ja kuorma-auton välillä");
            Car car3 = truck4;
            Console.WriteLine(car3.ToString());

            Console.Write("Suoritetun tyyppimuunnoksen tulos:");
            if (car3 == truck4)
            {
                Console.WriteLine(" Tyyppimuunnos onnistui.");
            }
            else
            {
                Console.WriteLine(" Tyyppimuunnos epäonnistui.");
            }
            Console.WriteLine();

            // CalculateConsumption Funktio

            Console.WriteLine("Auton kulutus matkalla");
            Console.WriteLine("Anna matkan pituus");
            string luku = Console.ReadLine();

            double distance;
            if (double.TryParse(luku, out distance))
            {
                Console.WriteLine();
                double fuel = Truck1.CalculateConsumption(distance);
                Console.WriteLine($"Kulutus: {fuel} litraa");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte, anna numeroina.");
            }

        }
    }
}
