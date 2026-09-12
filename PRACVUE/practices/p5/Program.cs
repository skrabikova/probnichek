using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static p5.Program;

namespace p5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Audi", 50);
            car.Accelerate();
            Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed} км/ч");
            Console.WriteLine(" ---- ЗАДАНИЕ 3 ----");
            var books = new Book("Евгений Онегин", "А.С. Пушкин",300);
            books.Read(60);
        }
        public class Car
        {
            public string Brand { get; set; }
            public int Speed { get; private set; } = 40;
            public Car(string brand, int speed)
            {
                Brand = brand;
                Speed = speed;
            }
            public void Accelerate()
            {
                Speed+=10;
            }
        }
        public class Book 
        {
         public string Title { get; private set; }
         public string Author { get; private set; }
         public int Pages { get; private set; } 

         public Book(string title, string author, int pages)
            {
                Title = title;
                Author = author;
                Pages = pages;
            }
          public void Read(int pages)
          {
          Console.WriteLine($"Вы прочитали {pages} из {Pages}");
          }
        }
        public class Library
        {

        }
    }
}
