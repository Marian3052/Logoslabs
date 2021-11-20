
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
        List<ShopItem> ShopItems = new List<ShopItem>() { };
        public Shop()
        {
            this.ShopItems = new List<ShopItem>()
            {
                new ShopItem("apple",10.50),
                new ShopItem("banana",20.50),
                new ShopItem("kiwi",34.10)
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
            if(Key == ConsoleKey.Enter && selection == 4)
            {
                buyOfSum();
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
            for (int i = 1; i < this.ShopItems.Count; i++)
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

            if (selection == 3)
            {
                Console.Write(">");
            }
            System.Console.WriteLine("send item");

            if(selection == 4)
            {
                Console.Write(">");
            }
            System.Console.WriteLine("Buy of sum");

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

        void buyOfSum()
        {
            Console.Clear();
            if (selection >= 1 && selection <= 2)
            {
                System.Console.WriteLine("add the first product by index: ");
                int index = Int32.Parse(Console.ReadLine());
            }
             else if (selection >= 1 && selection <= 2)
            {
                System.Console.WriteLine("add the second product by index: ");
                int index = Int32.Parse(Console.ReadLine());
            }
           
            






        }

        void info()
        {

        }
    }

}