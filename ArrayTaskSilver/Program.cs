using System;

namespace ArrayTaskSilver
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var g1 = new Group(new Student[] { Student.GetRandomStudent(), Student.GetRandomStudent(), Student.GetRandomStudent() });
            var g2 = new Group(new Student[] { Student.GetRandomStudent(), Student.GetRandomStudent(), Student.GetRandomStudent() });
            var g3 = new Group(new Student[] { Student.GetRandomStudent(), Student.GetRandomStudent(), Student.GetRandomStudent() });
            var School = new School(new Group[] { g1, g2, g3 });
            System.Console.WriteLine(School.countDummy());
            System.Console.WriteLine(School.countTop());






            Console.ReadKey();
        }
    }
}
