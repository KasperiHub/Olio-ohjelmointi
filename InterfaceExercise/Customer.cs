using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Customer : ICustomer
    {
        private string nimi;
        private double ostokset;
        public Customer(string nimi, double ostokset)
        {
            this.nimi = nimi;
            this.ostokset = ostokset;
        }

        public double GetBonus()
        {
            if (ostokset <= 1000)
            {
                return ostokset * 0.02;
            } 
            else if (ostokset <= 2000) 
            { 
                return ostokset * 0.03;
            } 
            else 
            { 
                return ostokset * 0.05;
            } 
        }


        public bool MatchesName(string value)
        {
            return this.nimi == value;
        }

        public override string? ToString()
        {
            return $"Asiakkaan nimi: {nimi}, Asiakkaan ostokset {ostokset}"; 
        }

    }
}
