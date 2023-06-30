using MorochkkaKA_01_01;
using System;

namespace MorochkaKA_01_01Console
{
    class Program
    {
        static void Main (string[] args)
        {
            Product product1 = new Product("Яблоко", 12, 20);
            product1.Сalculations();
            Console.WriteLine(product1.Print());

            Product product2 = new Kkalories("Бургер", 272, 600, 1527);
            product2.Сalculations();
            Console.WriteLine(product2.Print());
        }
    }
}
