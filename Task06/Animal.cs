using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK06
{
    internal class Animal
    {
        string name;
        double age;

        public string Name { get => name; set => name = value; }
        public double Age { get => age; set => age = value; }


        public Animal(string name, double age)
        {
            Name = name;
            Age = age;
        }

        public void DispalyInfo()
        {
            Console.WriteLine($"The Animal Name is {Name}\nThe Animal Age is {Age}");
        }


    }
}
