using BookAndAuthorExercise;

namespace IComparableExercise;

internal class Program : Book
{
    static void Main(string[] args)
    {
        List<Book> myBooks = new List<Book>();
        myBooks.Add(new Book("a", "b", "c", 1, "1"));

        myBooks.Sort();
    }
}
