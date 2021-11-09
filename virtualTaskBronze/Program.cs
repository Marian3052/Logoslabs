using System;

namespace virtualTaskBronze
{
   
    class Program
    {
      
     public  class Animal
        {
            public string name;
            private int _step { get; set; }
            public int step => _step = 0;

            public Animal(string name, int _step)
            {
                this._step = _step;
                this.name = name;
            }


            public virtual void getInfo()
            {
                System.Console.WriteLine($"{name} : {_step}");
            }


        }
    
        

        static void Main(string[] args)
        {



            Console.ReadKey();
        }
    }
}
