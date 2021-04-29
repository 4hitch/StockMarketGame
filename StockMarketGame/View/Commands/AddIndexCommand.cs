using StockMarketGame.InterfaceView;
using StockMarketGame.ViewModel;
using System;
using System.Windows.Input;

namespace StockMarketGame.View.Commands
{
    internal class AddIndexCommand : ICommand
    {

        private bool CurrentlyRun = false;
        private readonly IAddIndex View;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => !CurrentlyRun;

        public AddIndexCommand(IAddIndex view) => View = view;

        public void Execute(object parameter)
        {
            CurrentlyRun = true;
            AddIndex wAdd = new(View);
            wAdd.ShowDialog();
            CurrentlyRun = false;
        }
    }
}
