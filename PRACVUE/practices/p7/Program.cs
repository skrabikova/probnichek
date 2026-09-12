using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- ЗАДАНИЕ 1 ----");
            var dog = new Dog();
            dog.Name = "Шарик";
            dog.Eat();
            dog.Bark();

            var cat = new Cat();
            cat.Name = "Мурка";
            cat.Eat();
            cat.Meow();
            Console.WriteLine("---- ЗАДАНИЕ 2 ----");
            var dogs = new Dog();
            var cats = new Cat();

            dogs.Speak();
            cats.Speak();
            Console.WriteLine(" ---- ЗАДАНИЕ 3 ----");
            var dogsa = new Dog();
            dogsa.Move();
            Console.WriteLine(" ---- ЗАДАНИЕ 4 ----");
        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
            Console.WriteLine($"Созданно животное: {Name}");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} ест ");
        }
        public virtual void Speak()
        {
            Console.WriteLine("Животное издаёт звук");
        }
        public virtual void Move()
        {
            Console.WriteLine("Животное двигается");
        }
    }
    public class Dog : Animal
    {
    public void Bark()
      {
            Console.WriteLine($"{Name} лает");
      }
        public override void Speak()
        {
            Console.WriteLine("Собака говорит: Гав-гав!");
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Собака бежит по дороге.");
        }

    }
    public class Cat : Animal 
    {
       public void Meow()
       {
            Console.WriteLine($"{Name} мяукает ");
       }
        public override void Speak()
        {
            Console.WriteLine("Кошка говорит: Мяу!");
        }
    }
}
