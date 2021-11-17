using System;
using ShopFunctions;
namespace shopArr
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopItemGroup<ShopItem> group = new ShopItemGroup<ShopItem>();
            Shop shop1 = new Shop();

            while (true)
            {
                 shop1.poceed();
            }
        }
    }
}
