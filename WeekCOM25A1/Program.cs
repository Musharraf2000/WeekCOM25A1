// See https://aka.ms/new-console-template for more information

using System.Data.Common;
using WeekCOM25A1;

//List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Cat c1 = new Cat("Tom",5,"Grey");
//Bird b1 = new Bird("Jack",2,"Green");

//c1.makeSound();
//b1.makeSound();

//List<Animal> cats = new List<Animal>() { c1,b1 };

//Cat is a Cat and Cat is also an animal object

//Member m1 = new PremiumMember("Member1", "John Doe", 10000.0, 20000.0);
//Member m2 = new RegularMember("Member1", "John Doe", 5000.0);



//Console.WriteLine(m1.CalculateFee());
//Console.WriteLine(m1.CalculateFee(4));


//if(m1.CalculateFee(4) > 50000)
//{
//    Console.WriteLine("High Value");
//}
//else
//{
//    Console.WriteLine("Budget");
//}

//    Console.WriteLine();
//Console.WriteLine(m2.CalculateFee());


//if (m2.CalculateFee(4) > 50000)
//{
//    Console.WriteLine("High Value");
//}
//else
//{
//    Console.WriteLine("Budget");
//}

Ride r1 = new CarRide("Ride1",10,120,2);
Ride r2 = new BikeRide("Ride2", 10, 90, 20);

Console.WriteLine(r1.calculateFare());
Console.WriteLine(r1.calculateFare(5));


Console.WriteLine(r2.calculateFare());
Console.WriteLine(r2.calculateFare(5));