namespace ArrayTaskSilver
{
    partial class Program
    {
        public class Group
        {
            Student[] students;
            public Group(Student[] students)
            {
                this.students = students;
            }
            public Student countMin()
            {
                Student Min = students[0];
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].countAVG() > Min.countAVG())
                    {
                        Min = students[i];
                    }

                }
                return Min;
            }
            public int countAVG()
            {
                int AVG = 0;
                for (int i = 0; i < students.Length; i++)
                {
                if (students[i].countAVG()>AVG)
                {
                    AVG +=students[i].countAVG();
                }
                }
                return AVG;

            }
            public Student countMax()
            {
                Student Max = students[0];
                for (int i = 0; i > students.Length; i++)
                {
                    if (students[i].countAVG() > Max.countAVG())
                    {
                        Max = students[i];
                    }
                }
                return Max;
               
            }


        }
    }
}
