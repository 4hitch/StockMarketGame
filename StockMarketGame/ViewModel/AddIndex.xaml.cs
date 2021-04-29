using StockMarketGame.InterfaceView;
using StockMarketGame.View;
using System.Windows;


namespace StockMarketGame.ViewModel
{
    public partial class AddIndex : Window
    { 

        public AddIndex()
            : this(new AddIndexGPW())
        {

        }
        internal AddIndex(IAddIndex view)
        {
            InitializeComponent();
            DataContext = view;
        }
    }
}
