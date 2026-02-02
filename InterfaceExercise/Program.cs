using InterfaceExercise;
using static System.Formats.Asn1.AsnWriter;

namespace InterFaceExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
                // Console.WriteLine(p);
                if (p.MatchesName("Aurinkotuoli"))
                {
                    Console.WriteLine("Aurinkotuoli löytyi");
                    Console.WriteLine(p.ToString());

                    Console.WriteLine($"Varaston arvo: {p.CalculateTotal():F2}");
                }
            }

            Store KMarket = new Store("K-kauppa", 1000000);
            KMarket.AddProduct(new Product("Maito", 1, 150));
            KMarket.AddProduct(new Product("RedBull", 2.30, 200));
            KMarket.PrintProducts();
            Console.WriteLine();

            foreach (Customer d in customersList)
            {
                Console.WriteLine(d.ToString());
            }
        }
    }
}