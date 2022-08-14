using System;
using System.Collections.Generic;
using System.Text;
using YLF.StocksEmulator.Repositories.Interfaces;

namespace YLF.StocksEmulator.Repositories
{
    public class StockRepository : IStockRepository
    {
       private List<Stock> Stocks = new List<Stock>
        {
             new Stock("TSLA", 100.00m,0),
             new Stock("AAPL", 100.00m,0),
             new Stock("BABA", 100.00m,0),
             new Stock("NFLX", 100.00m,0),
             new Stock("META", 100.00m,0)
        };

        private void RecalculateStock(Stock stock)
        {
          
            Random random = new Random();
            var lowerBound = -1000;
            var upperBound = 1000;
            decimal percentage = random.Next(lowerBound, upperBound) / 100m;
            stock.Price = stock.Price + (percentage * stock.Price) / 100m;
            stock.PriceChanges = percentage;
        }

        public Stock GetStockByName(string stockName)
        {
            var stock = Stocks.Find(s => s.Name.ToLower() == stockName.ToLower());

            if (stock != null)
            {
                RecalculateStock(stock);
            }
                
           
            return stock;
        }
        public IEnumerable<Stock> GetAllStocks()
        {
            foreach (var stock in Stocks)
            {
                RecalculateStock(stock);
            };
            return Stocks;
        }
    }
}
