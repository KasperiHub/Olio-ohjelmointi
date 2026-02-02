using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExercise;

namespace InterFaceExcercise
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
        }



        public void AddCustomer(Customer customer)
        {
            this.customersList.Add(customer);
        }

        public void AddProduct(Product product)
        {
            this.productsList.Add(product);
        }

        public void PrintCustomers()
        {
            foreach (Customer p in this.customersList)
            {
                Console.WriteLine(p);
            }
        }

        public void PrintProducts()
        {
            foreach (Product d in this.productsList)
            {
                Console.WriteLine(d);
            }
        }


    }


}