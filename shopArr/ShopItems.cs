using System;
using System.Collections.Generic;
namespace ShopFunctions
{
    interface IMachinery
    {
        static double width { get; }
        static double height { get; }

    }
    interface IFood
    {
        int daysToGone { get; }

    }

    class ShopItem
    {




        public string name;
        public double price;

        public ShopItem(string name, double price)
        {
            this.name = name;
            this.price = price;
        }



        public virtual string info
        {
            get
            {
                return $"\t\t\t{name} - {price} UAH";
            }
        }

        class Fruit : ShopItem, IFood
        {
            private int _daysToGone { get; set; }
            public int daysToGone => _daysToGone;
            public override string info
            {
                get
                {
                    return $"\t\t\t{name} - {price} UAH | gone in {daysToGone} days";
                }
            }
            public Fruit(string name, double price) : base(name, price)
            {
                this._daysToGone = daysToGone;
            }
        }

        class PC : ShopItem, IMachinery
        {
            private double _width { get; set; }
            public double wight => _width;

            private double _height { get; set; }
            public double height => _height;

            public override string info
            {
                get
                {
                    return $"\t\t\t{name} - {price} UAH | wight: {wight} cm, height: {height} cm";
                }
            }
            public PC(string name, double price) : base(name, price)
            {
                this._height = height;
                this._width = wight;
            }

        }

        class ShopItemGroup<T> where T : ShopItem
        {
            List<T> ShopItems = new List<T>();
            public void getShopItemsInfo()
            {
                //  не  впевнени (перевірити)!!
                foreach (var item in ShopItems)
                {
                    string info = item.info;
                }
            }
            public double sumShopItemPrice()
            {
                double sum = 0;
                for(var i = 0; i  < ShopItems.Count; i++)
                {
                    sum += ShopItems[i].price;
                }
                return sum;
            }
            public void pushShopItem(T ShopItem)
            {
                ShopItems.Add(ShopItem);
            }

        }




        public double clearProfit
        {
            get
            {
                return price * 0.8;
            }
        }


    }

}