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
            return 0;
        }

        public bool MatchesName(string name)
        {
            return false;
        }
        public bool MatchesNimi(string nimi)
        {
            return false;
        }
        public override string? ToString()
        {
            return $"Asiakkaan nimi: {nimi}, Asiakkaan ostokset {ostokset}"; 
        }

    }
}
