using Olio_ohjelmointi.BookExercise;

namespace Olio_ohjelmointi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BookExercise");

            Book abcBook = new Book("Aapinen", "M. Agricola", 10, "12312312312");
            abcBook.PrintBookInfo();

            Book mathBook = new Book();
            mathBook.title = "Matikka 1 lk";
            mathBook.author = "Matti Meikäläinen";
            mathBook.PrintBookInfo();
        }

    }
}