using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The next data is from the based class(Main class)\n");
            Console.WriteLine("");
            Animal fish = new Animal("Normal Fish", 6);
            fish.DispalyInfo();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("The next data is from the child class(that inherits from the Main class)\n");
            Dog mydog = new Dog("Alpha", 6, "egyption breed");
            mydog.DispalyInfo();
            Console.WriteLine("\n");

        }
    }
}
