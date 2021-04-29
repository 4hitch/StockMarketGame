using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.InterfaceView
{
    interface IAddIndex
    {
        string Title { get; }
        string Header { get; }

        string IndexName { get; }

        string IndexNameValue { get; set; }
    }
}
