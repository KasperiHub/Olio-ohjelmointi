using BookAndAuthorExercise;

namespace BookAndAuthorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book b1 = new Book("Matti", "Otava", "Matikkamatskut", 25.50, "978-21482-226");
            Book b2 = new Book("Jarkko", "Otava", "Äidinkieli", 35.00, "978-26613-312");
            Console.WriteLine(b1.GetBookDetail("978-21482-226"));
            Console.WriteLine(b2.GetBookDetail("978-26613-312"));

            Book.ChangeTheme();
            Console.WriteLine(b1.GetBookDetail("978-21482-226"));

        }
    }
}
