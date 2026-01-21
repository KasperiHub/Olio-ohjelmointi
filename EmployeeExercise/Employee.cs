using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    internal class Employee
    {
        public string nimi;
        public string id;
        public string tehtävä;
        public double palkka;

        public Employee()
        {
            this.nimi = string.Empty;
            this.id = string.Empty;
            this.tehtävä = string.Empty;
            this.palkka = 0;
        }
        public Employee(string nimi, string id, string tehtävä, double palkka)
        {
            this.nimi = nimi;
            this.id = id;
            this.tehtävä = tehtävä;
            this.palkka = palkka;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"{nimi} : {id} : {tehtävä} : {palkka}");
        }
        public void CompareSalary(Employee employee)
        {

            double lasku = (palkka - employee.palkka) / palkka * 100;

            if (palkka > employee.palkka)
            {
                Console.WriteLine($"{nimi} tienaa {lasku:F2}% enemmän kuin {employee.nimi}");
            }
            else if (palkka == employee.palkka)
            {
                Console.WriteLine($"{nimi} tienaa yhtä paljon {employee.nimi}");
            }
            else
                
            {
                double väärin = (employee.palkka - palkka) / employee.palkka * 100;
                Console.WriteLine($"{nimi} palkka on {väärin:F2}%  {employee.nimi} palkasta");
            }
        }
        public override string? ToString()

        {
            return $"{this.nimi} : {this.id} : {this.tehtävä} : {this.palkka}";

        }

    }
    
}
