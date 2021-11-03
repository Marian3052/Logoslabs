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

            public string food;
            public string _sleep;
            public string _water;
            private int _energy { get; set; }
            public int energy => _energy;
            private int _thirst { get; set; }
            public int thirst => _thirst;
            private int _starvation { get; set; }
            public int starvation => _starvation;
            public void talk()
            {
                System.Console.WriteLine("Raaaaar!!!!");
            }
            public Lion()
            {
                this._thirst = 100;
                this._starvation = 100;
                this._energy = 100;
            }

            public void processFood()
            {
                if (this.food == "apple") this._starvation += 10;
                else if (this.food != "apple") this._starvation -= 10;
            }
            public void eat(string food)
            {
                this.food = food;
                this.processFood();
                if (this._starvation <= 0) System.Console.WriteLine("You Died!!");
            }
            public void processSleep()
            {
                if (this._sleep == "sleep") this._energy += 12;
                else if (this._sleep != "sleep") this._energy -= 5;
            }

            public void sleep(string _sleep)
            {
                this._sleep = _sleep;
                this.processSleep();

            }
            public void processDrink()
            {
                if (this._water == "coca-cola") this._thirst += 10;
                else if (this._water != "coca-cola") this._thirst -= 10;
            }
            public void drink(string _water)
            {
                this._water = _water;
                this.processDrink();
            }
        }
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Console.Write("Lion sey: ");
            lion.talk();
            lion.eat("");
            lion.drink("");
            lion.sleep("sleep");

            (lion as IEat).starvaionStatus();
            (lion as IDrink).thirstStatus();
            (lion as ISleep).energyStatus();

            Console.ReadKey();
        }
    }
}
