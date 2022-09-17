using Microsoft.VisualBasic;
using System;

namespace ClassesEX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Added an extra 1 
            Car myCar = new Car
            {
                Year = 2021,
                Make = "Toyota",
                Model = "Corolla",
                Color = "White"
            };
            Console.WriteLine(myCar.Year);
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Color);
            Console.WriteLine((myCar.Year, myCar.Make, myCar.Model, myCar.Color));
            // so on line 22 with out the extra () in the writeline it would not run, why is that?
        }
    }
}
