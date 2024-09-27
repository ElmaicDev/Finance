using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrimerAPP_WPF.ViewModel
{
    public class CommandHandler: ICommand
    {

        private readonly Action _execute;
        

        public event EventHandler CanExecuteChanged;

        public CommandHandler(Action execute)
        {
            _execute = execute;
            
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public void OnCanExecuteChanged(object parameter)
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
