using Literature;
namespace BookAndAuthorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Matti", "Otava", "Matikkamatskut", 25.50, "978-21482-226"); //Book details and ISBN

            Book book2 = new Book("Jarkko", "Otava", "Äidinkieli", 35.00, "978-26613-312");

            Console.WriteLine(book1.GetBookDetails("978-21482-226"));
            Console.WriteLine(book2.GetBookDetails("978-26613-312"));
            Console.WriteLine();

            /*Book.ChangeTheme(); //Testing changing the theme
            Console.WriteLine(book1.GetBookDetails("978-456-97845"));
            */

            Book book3 = new Book("P. Jäntti", "Otava", "Ruotsi", 34.00, "978-456-34567");
            Book book4 = new Book("M. Pakarinen", "Otava", "Maantieto", 40.00, "978-456-45678");
            Author author1 = new Author("P. Jäntti", "09.06.2003", book3);
            Author author2 = new Author("J. Jarkkonen", "01.01.1995");
            Author author3 = new Author("M. Pakarinen", "01.02.2004", book4);

            Console.WriteLine();    //Printing the books and author. author2 does not have a book, program prints No information.
            author1.PrintInformation();
            Console.WriteLine();
            author2.PrintInformation();
            Console.WriteLine();
            author3.PrintInformation();
        }
    }
}