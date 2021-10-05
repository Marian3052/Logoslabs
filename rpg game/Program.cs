using System;

namespace rpg_game
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello");
             Console.WriteLine("-----------------");
            Console.WriteLine("1 - hi!");
            Console.WriteLine("2 - bye");
            Console.WriteLine("-------------------");
            
            int c = Int32.Parse(Console.ReadLine());
           

           if(c != 1) {
                return;


           }
           
            Console.WriteLine("When in Counter-Strike Global Offensive?");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1 - 14:00");
            Console.WriteLine("2 - No, sorry, I dont have time!");
            Console.WriteLine("-----------------------------");
             int a = Int32.Parse(Console.ReadLine());

             if(a != 1){
                 return;
             }

             Console.WriteLine("OK, see you at 14:00");
            /* Console.WriteLine("--------------");
             Console.WriteLine("Bye");
             
             int q = Int32.Parse(Console.ReadLine());


             if(q == 1){
                 return;
             }*/


            

           

           
            
            Console.ReadKey();
        }
    }
}
