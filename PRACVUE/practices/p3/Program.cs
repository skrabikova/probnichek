using gpr2;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace gpr2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lib = new Library();
            lib.AddBook(new Book("1984", "Дж. Оруэлл", 350));
            lib.AddBook(new Book("Мастер и Маргарита", "М. Булгаков", 520));

            lib.PrintAllBooks();

            // Пример работы метода Read
            var book1 = new Book("Евгений Онегин", "А.С. Пушкин", 167);
            book1.Read(50);      // прочитаем 50 страниц
            book1.Read(200);     // попробуем прочитать больше, чем есть
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        private int _readPages; // чтобы отслеживать, сколько прочитано

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
            _readPages = 0;
        }

        public void Read(int pages)
        {
            if (pages <= 0)
            {
                Console.WriteLine("Количество страниц должно быть положительным.");
                return;
            }

            int canRead = Math.Min(pages, Pages - _readPages);
            _readPages += canRead;

            Console.WriteLine($"Вы прочитали {_readPages} страниц из {Pages}.");

            if (_readPages >= Pages)
            {
                Console.WriteLine("Книга прочитана полностью!");
            }
        }
    }
}
public class Library
{
    private List<Book> _books;

    public Library()
    {
        _books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));

        _books.Add(book);
    }

    public void PrintAllBooks()
    {
        if (_books.Count == 0)
        {
            Console.WriteLine("В библиотеке нет книг.");
            return;
        }

        foreach (var book in _books)
        {
            Console.WriteLine($"«{book.Title}» — {book.Author}, {book.Pages} стр.");
        }
    }
}



