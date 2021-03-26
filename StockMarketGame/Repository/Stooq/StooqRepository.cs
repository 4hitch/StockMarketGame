using StockMarketGame.Models;
using System;
using System.Threading.Tasks;

namespace StockMarketGame.Repository.Stooq
{
    internal class StooqRepository : IRepository
    {
        public Task<decimal> GetRate(IIndex index)
        {
            return new Task<decimal>(() =>
            {
                if (Decimal.TryParse("0.0", out decimal d))
                    return d;
                return 0.0m;
            });
           
        }
    }
}
