using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---- ЗАДАНИЕ 1 ----");
           var numbers = new List<int> { 12, 5, 8, 19, 3 };
            Console.WriteLine("Исходный список: " + string.Join(" ", numbers));
            numbers.Sort();
            Console.WriteLine("Отсортированый список:" + string.Join(" ", numbers));
            int min = numbers.Min();
            int max = numbers.Max();
            Console.WriteLine($"Минимальное число {min} , Максимальное число {max}");
            numbers.Reverse();
            Console.WriteLine("Перевернутый список:" + string.Join("", numbers));
            Console.WriteLine(" ---- ЗАДАНИЕ 2 ----");
            var phoeneBook = new Dictionary<string, string>();
            phoeneBook.Add("Анна", "8965-788-54-54");
            phoeneBook.Add("Иван", "8950-888-67-69");
            phoeneBook.Add("Ольга", "8967-456-09-00");
            Console.WriteLine(phoeneBook["Иван"]);
            Console.WriteLine( phoeneBook["Ольга"]);
            Console.WriteLine(" ---- ЗАДАНИЕ 3 ----");
            var clients = new Queue<string>();
            clients.Enqueue("Анна");
            clients.Enqueue("Иван");
            clients.Enqueue("Мария");
            clients.Enqueue("Олег");
            Console.WriteLine($"Первый в очереди: {clients.Peek()}");
            while (clients.Count > 0) 
            {
                string client = clients.Dequeue();
                Console.WriteLine($"{client} обслужен");
            }
            Console.WriteLine(" ---- ЗАДАНИЕ 4 ----");
            var actions = new Stack<string>();
            actions.Push("Первый");
            actions.Push("Второй");
            actions.Push("Третий");
            Console.WriteLine($"Верхнее действие: {actions.Peek()}");
            while (actions.Count > 0)
            {
                string action = actions.Pop();
                Console.WriteLine($"Отменен {action}");
            }
            Console.WriteLine(" ---- ЗАДАНИЕ 5 ----");
            var prices = new Dictionary<string, int>
            {
             {"Кофе", 150},
             {"Чай", 100},
             {"Сэндвич", 250 },
            };
            var custeomers = new Queue<string>();
            custeomers.Enqueue("Анна");
            custeomers.Enqueue("Иван");
            var spisok = new List<string>() { "Кофе", "Сэндвич" };
            Console.WriteLine("Обслуживание клиентов");
            while (custeomers.Count > 0)
            {
                string client = custeomers.Dequeue();
                Console.WriteLine($"\nКлиент {client}:");

                foreach (var item in spisok)
                    Console.WriteLine($"{item} -- {prices[item]} рубю");
            }
        }
    }
}

