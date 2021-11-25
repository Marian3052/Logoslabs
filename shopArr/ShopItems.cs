using System;
using System.Collections.Generic;
namespace ShopFunctions
{
    interface IMachinery
    {
        static double weidth { get; }
        static double height { get; }
        static double wight { get; }
        string brand { get; }

    }
    interface IFood
    {
        int daysToGone { get; }

    }

    public class ShopItem
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



    }
    public class Fruit : ShopItem, IFood
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
        public Fruit(string name, double price, int daysToGone) : base(name, price)
        {
            this._daysToGone = daysToGone;
        }
    }

    class Machinery : ShopItem, IMachinery
    {
        private double _weidth { get; set; }
        public double weight => _weidth;

        private double _height { get; set; }
        public double height => _height;

        private double _wight { get; set; }
        public double wight => _wight;

        private string _brand { get; set; }
        public string brand => _brand;

        public override string info
        {
            get
            {
                return $"\t\t\t{name} '{brand}' - {price} UAH | weight: {weight} kg, height: {height} cm, wight: {wight}";
            }
        }
        public Machinery(string name, string brand, double price, double weight, double height, double wight) : base(name, price)
        {
            this._brand = brand;
            this._height = height;
            this._weidth = weight;
            this._wight = wight;

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