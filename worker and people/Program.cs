 using System;

namespace worker_and_people
{
   public class People
   {
       public string name;
       public void status()
       {
        Console.WriteLIne(name + "status:" + this.status);
       }

   }  
   public class Wroker : People         
    {
     protected void status();
     protected void position();
     protected void function();
    
    }
  

    class Program
    {
        static void Main(string[] args)
        {
            Worker vova = new Worker();
            vova.name = "Vova";

            Guest roma = new Guest();
            rome.name = "Roman";
           Console.ReadKey();
        }
    }
}
