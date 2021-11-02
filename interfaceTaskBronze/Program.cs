using System;

namespace interfaceTaskBronze
{

    interface ITalk
    {
        void talk();
    }
    interface IEat
    {
        int starvation { get; }
        void starvaionStatus()
        {
            System.Console.WriteLine($"starvatio status: {starvation}");
        }
    }

    interface IDrink
    {
        int thirst { get; }
        void thirstStatus()
        {
            System.Console.WriteLine($"thirst status: {thirst}");
        }
    }
    interface ISleep
    {
        int energy { get; }
        void energyStatus()
        {
            System.Console.WriteLine($"energy status: {energy}");
        }
    }
    class Program
    {

        public class Lion : ITalk, IEat, IDrink, ISleep
        {
            
            private int _energy { get; set; }
            public int energy => _energy;
            private int _thirst { get; set; }
            public int thirst => _thirst;
            private int _starvation { get; set; }
            public int starvation => _starvation;
            public Lion()
            {
                this._thirst = 100;
                this._starvation = 100;
                this._energy = 100;
            }
            public void talk()
            {
                System.Console.WriteLine("Raaaaar!!!!");
            }

        }
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.talk();
            (lion as IEat).starvaionStatus();
            (lion as IDrink).thirstStatus();
            (lion as ISleep).energyStatus();

            Console.ReadKey();
        }
    }
}
