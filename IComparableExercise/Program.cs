using BookAndAuthorExercise;

namespace IComparableExercise;

internal class Program : Book
{
    static void Main(string[] args)
    {
        List<Book> myBooks = new List<Book>();
        myBooks.Add(new Book(""));

        myBooks.Sort();
    }
}
