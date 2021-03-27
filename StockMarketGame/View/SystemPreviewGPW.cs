using StockMarketGame.InterfaceView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StockMarketGame.View
{
    internal class SystemPreviewGPW : ISystemPreview
    {
        public SystemPreviewGPW()
        {
            Title = "Stock Market Game - GPW";
            Header = "Currently active indexes:";
            SetCommands();
        }

        private void SetCommands()
        {
            AddIndex = //TODO
        }
        public string Title { get; private set; }

        public string Header { get; private set; }

        public ICommand AddIndex { get; private set; }

        
    }
}
