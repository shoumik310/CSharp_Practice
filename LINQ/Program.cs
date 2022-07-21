// See https://aka.ms/new-console-template for more information
 var books = BookRepository.GetBooks();

//LINQ Query

var queryBooks = from b in books
                 where b.Price < 10
                 orderby b.Title
                 select b.Title;

foreach (var book in queryBooks)
{
    Console.WriteLine(book);
}

Console.WriteLine();
//LINQ extension functions

var cheapBooks = books
                    .Where(b => b.Price < 10)
                    .OrderBy(b => b.Title)
                    .Select(b => b.Title);

foreach (var book in cheapBooks)
{
    Console.WriteLine(book);
}
Console.WriteLine();

var b1 = books.First(b => b.Title == "C# Advanced Topics");
var b2 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics++");
Console.WriteLine("First: {0}, {1} ", b1?.Price, b2?.Price);
Console.WriteLine();

var b3 = books.Last(b => b.Title == "C# Advanced Topics");
var b4 = books.LastOrDefault(b => b.Title == "C# Advanced Topics++");
Console.WriteLine("Last: {0}, {1} ", b3?.Price, b4?.Price);
Console.WriteLine();

Console.WriteLine("Max: {0}",books.Max(b => b.Price));
Console.WriteLine("Min: {0}", books.Min(b => b.Price));
Console.WriteLine("Sum: {0}", books.Sum(b => b.Price));
Console.WriteLine("Avg: {0}", books.Average(b => b.Price));
Console.WriteLine();

Console.WriteLine("Count: {0}", books.Count());
Console.WriteLine();

foreach (var book in books.Skip(2).Take(3))
{
    Console.WriteLine(book.Title);
}
