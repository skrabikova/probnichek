using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----ЗАДАНИЕ 1----");
            Shape[] shapes =
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Circle(3),
            new Rectangle(2, 8)
        };

            foreach (var shape in shapes)
            {
                shape.Print();
            }
            Console.WriteLine("---- ЗАДАНИЕ 2 -----");
            Animal[] animals =
        {
            new Dog("Рекс"),
            new Cat("Мурка")
        };

            foreach (var animal in animals)
            {
                animal.Eat();
                animal.MakeSound();
            }
            Console.WriteLine("----ЗАДАНИЕ 3 -----");
            Transport[] t = { new Car(), new Boat() };
            foreach (var x in t) x.Move();
            Console.WriteLine("---- ЗАДАНИЕ 4 ----");
            DocumentExporter[] exporters =
{
    new TxtExporter(),
    new PdfExporter()
};

            foreach (var e in exporters)
            {
                e.ShowInfo("Hello world!");
                e.Export("Hello world!");
            }
        }
    }
    public abstract class Shape
    {
        public abstract string Name { get; }
        public abstract double GetArea();
        public void Print()
        {
            Console.WriteLine($"{Name}: площадь = {GetArea()} ");
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override string Name => "Круг";
        public override double GetArea() => Math.PI * Radius * Radius;
    }
    public class Rectangle : Shape
    {
        public double Wight { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Wight = width;
            Height = height;
        }
        public override string Name => "Прямоугольник";
        public override double GetArea() => Wight * Height;
    }
    public abstract class Animal
    {
        public string Name { get; }
        protected Animal(string name)
        {
            Name = name;
            Console.WriteLine($"Создано животное по имени:{Name}");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} ест");
        }
        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void MakeSound() => Console.WriteLine($"{Name} гав-гав!");
    }
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void MakeSound() => Console.WriteLine($"{Name} мяу-мяу!");
    }
    public abstract class Transport
    {
        public void Move()
        {
            Start();
            MoveCore();
            Stop();
        }
        protected void Start() => Console.WriteLine("Старт");
        protected abstract void MoveCore();
        protected void Stop() => Console.WriteLine("Стоп");
    }
    public class Car : Transport
    {
        protected override void MoveCore() => Console.WriteLine("Машина едет по дороге");
    }
    public class Boat : Transport
    {
        protected override void MoveCore() => Console.WriteLine("Лодка плывёт по воде");
    }
    public abstract class DocumentExporter
    {
        public abstract string FormatName { get; }

        public abstract void Export(string content);

        public void ShowInfo(string content) => Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
    }
    public class TxtExporter : DocumentExporter
    {
        public override string FormatName => "TXT";

        public override void Export(string content) => Console.WriteLine("Сохраняем текстовый файл");
    }
    public class PdfExporter : DocumentExporter
    {
        public override string FormatName => "PDF";

        public override void Export(string content) => Console.WriteLine("Создаём PDF-документ");
    }
}
