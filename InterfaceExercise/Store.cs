using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Store : IProducts, ICustomers

    {
        private string name;
        private double revenue;
        public double products;


        private List<Product> productsList = new List<Product>();
        private List<Customer> customersList = new List<Customer>();
        

        public Store(string name, double revenue, double products)
        {
            this.name = name;
            this.revenue = revenue;
            this.products = products;
        }


        public int GetCustomerCount()
        {
            return customersList.Count;
        }

        public void AddCustomer(Customer customer)
        {
            customersList.Add(customer);
        }

        public int GetProductCount()
        {
            return productsList.Count;
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

        public override string? ToString()
        {
            return $"Kaupan nimi: {this.name}, Kaupan liikevaihto: {this.revenue}, Kaupan tuotteiden määrä: {this.products} Asiakkaiden määrä: {GetCustomerCount()}";
        }


    }


}