using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.Models
{
    internal class AddressIndex : AAdress
    {
        private readonly IIndex Index;
        public AddressIndex(IIndex index) : base(index.GetName()) => Index = index;

        public IIndex GetIndex() => Index;
        
    }
}
