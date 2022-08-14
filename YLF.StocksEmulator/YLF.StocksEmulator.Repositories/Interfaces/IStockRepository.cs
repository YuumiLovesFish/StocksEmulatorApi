using System;
using System.Collections.Generic;
using System.Text;

namespace YLF.StocksEmulator.Repositories.Interfaces
{
    public interface IStockRepository
    {
        public Stock GetStockByName(string stockName);
        public IEnumerable<Stock> GetAllStocks();


    }
}
