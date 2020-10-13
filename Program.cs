using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("A");
            double numbera = double.Parse(Console.ReadLine());
            Console.WriteLine("B");
            double numberb = double.Parse(Console.ReadLine());
            Console.WriteLine("С");
            double numberc = double.Parse(Console.ReadLine());
            double D = numberb * numberb - (4 * numbera * numberc);
            Console.WriteLine($"D={D}");
        }
    }
}
