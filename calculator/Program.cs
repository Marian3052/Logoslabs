using System;

namespace calculator_2
{
    class Program
    {

        interface IDrink
        {
            void drinll();

            
        }
        interface IEat
        {
            void eat();

        }
       public interface ITalk
        {
            void talk();
        }
       public interface ISleep
        {
              void sleep();
        }

        public class Lion : ITalk
        {

        }
        static void Main(string[] args)
        {
            //     int z, y;
            //     string opperator;

            //     Console.WriteLine("Insert first number:");
            //     z = Int32.Parse(Console.ReadLine());


            //     Console.WriteLine("Insert opperator ");
            //     opperator = Console.ReadLine();


            //     Console.WriteLine("Insert second number");
            //     y = Int32.Parse(Console.ReadLine());


            //     switch (opperator)
            //     {
            //         case "*":
            //             Console.WriteLine(z * y);
            //             break;
            //         case "/":
            //             Console.WriteLine(z / y);
            //             break;
            //         case "+":
            //             Console.WriteLine(z + y);
            //             break;
            //         case "-":
            //             Console.WriteLine(z - y);
            //             break;

            //         default:

            //         Console.WriteLine("error");

            //         break;



            //     }






            Console.ReadKey();



        }


    }

}

