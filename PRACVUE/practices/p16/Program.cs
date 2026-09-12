using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace p16
{
    public class Program
    {
        static void Main(string[] args)
        {
        var books = new List<Book>();
            {
                new Book { Title = "Война и мир", Author = "Толстой", Year = 1869 };
                new Book { Title = "Преступление и наказание", Author = "Достоевский", Year = 1866 };
                string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("books.json", json);
                string jsonFromFile = File.ReadAllText("books.json");
                var booksFromFile = JsonSerializer.Deserialize<List<Book>>(jsonFromFile);
                foreach (var book in booksFromFile)
                {
                    Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Год: {book.Year}");
                }
                }
            }
        }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

    } 
    public class Library
    {
      public string Name { get; set; }
      public string  Books { get; set; } 

    }
}
    


