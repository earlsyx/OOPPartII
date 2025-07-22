using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IRun> runs = new List<IRun>();
            Person person = new Person();
            Animal animal = new Animal();

            runs.Add(person);
            runs.Add(animal);

            foreach (var run in runs)
            {
                Console.WriteLine($"{run}");
            }

            Console.ReadLine();
        }
    }
}
