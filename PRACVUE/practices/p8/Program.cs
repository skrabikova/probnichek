using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p8
{
     public  class Program
    {
        static void Main(string[] args)
        {
        var p = new Person();
            p.Name = "Алиса";
            p.Age = 25;
            p.Age = -5;
        }
    }
    public class Person
    {
       private int age;
        private string name;
        public string Name
        {
            get { return name; }
            set;
         }
        public int Age 
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Возраст не модет быть отрицательным");
            }
        }
    }
}   
