using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime;
using System.ComponentModel.Design;

namespace p15
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(" ---- ЗАДАНИЕ 1");
            string path = "notex.txt";               // ЭТО Я СОЗДАЛА ФАЙЛ
            File.WriteAllLines(path, new[]
            {
            "Заметка 1",
            "Заметка 2",                           // ЗАПИСАЛА ЧЕРЕЗ МЕТОД WriteAllLines 3 заметки
            "Заметка 3"
            });
            File.AppendAllText(path, Environment.NewLine  + "Заметка 4");  // потом добавила 4 заметку через метод   AppendAllText 
            string newFile = await File.ReadAllTextAsync(path);
            Console.WriteLine(newFile);
            Console.WriteLine("Удалить файл? (y/n):");
            if (Console.ReadLine()?.ToLower().Trim() == "y")     // это я удалила файл метод Trim убирает лишнее пробелы а Tolower большие буквы превращает вмаленькие
            {
                File.Delete(path);
                Console.WriteLine("файл удален");
            }
            else 
            {
                Console.WriteLine("Файл оставлен");
            }
            Console.WriteLine("---- ЗАДАНИЕ 2 ----");
            string dir = "data";
            Directory.CreateDirectory(dir);
            File.WriteAllText(Path.Combine(dir, "a.txt"), "текст 1");
            File.WriteAllText(Path.Combine(dir, "b.txt"), "текст 2");
            File.WriteAllText(Path.Combine(dir, "b.md"), "текст 3");
            foreach (var pk in Directory.GetFiles(dir, "*.txt"))
            {
                var info = new FileInfo(pk);
                Console.WriteLine($"{info.Name} -- {info.Length} байт");
            }
            Console.WriteLine(" ---- ЗАДАНИЕ 3 ----");
            Console.Write("Путь к файлу: ");
            string? src = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(src) && File.Exists(src))
            {
                string dirS = Path.GetDirectoryName(src)!;
                string name = Path.GetFileName(src);
                string bak = Path.Combine(dirS, name + ".bak");
                File.Copy(src, bak, overwrite: true);
                Console.WriteLine($"Создана копия: {bak}");
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }

        }
    }
}

