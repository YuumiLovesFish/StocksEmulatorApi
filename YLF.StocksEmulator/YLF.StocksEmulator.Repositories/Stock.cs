using System;
using System.Collections.Generic;
using System.Text;

namespace YLF.StocksEmulator.Repositories
{
    public class Stock
    {

        public Stock(string name, decimal price, decimal priceChanges)
        {
            Name = name;
            Price = price;
            PriceChanges = priceChanges;
        }

        public string  Name { get; internal set; }
        public decimal Price { get; internal set; }
        public decimal PriceChanges { get; internal set; }
    }
}
