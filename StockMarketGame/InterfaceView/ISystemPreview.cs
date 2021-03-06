using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StockMarketGame.InterfaceView
{
    interface ISystemPreview
    {
        string Title { get; }
        string Header { get; }

        string AddIndexContent { get; }

        ICommand AddIndex { get; }
    }
}
