
using System;
using System.Collections.Generic;
using System.Linq;


namespace ShopFunctions
{

    class Shop
    {
        int selection;
        int index;
        string name;
        double profit;

        ConsoleKey Key;
        List<ShopItem> ShopItems = new List<ShopItem>() { };
        List<Fruit> fruits = new List<Fruit>() { };
        List<Machinery> machineries = new List<Machinery>() { };
        public Shop()
        {
            this.ShopItems = new List<ShopItem>() {
                new Machinery("Coffee machine","Samsung",10000,3.7,73.54,30.31),
                new Fruit("apple",10.50,7),
                new Fruit("banana",20.50,5),
                new Fruit("kiwi",34.10,14)

            };
        }
        public void poceed()
        {

            Console.Clear();
            

            if (Key == ConsoleKey.Enter && selection == 1)
            {
                addItem();
            }
            if (Key == ConsoleKey.Enter && selection == 2)
            {
                deleteItem();
            }


            if (Key == ConsoleKey.DownArrow)
            {
                selection++;
            }
            if (Key == ConsoleKey.UpArrow)
            {
                selection--;
            }
            if (selection <= -1)
            {
                selection = 0;
            }
            if (selection >= 5)
            {
                selection = 4;
            }
            // -------------
            for (int i = 0; i < this.ShopItems.Count; i++)
            {
                Console.WriteLine(this.ShopItems[i].info);
            }
            for (int i = 0; i < this.fruits.Count; i++)
            {
                System.Console.WriteLine(this.fruits[i].info);
            }
            for (int i = 0; i < this.machineries.Count; i++)
            {
                System.Console.WriteLine(this.machineries[i].info);
            }
            // --------------
            Console.WriteLine("\t\t\tOutstanding fruits");

            // var outstanding = from x in fruits orderby x.daysToGone.StartsWith(0) > 0 select x;
            // foreach (var f in outstanding)
            // {
            //     System.Console.WriteLine(f.info);
            // }
            

            if (selection == 0)
            {
                Console.Write(">");
            }
            Console.WriteLine("Sell item");

            if (selection == 1)
            {
                Console.Write(">");
            }
            Console.WriteLine("add item");

            if (selection == 2)
            {
                Console.Write(">");
            }
            Console.WriteLine("delete item");

            if (selection == 3)
            {
                Console.Write(">");
            }
            System.Console.WriteLine("send item");

            




            Key = Console.ReadKey().Key;
        }

        void addItem()
        {

            Console.Clear();
            System.Console.WriteLine($"Enter: name");
            string name = Console.ReadLine();

            System.Console.WriteLine($"Enter: price");
            double price = Double.Parse(Console.ReadLine());

            System.Console.WriteLine($"enter days to gone:");
            int daysToGone = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("enter brand: ");
            string brand = Console.ReadLine();

            System.Console.WriteLine("enter weight: ");
            double weight = Double.Parse(Console.ReadLine());

            System.Console.WriteLine("enter height: ");
            double height = Double.Parse(Console.ReadLine());

            System.Console.WriteLine("enter wight: ");
            double wight = Double.Parse(Console.ReadLine());

            if (daysToGone == 0)
            {
                this.ShopItems.Add(new Machinery(name, brand, price, weight, height, wight));
            }
            else if (daysToGone >= 0)
            {
                this.ShopItems.Add(new Fruit(name, price, daysToGone));
            };

        }


        void deleteItem()
        {
            Console.Clear();
            System.Console.WriteLine("delete item by index: ");
            int index = Int32.Parse(Console.ReadLine());


            this.ShopItems.RemoveAt(index);

        }
        void info()
        {

        }
    }

}