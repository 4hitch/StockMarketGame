using StockMarketGame.InterfaceView;
using StockMarketGame.View.Commands;
using StockMarketGame.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            AddIndexContent = "Add Index";
            SetCommands();
        }

        private void SetCommands()
        {
            AddIndex = new AddIndexCommand(new AddIndexGPW());
        }

       
        public string Title { get; }

        public string Header { get; }

        public string AddIndexContent { get; }

        public ICommand AddIndex { get; private set; }

        

        
    }
}
