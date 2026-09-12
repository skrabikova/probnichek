using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace p9
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- ЗАДАНИЕ 1 ----");
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal cow = new Cow();

            dog.Speak();
            cat.Speak();
            cow.Speak();
            Console.WriteLine("---- ЗАДАНИЕ 2 ----");
            Transport[] vehicles =
{
    new Car { Model = "Audi" },
    new Boat { Model = "Yamaha" },
    new Plane { Model = "Boeing" }

};

            foreach (var v in vehicles)
            {
                v.Move();
            }
            Console.WriteLine("---- ЗАДАНИЕ 3 ----");
            Shape[] shapes =
{
    new Circle { Radius = 5 },
    new Square { Side = 4 },
    new Rectangle { Width = 3, Height = 6 }
};

            foreach (var s in shapes)
            {
                Console.WriteLine(s.GetArea());
            }
            Console.WriteLine("---- ЗАДАНИЕ 4 ----");
            Instrument[] instruments =
{
    new Guitar(),
    new Piano(),
    new Drum()
};

            foreach (var i in instruments)
            {
                i.Play();
            }
            Console.WriteLine("---- ЗАДАНИЕ 5 ----");
            Character[] team =
{
    new Warrior { Name = "Алекс" },
    new Mage { Name = "Лия" },
    new Archer { Name = "Робин" }
};

            foreach (var c in team)
            {
                Console.Write($"{c.Name}: ");
                c.Attack();
            }


        }
    }
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Животное издаёт звук.");
        }
    }
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Собака говорит: Гав-гав!");
        }
    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("кошка говрит: Мяу-мяу!");
        }
    }
    public class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Крова говрит: Муу!");
        }
    }
    public class Transport
    {
        public string Model { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"{Model}: транспорт движется.");
        }
    }
    public class Car : Transport
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Машина едет по дороге");
        }
    }
    public class Boat : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Лодка плывет по дороге");
        }
    }
    public class Plane : Transport
    {
        public override void Move()
        {
            Console.WriteLine("Самолет летит в небе");
        }
    }
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea() => Math.PI * Radius * Radius;
    }
    public class Square : Shape
    {
        public double Side { get; set; }
        public override double GetArea() => Side * Side;
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea() => Width * Height;
    }
    public class Instrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Инструмент издаёт звук");
        }
    }
    public class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Гитара играет аккорды");
        }
    }

    public class Piano : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Пианино играет мелодию");
        }
    }

    public class Drum : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Барабан бьёт ритм");
        }
    }
    public abstract class Character
    {
        public string Name { get; set; }
        public abstract void Attack();
    }
    public class Warrior : Character
    {
        public override void Attack() => Console.WriteLine("Воин атакует мечом!");
    }
    public class Mage : Character
    {
        public override void Attack() => Console.WriteLine("Маг выпускает огненный шар!");
    }
    public class Archer : Character
    {
        public override void Attack() => Console.WriteLine("Лучник стреляет из лука!");
    }
}
