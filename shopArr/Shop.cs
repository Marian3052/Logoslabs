
using System;
using System.Collections.Generic;

namespace ShopFunctions
{
    class Shop
    {
        int selection;  
        int index;
        string name;
        double profit;

        ConsoleKey Key;
        List<ShopItem> ShopItems = new List<ShopItem>() {};
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
        // void add(ShopItem si)
        // {
        //     this.ShopItems.Add(si);
        // }
        // void delete(ShopItem si)
        // {
        //     this.ShopItems.Remove(si);
        // }
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

            Key = Console.ReadKey().Key;
        }

        void addItem()
        {
            // Викликаємоо name
            Console.Clear();
            System.Console.WriteLine($"Enter: name");
            string name = Console.ReadLine();
            //Викликаємо price
            System.Console.WriteLine($"Enter: price");
            double price = Double.Parse(Console.ReadLine());

            //Викликаємо метод який добавляє ShopItem
            this.ShopItems.Add(new ShopItem(name, price));
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