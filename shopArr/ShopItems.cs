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