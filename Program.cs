using System;

namespace progrme
{
    class Program
    {
        

        static void Main(string[] args)
        {

           int sizeInt = sizeof(int);
            
            Console.WriteLine(" Size of int = " + sizeInt);
            
            double sizedoble = sizeof(double);
            
            Console.WriteLine("Size of double = " + sizedoble);

            float sizefloat = sizeof(float);

            Console.WriteLine("Size of float " + sizefloat);

            short sizeshort = sizeof(short);

            Console.WriteLine("Size of short = " + sizefloat);

            Console.ReadKey();



            

            

        }
    }
}
