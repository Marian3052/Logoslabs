using System;

namespace ArrayTaskBronze
{


    class Program
    {
        class Class
        {
            Student[] students;
            public Class(Student[] students)
            {
                this.students = students;
            }
            public int getMax(int pointIndex)
            {
                int max = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].point[pointIndex] > max)
                    {
                        max = students[i].point[pointIndex];
                    }
                }
                return max;
            }

        }

        class Student
        {

            public string name;


            public Student(string name, int[] point)
            {
                this.name = name;
                this.point = point;
            }
            public int[] point = new int[3];

        }

        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
            new Student($"Oleg ",new int[3]{4,3,2}),
            new Student($"marina ",new int[3]{4,5,1}),
            new Student($"jhon ",new int[3]{1,2,3})
            }; 
            Class c1 = new Class(students);
            int p1Max = c1.getMax(0);
            int  p2Max = c1.getMax(1);
            int p3Max = c1.getMax(2);
            Console.WriteLine($"p1: {p1Max} ");
            Console.WriteLine($"p2: {p2Max} ");
            Console.WriteLine($"p3: {p3Max} ");
            Console.ReadKey();
        }
    }
}
