namespace EmployeeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

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


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Työn tekijöiden palkka verranto");
            Console.ResetColor();
            employees[2].CompareSalary(employees[0]);
            employees[1].CompareSalary(employees[2]);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Eri tavoilla tulostetut tiedot");
            Console.ResetColor();
            employees[0].PrintEmployeeInfo();
            Console.WriteLine(employees[1]);
       



        }
    }
}
