using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class prg3
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public prg3()
        {
          
                Console.Write("Id:");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name:");
                name = Console.ReadLine();
                Console.Write("Age:");
                age = Convert.ToInt32(Console.ReadLine());
          
        }
        public void displayFunction(prg3 prgObj)
        {
                id = prgObj.id;
                name = prgObj.name;
                age = prgObj.age;
                Console.WriteLine($"Id:{id},Name:{name},Age:{age}");
           
        }
    }
}
