using StockMarketGame.InterfaceView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame.View
{
    internal class AddIndexGPW : IAddIndex
    {

        public string Title { get;  }

        public string Header { get;  }

        public string IndexName { get;  }

        public string IndexNameValue { get;  set; }

        public AddIndexGPW()
        {
            Title = "Add new index";
            Header = "Insert information about new index GPW";
            IndexName = "Index name:";
            IndexNameValue = "PLNEUR";
        }
    }
}
