using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekCOM25A1
{
    internal class Bird:Animal
    {
        private string featherColor;

        public Bird(string name, int age, string featherColor) : base(name, age)
        {
            this.featherColor = featherColor;
        }

        public string FeatherColor { get => featherColor; set => featherColor = value; }

        public override void makeSound()
        {
            Console.WriteLine("Chirp");
        }
    }
}
