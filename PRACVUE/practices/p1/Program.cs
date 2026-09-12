using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("число положительноу");
            }
            else if (number < 0)
            {
                Console.WriteLine("число отрицательное");
            }
            else if (number == 0)
            {
                Console.WriteLine("число равно нулю");
            }

            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Высовершенон летний");
            }
            else
            {
                Console.WriteLine("внесовешенно летний");
            }

            int num = 7;
            if (num % 2 == 0)
            {
                Console.WriteLine("число четное");
            }
            else 
            {
                Console.WriteLine("Число нечетное");
            }
            int a = 5;
            int b = 6;
            if (a > 0 && b >0)
            {
                Console.WriteLine("Оба числа положительны");
            }
            else if (a > 0 || b > 0)
            {
                    Console.WriteLine("Одно число положительно");
            }
            Console.WriteLine("Введите оценку ученика: ");
            int grade = int.Parse(Console.ReadLine());
            if (grade < 3)
            {
                Console.WriteLine("Оценка ученика неудовлетворительно");
            }
            else if (grade >= 3)
            {
                Console.WriteLine("Оценка ученика удовлитворительно");
            }
            else if (grade == 4)
            {
                Console.WriteLine("оцека хорошо");
            }
            else
            {
                Console.WriteLine("Оценка отлично");
            }
        }
            


}
}

