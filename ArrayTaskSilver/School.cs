namespace ArrayTaskSilver
{
    partial class Program
    {
        public class School
        { 
            Group[] groups;
            public School(Group[] groups)
            {
                this.groups=groups;
            }
            public Student countTop()
            {
                Student Top = groups[0].countMax();
                for (int i = 0; i < groups.Length; i++)
                {
                    if (groups[i].countMax().countAVG()>Top.countAVG())
                    {
                        Top = groups[i].countMax();
                    }
                }
                return Top;

            }
            public Student countDummy()
            {
                Student Dummy = groups[0].countMin();
                for (int i = 0; i <groups.Length; i++)
                {
                    if (groups[i].countMin().countAVG()<Dummy.countAVG())
                    {
                        Dummy = groups[i].countMin();
                    }
                }
                return Dummy;

            }

           


        }
    }
}
