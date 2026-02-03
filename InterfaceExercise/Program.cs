using static System.Formats.Asn1.AsnWriter;

namespace InterfaceExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> products = new List<Product>();
            products.Add(new Product("Uuni", 124.99, 450));
            products.Add(new Product("Kumivene", 19.99, 300));
            products.Add(new Product("Pannu", 39.00, 200));

            List<Customer> customersList = new List<Customer>();
            customersList.Add(new Customer("Jaana Mattinen", 26.00));
            customersList.Add(new Customer("Jari Jarinen", 740.00));
            customersList.Add(new Customer("Mikko Pakarinen" , 00.30));

            foreach (Product p in products)
            {
                if (p.MatchesName("Uuni"))
                {
                    Console.WriteLine("Uuni löytyi");
                    Console.WriteLine(p.ToString());

                    Console.WriteLine($"Varaston arvo: {p.CalculateTotal():F2}");
                }
            }
            Console.WriteLine();


            Store KMarket = new Store("K-kauppa", 1000000, 12034);
            KMarket.AddProduct(new Product("Maito", 1, 150));
            KMarket.AddProduct(new Product("RedBull", 2.30, 200));
            KMarket.PrintProducts();
            Console.WriteLine();

            foreach (Customer d in customersList)
            {
                Console.WriteLine(d.ToString());
            }
            Console.WriteLine();

            foreach (Customer d in customersList)
            {
                if (d.MatchesName("Mikko Pakarinen"))
                {
                    Console.WriteLine("Mikko löytyi");
                    Console.WriteLine(d.ToString());


                    double bonus = d.GetBonus();
                    Console.WriteLine($"{d.ToString()}, Bonus: {bonus:F3} €");
                }
            }
            Console.WriteLine();

            Console.WriteLine(KMarket.ToString());
    
            Console.ReadLine();


        }
    }
}