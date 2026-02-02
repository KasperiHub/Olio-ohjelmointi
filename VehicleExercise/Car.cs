using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Car:Vehicle
    {

        public string type;
        public Car(string brand, string model, string modelYear, double price, string type) : base(brand, model, modelYear, price)
        {
            this.type = type;
        }
        public Car()
        {
            this.type = string.Empty;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($" Type: {this.type}");
        }
    }
}
