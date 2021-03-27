using StockMarketGame.Models;
using StockMarketGame.Repository.Stooq;
using StockMarketGame.WebData;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockMarketGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void InitializeRepository()
        {
            Repository.Repository.Intance.SetRepository(new StooqRepository(new WebReader()));
        }
        public MainWindow()
        {
            InitializeComponent();
            InitializeRepository();
            var i = new Models.Index("EURPLN", "Waluta EUR -> PLN");
            var a = new AddressIndex(i);
            var r = Repository.Repository.Intance;
            var t = r.GetRate(a);
            t.Start();

            var returns = t.GetAwaiter().GetResult();

        }
    }
}
