using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace p6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- ЗАДАНИЕ 1 ----");
            var book1 = new Book();
            var book2 = new Book("Мертвые души");
            var book3 = new Book("Мертвые души", "Гоголь");
            var book4 = new Book("Мерьвые души", "Гоголь", 600);
            book1.PrintInfo();
            book2.PrintInfo();
            book3.PrintInfo();
            book4.PrintInfo();
            Console.WriteLine(" ---- ЗАДАНИЕ 2 ----");
            var car1 = new Car();
            var car2 = new Car("Тойота");
            var car3 = new Car("Тойта", "Марк2", 500);
            car1.Mas();
            car2.Mas();
            car3.Mas();
            Console.WriteLine(" ---- ЗАДАНИЕ 3 ----");
        }
    }
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Page { get; set; }
        public Book()
        {
            Title = "Неизвестно";
            Author = "Неизвестен";
            Page = 0;
        }
        public Book(string title)
        {
            Title = title;
            Author = "Неизвестен";
            Page = 0;
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Page = 0;
        }
        public Book(string title, string author, int page)
        {
            Title = title;
            Author = author;
            Page = page;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Книга: {Title}, Автор: {Author}, Страниц: {Page}");
        }
    }
    public class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Speed { get; }
        public Car() : this("Неизвестин", "Неизвестна", 0) { }
        public Car(string brand) : this(brand, "Неизвестна", 0){ }
        public Car(string brand, string model, int speed)
        {
            Brand = brand;
            Model = model;
            Speed = speed;
        }
        public void Mas()
        {
            Console.WriteLine($" Бренд: {Brand} , Модель {Model} , Скорость {Speed}");
        }
        public class Player
        {
          public string Name { get; set; }
           
        }
    }
}

