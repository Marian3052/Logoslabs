using System;

namespace calculator_2
{
    class Program
    {





    


    static void Main(string[] args)
    {
    int a, b;
    string operation;

    Console.WriteLine("Inset first number:  ");
     a = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Inser operation:   ");
    operation = Console.ReadLine();

    Console.WriteLine("Insert the second number:  ");
     b = Int32.Parse(Console.ReadLine());


    switch (operation) 
    {
    case "+":
     Console.WriteLine(a + b);
    break;

    case "-": Console.WriteLine(a - b);
    break;

    case "*": Console.WriteLine(a * b);
    break;

    case "/": Console.WriteLine(a / b);

    break;

    default:
    Console.WriteLine("Eror, try again");
    break;


    Console.ReadKey();
    }
}
 }

