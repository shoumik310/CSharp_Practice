// See https://aka.ms/new-console-template for more information
public class BookRepository
{
    public static IEnumerable<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book(){ Title = "ADO.NET Step by Step", Price = 5},
            new Book(){Title = "ASP.NET MVC", Price = 9.99f},
            new Book(){Title = "ASP.NET Web API", Price = 12},
            new Book(){Title = "C# Advanced Topics", Price = 7},
            new Book(){Title = "C# Advanced Topics", Price = 9}
        };
    }
}