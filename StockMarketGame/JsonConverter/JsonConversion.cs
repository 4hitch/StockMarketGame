using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.JsonConverter
{
    public static class JsonConversion
    {
        public static JObject GetJObject(string data, string prefix = "", string suffix = "") => JObject.Parse(prefix + data + suffix);


        public static JArray GetJArray(JObject jObject, string node) => JArray.Parse(jObject[node].ToString());
        

        public static JArray GetJArray(JObject jObject, string node, string innerNode) => JArray.Parse(jObject[node][innerNode].ToString());
        
    }
}
