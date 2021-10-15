
using System;
using System.Collections.Generic;

namespace ShopFunctions
{
    class Shop
    {
        int selection;
        string name;
        double profit;

        ConsoleKey Key;
        List<ShopItem> ShopItems;
        public Shop()
        {
            this.ShopItems = new List<ShopItem>()
            {
                new ShopItem("apple",10.50)
            };
        }           
        void sell(ShopItem si)
        {
            this.profit += si.clearProfit;
            Console.WriteLine($"{si.name} sold");
        }
        void add(ShopItem si)
        {
            this.ShopItems.Add(si);
        }
        void delete(ShopItem si)
        {
            this.ShopItems.Remove(si);
        }
        public void poceed()
        {

            Console.Clear();

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
            if (selection >= 3)
            {
                selection = 2;
            }
            for (int i = 0; i < this.ShopItems.Count; i++)
            {
                Console.WriteLine(this.ShopItems[i].info);
            }
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
            // if (selection <= -1)
            // {
            //     return;
            // }

            // if (selection >= 3)
            // {
            //     return;
            // }
            Key = Console.ReadKey().Key;
        }
        void info()
        {

        }
    }

}