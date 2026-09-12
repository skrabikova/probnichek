using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
namespace p4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- ЗАДАНИЕ 1 ----");
            void SayHello()
            {
                Console.WriteLine("привет мир!");
            }
            SayHello();
            SayHello();
            SayHello();
            Console.WriteLine("---- ЗАДАНИЕ 2 ----");
            void Greet (string name)
            {
                Console.WriteLine("Привет" + name + "!");
            }
            Greet("Саша");
            Greet("Ярослав");
            Greet("Анна");
            Console.WriteLine("---- ЗАДАНИЕ 3 ----");
            void PrintPerson(string name, int age, string citi)
            {
                Console.WriteLine($" Имя:{name},Возраст:{age}, Город: {citi}");
            }
            PrintPerson("Артур", 23, "Казань");
            PrintPerson("Ольга", 30, "Москва");
            Console.WriteLine("---- ЗАДАНИЕ 4 ----");
            void PrintPersons(string name, int age = 18, string hobby = "Не указано")
            {
                Console.WriteLine($"Имя: {name}, Возраст: {age}, Хобби: {hobby}");
            }
            PrintPersons("Катя", 14);
            PrintPersons("Антон", 27,"футбол");
            Console.WriteLine("---- ЗАДАНИЕ 5 ----");
            int Square(int x)
            {
                return x * x;
            }
            int result = Square(7);
            Console.WriteLine($"Квадрат числа равен = {result}");
            Console.WriteLine("---- ЗАДАНИЕ 6 ----");
            Console.WriteLine("Введите два числа");
            Console.Write("Первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Воторое число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию (+, -, *, /): ");



        }
    }
}
