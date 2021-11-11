using System;

namespace virtualTaskBronze
{

    class Program
    {

        public class Puma
        {
            public string name;
            private int _step { get; set; }
            public int step => _step  = 4;


            public Puma(string name = "Puma", int _step = 4) 
            {
                this._step = step;
                this.name = name;
            }

            

            public virtual void getInfo()
            {
                System.Console.WriteLine($"{name} : {step} meter");
            }


        }
        class LittlePuma : Puma
        {
            public int independent { get; set; }

            public LittlePuma(string name = "little Puma", int _step = 4, int independent = 5) : base(name, _step)
            {
                this.name = name;
                
                this.independent = independent;

            }

            public void getIndependent()
            {
                independent = 5;
            }
            public override void getInfo()
            {
                System.Console.WriteLine($"{name} :{step / 4} meter | time for independence {independent} days");
            }



        }


        static void Main(string[] args)
        {

            Puma puma = new Puma();
            puma.getInfo();

            LittlePuma littlePuma = new LittlePuma();
            littlePuma.getInfo();

            Console.ReadKey();
        }
    }
}
