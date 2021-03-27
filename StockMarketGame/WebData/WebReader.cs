using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.WebData
{
    internal class WebReader : IWebReader
    {
        private readonly WebClient Client;

        public WebReader()
        {
            Client = new WebClient();
        }

        public Task<string> GetHttpData(string url)
        {
            return new Task<string>(() => { return Client.DownloadString(url); });
        }
    }
}
