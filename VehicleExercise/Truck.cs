using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Truck : Car
    {
        public string load;
        public double consumption;
        public Truck(string brand, string model, string modelYear, double price, string type, string load, double consumption) : base(brand, model, modelYear, price, type)
        {
            this.load = load;
            this.consumption = consumption;
        }
        public Truck()
        {
            this.load = string.Empty;
            this.consumption = 0;
        }
        public double CalculateConsumption(double distance)
        {
            return consumption * (distance / 100);
        }
        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.Write($", Paino: {this.load}, Kulutus: {this.consumption}");
        }
        public override string ToString()
        {
            return 
                $"Auton merkki: {this.brand}\n" +
                $"Malli: {this.model}\n" +
                $"Vuosimalli: {this.modelYear}\n" +
                $"Hinta: {this.price} euroa\n" +
                $"Tyyppi: {this.type}\n" +
                $"Kuorma: {this.load} kg\n" +
                $"Kulutus: {this.consumption} L/100km\n";

        }
    }
}
