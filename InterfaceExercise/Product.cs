using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExercise;

namespace InterFaceExcercise
{
    internal class Product : IProduct
    {
        private string name;
        private double price;
        private int count;

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.count = amount;
        }

        public double CalculateTotal()
        {
            return this.price * this.count;
        }

        public bool MatchesName(string value)
        {
            if (this.name == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string? ToString()
        {
            return $"Nimi: {this.name}, Hinta: {this.price}, Määrä: {this.count}";
        }
    }
}