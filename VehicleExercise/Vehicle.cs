using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal abstract class Vehicle
    {
        protected string brand;
        protected string model;
        protected string modelYear;
        protected double price;

        public Vehicle(string brand, string model, string modelYear, double price)
        {
            this.brand = brand;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        public Vehicle()
        {
            this.brand = string.Empty;
            this.model = string.Empty;
            this.modelYear = string.Empty;
            this.price = 0;
        }
        public virtual void PrintInformation()
        {
            Console.WriteLine(
                $"Brand: {this.brand}" +
                $" Model: {this.model} " +
                $"modelYear: {this.modelYear}" +
                $"price: {this.price}");
        }
    }
}
