using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi!");
            Console.WriteLine("-----");
            Console.WriteLine("1 - Hello!");
            Console.WriteLine("2 - bey!");
            int a = Int32.Parse(Console.ReadLine());

            if (a != 1)
            {
                return;
            }

            Console.WriteLine("lets go play a game");
            var random = new Random();
            int number = random.Next(0, 10); // 0 - мін, 10 - макс









            Console.ReadKey();
        }
    }
}
