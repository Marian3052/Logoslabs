using System;

namespace shop
{
    public abstract class shop
    {
        public abstract class goods
        {
            public void priсe()
            {
                Console.WriteLine(name + "price" + price);
            }
            public goods(string name, int priсe)
            {
                this.name = name;
                this.price = priсe;
            }

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
