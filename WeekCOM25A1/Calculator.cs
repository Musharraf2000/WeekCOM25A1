using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekCOM25A1
{
    internal class Calculator
    {
        public void AddNum(int num1, int num2)
        {
            Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
        }

        public void AddNum(double num1, double num2)
        {
            Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
        }



        public void AddNum(int num1, int num2,int num3) { 
        
            Console.WriteLine($"The sum of {num1}, {num2} and {num3} is: {num1 + num2 + num3}"); 
        }
    }
}
