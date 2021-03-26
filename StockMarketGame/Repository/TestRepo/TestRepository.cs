using StockMarketGame.Models;
using System;
using System.Threading.Tasks;

namespace StockMarketGame.Repository.TestRepo
{
    internal class TestRepository : IRepository
    {
        public Task<decimal> GetRate(IIndex index)
        {
            return new Task<decimal>(() =>
            {
                return (decimal)(new Random().NextDouble()*100.0);
            });
        }
    }
}
