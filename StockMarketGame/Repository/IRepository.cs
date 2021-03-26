using StockMarketGame.Models;
using System.Threading.Tasks;

namespace StockMarketGame.Repository
{
    internal interface IRepository
    {
        Task<decimal> GetRate(IIndex index);
    }
}
