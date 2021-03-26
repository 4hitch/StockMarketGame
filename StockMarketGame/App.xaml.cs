﻿using StockMarketGame.Repository.TestRepo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StockMarketGame
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void InitializeRepository()
        {
            Repository.Repository.Intance.SetRepository(new TestRepository());
        }
    }
}
