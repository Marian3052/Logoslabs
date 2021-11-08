using System;

namespace InterfaceTaskSilver
{
    enum Food { nothing, vegan, meat, omnivorous }

    class Program
    {
        interface Ihealth
        {
            int health { get; }
            void healthStatus()
            {
                System.Console.WriteLine($"health  status: {health}");
            }
        }
        interface Ieat
        {
            void eat(Food food);
        }
        class MeatEater : Ihealth, Ieat
        {
            private int _health { get; set; }
            public int health => _health;
            public MeatEater()
            {
                this._health = 100;
            }
            public void eat(Food food)
            {
                if (food == Food.meat) this._health += 25;
                else if (food == Food.nothing || food == Food.vegan) this._health -= 15;
            }

        }
        class VeganEater : Ihealth, Ieat
        {
            private int _health { get; set; }
            public int health => _health;
            public VeganEater()
            {
                this._health = 100;
            }
            public void eat(Food food)
            {
                if (food == Food.vegan) this._health += 25;
                else if (food == Food.meat || food == Food.nothing) this._health -= 15;

            }
        }

        class OmnivorousEater : Ihealth, Ieat
        {
            private int _health { get; set; }
            public int health => _health;
            public OmnivorousEater()
            {
                this._health = 100;
            }
            public void eat(Food food)
            {
            if(food == Food.omnivorous) this._health += 25;
            else if (food == Food.nothing) this._health -= 15;
            }
        }


        class Fox : MeatEater { }
        class Donkey : VeganEater { }
        class Bear : OmnivorousEater { }
        static void Main(string[] args)
        {

            Fox fox = new Fox();
            fox.eat(Food.vegan);

            Donkey donkey = new Donkey();
            donkey.eat(Food.meat);

            Bear bear = new Bear();
            bear.eat(Food.nothing);


            Console.Write("Health Status Fox: ");
            ((Ihealth)fox).healthStatus();

            Console.Write("Health status Donkey: ");
            ((Ihealth)donkey).healthStatus();

            Console.Write("Health status Bear: ");
            ((Ihealth)bear).healthStatus();

            Console.ReadKey();
        }
    }
}
