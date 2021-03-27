using System.Threading.Tasks;

namespace StockMarketGame.WebData
{
    interface IWebReader
    {
        Task<string> GetHttpData(string url);
    }
}
