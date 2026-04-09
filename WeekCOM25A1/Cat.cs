using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekCOM25A1
{
    internal class Cat:Animal
    {
        private string furColor;

        public Cat(string name, int age,string furColor):base(name,age)
        {
            this.furColor = furColor;
        }

        public string FurColor { get => furColor; set => furColor = value; }

        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
