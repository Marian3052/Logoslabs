using System;
namespace ArrayTaskSilver
{
    partial class Program
    {
        public class Student
        {
            string name;
            public Student(string name, int[] point)
            {
                this.name = name;
                this.point = point;

            }

            public int countMax()
            {
                int Max = 0;
                for (int i = 0; i < point.Length; i++)
                {
                    if (this.point[i] > Max)
                    {
                        Max = this.point[i];
                    }

                }
                return Max;
            }
            public int countAVG()
            {
                int AVG = 0;
                for (int i = 0; i < point.Length; i++)
                {
                    AVG += point[i];
                }
                return AVG / point.Length;
            }
            public int countMin()
            {
                int Min = point[0];
                for (int i = 0; i > point.Length; i++)
                {
                    if (this.point[i] < Min)
                    {
                        Min = this.point[i];
                    }
                }
                return Min;

            }
            public int[] point = new int[5];

            public static Student GetRandomStudent()
            {
                string[] _name = new string[] { "John", "Marin", "Marian", "Oleg", "p1", "p2", "p3" };
                Random random = new Random();
                Student _random = new Student(_name[random.Next(0, _name.Length)], new int[] { random.Next(1, 5), random.Next(1, 5), random.Next(1, 5), random.Next(1, 5), random.Next(1, 5) });
                return _random;
            }
            public override string ToString()
            {
                return $"{name}: {String.Join(", ", point)}";
            }
        }
    }
}
