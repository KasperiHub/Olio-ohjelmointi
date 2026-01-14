using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    internal class Company
    {
        public string title;
        public string address;
        public string phone;
        public double income;
        public double expense;

        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.income = 0;
            this.expense = 0;
        }

        public Company(string title, string address, string phone, double income, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.income = income;
            this.expense = expense;

        }
        public Company(Company other)
        {
            title = other.title;
            address = other.address;
            phone = other.phone;
            income = other.income;
            expense = other.expense;
        }


        /*
         public void ShowCompany()
         {
             Console.WriteLine($"{this.title} : {this.address} : {this.phone} : {this.income} : {this.expense}");

         }
         Turha koodipätkä
         */

        public void Tilanne()
        {
            if (this.income == 0)
            {
                Console.WriteLine("Voittoa ei voi laskea");
                return;
            }
            double voitto = (income - expense) / income * 100;
            Console.WriteLine($"Voittoprosentti : {voitto:F2} %");

            if (voitto < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yrityksellä menee kehnosti");
            }
            else if (voitto < 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Yrityksellä´menee välttävästi");
            }
            else if (voitto < 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yrityksellä menee tyydyttävästi");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yrityksellä menee hyvin");
            }
            Console.ResetColor();
        }

        public override string? ToString()
        {
            return $"{this.title} : {this.address} : {this.phone} : {this.income} : {this.expense}";

        }

        /* public void AskData()
       {
           Console.WriteLine("Give company name");
           this.title = Console.ReadLine(); 
           Console.WriteLine("Give company address");
           this.address = Console.ReadLine();
           Console.WriteLine("Give company phone");
           this.phone = Console.ReadLine(); 
           Console.WriteLine("Give company income");
           this.income = int.Parse(Console.ReadLine());
           Console.WriteLine("Give company expense");
       } Turha koodi pätkä
       */
    }
}
