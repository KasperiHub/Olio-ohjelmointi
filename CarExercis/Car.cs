using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercis
{
    internal class Car
    {
        public String brand;
        public double speed;

        public Car()
        {
            this.brand = String.Empty;
            this.speed = 0;
        }

        public Car(string brand, double speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public void AskData()
        {
            Console.WriteLine("Anna auton merkki");
            this.brand = Console.ReadLine();
            Console.WriteLine("Anna auton vauhti");
            double.TryParse(Console.ReadLine(), out this.speed);
        }
        public void ShowCarinfo()
        {
            Console.WriteLine($"{this.brand} : {this.speed}");

        }
        public void Accelerate(double value)
        {
            if (value > 0)
            {
                this.speed += value;
            }
        }
        public void Brake()
        {
            this.speed *= 0.9;
        }
    }
}
