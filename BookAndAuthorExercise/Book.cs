using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndAuthorExercise
{
    internal class Book
    {
        private string name;
        private string author;
        public string publisher;
        private double price;
        private string? isbn;
        public static string theme = "undefined";
        private const double DiscountProcent = 0.9; // discout 10%
        private const int MaxLength = 13;
        private const string Prefix = "978";

        public Book()
        {
            this.name = String.Empty;
            this.author = String.Empty;
            this.publisher = String.Empty;
            this.price = 0;
            this.isbn = String.Empty;
            

        }

        public Book(string author, string publisher, string name, double price, string isbn)
        {
            this.author = author;
            this.publisher = publisher;
            Name = name;
            Price = price;
            Isbn = isbn;
        }

        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value?.Length >= 1) //price kohdassa kun yrität tarkistaa 
                {
                    name = value;
                }
            }
        } // helpommin muokattava 

        // public string Author { get => author; set => author = value; } helpommin ymmärrettävä

        public double Price
        {
            get => price;
            set
            {
                if (value > 30)
                {
                    price = value * DiscountProcent;
                }
                else
                {
                    price = value;
                }
            }
        }
        public string? Isbn
        {
            get => isbn;
            set
            {
                if (value?.Length == MaxLength && value.StartsWith(Prefix))
                {
                    isbn = value;                }
                else
                {
                    isbn = "error";
                }
                
            }
        }

        public string Author 
        {
          get => author;
        }

        public override string? ToString()
        {
            return $"{this.author}, {this.Name}, {this.publisher}, {this.Price:F2}, {this.Isbn} , teema: {theme}";
        }

        /*
        public void GetBookDetails()
        {
            Console.WriteLine($"{this.author}, {this.Name}, {this.publisher}, {this.Price:F2}, {this.Isbn}");
        }
        */

        public string GetBookDetail(string isbnValue)
        {
            if (this.Isbn == isbnValue)
            {
                return ToString();
            }
            else
            {
                return "kirjan tietoja ei voi tulostaa";
            }

        }
        public static void ChangeTheme()
        {
            Console.WriteLine("Anna teema:");
            string? input = Console.ReadLine();
            if (input != null)
            {
                theme = input;
            }
   

        }
    }
}
