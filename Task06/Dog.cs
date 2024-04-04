using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace TASK06
{
    internal class Dog : Animal
    {
        string breed;
        public string Breed { get => breed; set => breed = value; }
        public Dog(string name, double age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        new public void DispalyInfo()
        {
            Console.WriteLine($"The Animal Name is {Name}\nThe Animal Age is {Age}\nThe Dog Breed is {Breed}");
        }

    }
}
