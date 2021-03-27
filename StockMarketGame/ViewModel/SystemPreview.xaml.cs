using StockMarketGame.InterfaceView;
using StockMarketGame.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StockMarketGame.ViewModel
{
    /// <summary>
    /// Interaction logic for SystemPreview.xaml
    /// </summary>
    public partial class SystemPreview : Window
    {
        public SystemPreview()
            : this(new SystemPreviewGPW())
        {
           
        }
        internal SystemPreview(ISystemPreview view)
        {
            InitializeComponent();
            DataContext = view;
        }
    }
}
