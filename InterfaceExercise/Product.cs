using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Product : IProduct 
    {
        private string name;
        private double price;
        public int count;

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.count = amount;
        }

        public double CalculateTotal()
        {
            return price * this.count;
        }
        public double CalculateTotals()
        {
            return count;
        }

        public bool MatchesName(string value)
        {
            if (name == value)
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
            return $"Nimi: {name}, Hinta: {price} €, Määrä: {this.count}";
        }
    }
}