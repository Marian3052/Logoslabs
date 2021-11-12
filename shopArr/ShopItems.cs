namespace ShopFunctions
{
    class ShopItem
    {
        public string name;
        public double price;

        public ShopItem(string name, double price)
        {
            this.name = name;
            this.price = price;

            
        }
        // foreach (int i in ShopItems)
        // {
        //     System.Console.WriteLine(i);
        // }


        public string       info
        {
            get
            {
                return $"\t{name} - {price} UAH";
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