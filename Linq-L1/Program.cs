using LibraryManagementSystem;
using LINQ_DATA;
using System;
using System.Diagnostics.Metrics;
using static System.Reflection.Metadata.BlobBuilder;

internal class Program
{
    public static void Main(string[] args)
    {
        //var result1 = LibraryData.Authors.Where(author => author.Country == "UK" && author.Name == "Martin Fowler");
        //result1.ToConsoleTable();

        //        1.Find All Available Books#  
        //var result1 = LibraryData.Books.Where(book => book.IsAvailable == true);
        //result1.ToConsoleTable();

        // 2. Get All Book Titles
        //var result2 = LibraryData.Books
        //    .Where(book => book.IsAvailable)
        //    .Select(book => new { Title = book.Title });
        //result2.ToConsoleTable();

        // 3. Find Books by Genre
        //var result3 = LibraryData.Books
        //    .Where(book => book.Genre == "Programming");
        //result3.ToConsoleTable();

        // 4. Sort Books by Title
        //var result4 = LibraryData.Books
        //    .OrderBy(book => book.Title);
        //result4.ToConsoleTable();

        // 5. Find Expensive Books(30$)
        //var result5 = LibraryData.Books
        //    .Where(book => book.Price > 30);
        //result5.ToConsoleTable();

        // 6. Get Unique Genres
        //var result6 = LibraryData.Books
        //    .Select(book => new { Genra = book.Genre }).Distinct();
        //result6.ToConsoleTable();

        // 7. Count Books by Genre
        //var result7 = LibraryData.Books
        //    .GroupBy(book => book.Genre)
        //    .Select(book => new
        //    {
        //        Genra = book.Key,
        //        count = book.Count()
        //    });
        //result7.ToConsoleTable();

        // 8. Find Recent Books(after 2010)
        //var result8 = LibraryData.Books
        //    .Where(book => book.PublishedYear > 2010);
        //result8.ToConsoleTable();

        // 9. Get First 5 Books
        //var result9 = LibraryData.Books
        //    .Skip(0)
        //    .Take(5);
        //result9.ToConsoleTable(); 

        // 10. Check if Any Expensive Books Exist(over 50)
        //var result10 = LibraryData.Books
        //    .Any(Isover50);
        //static bool Isover50(Book book) => book.Price > 50;
        //Console.WriteLine(result10);

        var booksWithAuthors = LibraryData.Books
      .Join(LibraryData.Authors,
            book => book.AuthorId,
            author => author.Id,
            (book, author) => new
            {
                BookName = book.Title,
                AuthorName = author.Name,
                book.Genre,
                book.Price,
                book.PublishedYear
            });
        booksWithAuthors.ToConsoleTable();








    }
}