using StockMarketGame.JsonConverter;
using StockMarketGame.Models;
using StockMarketGame.WebData;
using System;
using System.Threading.Tasks;

namespace StockMarketGame.Repository.Stooq
{
    internal class StooqRepository : IRepository
    {
        private const string DataAdress = "https://stooq.pl/q/l/?e=json&s=";
        private const string ArrayInData = "symbols";
        private const string RateName = "close";

        private IWebReader Reader;
        public StooqRepository(IWebReader reader)
        {
            Reader = reader;
        }
        public Task<decimal> GetRate(IAddress address)
        {
            if (Reader == null)
                return new Task<decimal>(() => { return 0.0m; }) ;
            var ss = DataAdress + address.GetAddress();
            var r = Reader.GetHttpData(DataAdress + address.GetAddress());
            r.Start();
            var json = r.GetAwaiter().GetResult();
            return new Task<decimal>(() => 
            { 
                var data = GetRate(json);
                if (Decimal.TryParse(data, out decimal outDecimal))
                    return outDecimal;
                return 0.0m;

            }) ;
           
        }

        private string GetRate(string jsonData)
        {
            try
            {
                var json = JsonConversion.GetJObject(jsonData);
                var jsonArray = JsonConversion.GetJArray(json, ArrayInData);
                if (jsonArray.Count < 1)
                    return "0.0";
                var jToken = jsonArray[0];
                return jToken[RateName].ToString();
            }
            catch(Exception)
            {
                return "0.0";
            }
        }
    }
}
