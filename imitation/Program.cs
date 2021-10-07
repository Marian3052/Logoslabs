using System;

namespace imitation
{
    abstract class car{
         
public abstract void CompletSet ();

     }

    class Mustang : car{
        public override void CompletSet()
        {
            Console.WriteLine("complete set:  GT");
        }
    }

    

    class BMW : car{

        public override void CompletSet()
        {
            Console.WriteLine("complete set: M-sport");
        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            
            Mustang mustang = new Mustang();
            BMW bmw = new BMW();
            mustang.CompletSet();
            bmw.CompletSet();

            Console.ReadKey();

        }
    }
}
