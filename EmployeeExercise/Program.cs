using System.ComponentModel.Design;

namespace EmployeeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Taulukko

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Työntekijä taulukko");
            Console.ResetColor();

            Employee[] employees = new Employee[3]; 
            employees[0] = new Employee("Kasperi Nyrkkö", "1", "Tradenomi", 4500);
            employees[1] = new Employee("Kasper Kaarna", "2", "Tradenomi", 4000);
            employees[2] = new Employee("Mikko Pakarinen", "3", "Tradenomi", 4000);

            foreach (Employee currentEmployees in employees)
            {
                Console.WriteLine(currentEmployees.ToString());
            }

            // Vertaaminen

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Työntekijöiden palkka verranto");   
            Console.ResetColor();

            for (int i = 0; i < 3; i++)  
            {
                int seuraava = (i + 1) % 3; // miten loopata taulukko, jolla voi mennä taulukon alkuun ilman, että crashaa. Taulukon koko = % x
                employees[i].CompareSalary(employees[seuraava]); 
            }


            Console.WriteLine();

            // Muilla tavoilla printtaaminen

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Eri tavoilla tulostetut tiedot");
            Console.ResetColor();
            employees[0].PrintEmployeeInfo();
            Console.WriteLine(employees[1]);
            
       
            


        }
    }
}
