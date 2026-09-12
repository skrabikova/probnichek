using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10
{
     public class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog("Шарик");
            var c = new Cat("Мурка");
            var e = new Elephant("Дамбо");
            d.Bark(); c.Meow(); e.Trumpet();
            Animal[] zoo =
    {
        new Dog("Шарик"),
        new Cat("Мурка"),
        new Elephant("Дамбо"),
        new Animal("Неопознанный")
    };

            // Проходим по всем животным в массиве и вызываем MakeSound()
            foreach (var a in zoo)
            {
                a.MakeSound();
            }
            var zooPark = new Zoo(5);
            zooPark.Add(new Dog("Рекс"));
            zooPark.Add(new Cat("Снежок"));
            zooPark.Add(new Elephant("Балу"));

            Console.WriteLine("=== Звуки ===");
            zooPark.MakeAllSounds();

            Console.WriteLine("=== Кормим ===");
            zooPark.FeedAll();
        }
    }
}
