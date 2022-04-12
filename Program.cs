using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            praduct praduct = new praduct("iphone");
            praduct.Count = 17;
            praduct.Price = 2900;
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            praduct.Sell();
            Console.WriteLine($"{praduct.Count}\n{praduct.Totoalinciom}");
        }
    }
}
