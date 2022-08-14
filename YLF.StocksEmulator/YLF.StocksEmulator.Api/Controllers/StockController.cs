using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YLF.StocksEmulator.Repositories.Interfaces;

namespace YLF.StocksEmulator.Api.Controllers
{
    [Route("stocks")]
    public class StockController : Controller
    {
        private IStockRepository _stockRepo;

        public StockController(IStockRepository stockRepository)
        {
            _stockRepo = stockRepository;
        }
        [Route("{stockCode}") ]
        [HttpGet]
        public IActionResult Get(string stockCode)
        {
           var stock = _stockRepo.GetStockByName(stockCode);
            if (stock == null)
                return NotFound();

            return Ok(stock);
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            var stocks = _stockRepo.GetAllStocks();
            return Ok(stocks);
        }
    }
}
