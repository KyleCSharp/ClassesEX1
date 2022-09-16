using Microsoft.VisualBasic;
using System;

namespace ClassesEX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car myCar = new Car();
            myCar.year = 2021;
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Color = "White";
            Console.WriteLine(myCar.year);
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Color);
        }
    }
}
