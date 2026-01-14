namespace CompanyExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Company c1 = new Company("Twitter", "Karjalankatu", "+358458559353", 200000, 15000);
            Company c2 = new Company("Valve", "Kekkosentie", "+358326586942", 600000, 5000);
            // c1.ShowCompany(); turhakoodi 
            // c2.ShowCompany(); turhakoodi


            Console.WriteLine(c1.ToString());
            c1.Tilanne();
            Console.WriteLine();
            Console.WriteLine(c2.ToString());
            c2.Tilanne();


            Console.WriteLine();
            Console.WriteLine("Firma uudestaan");
            Company c3 = new Company(c1);
            Console.WriteLine(c3.ToString());


        }
    }
}
