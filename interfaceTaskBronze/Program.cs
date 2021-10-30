using System;

namespace interfaceTaskBronze
{
    interface Italk
    {
        void talk();
    }
    interface Ieat
    {
        void eat();
    }

    class Program
    {
        public class Cat : Ieat,
        {
            public void eat()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
