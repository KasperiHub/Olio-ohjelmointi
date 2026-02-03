using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Store : IProducts, ICustomers

    {
        private string name;
        private double revenue;


        private List<Product> productsList = new List<Product>();
        private List<Customer> customersList = new List<Customer>();

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
            productsList = new List<Product>();
        }



        public void AddCustomer(Customer customer)
        {
            customersList.Add(customer);
        }

        public void AddProduct(Product product)
        {
            productsList.Add(product);
        }

        public void PrintCustomers()    
        {
            foreach (Customer d in customersList)
            {
                Console.WriteLine(d);
            }
        }

        public void PrintProducts()
        {
            foreach (Product p in productsList)
            {
                Console.WriteLine(p);
            }
        }


    }


}