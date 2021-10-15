using System;

namespace shop
{
    public abstract class shop
    {
        public abstract class goods
        {
            
            public goods(string name, int priсe)
            {
                this.name = name;
                this.price = priсe;
            }

        }
        public abstract class fruits : goods
        {

        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
