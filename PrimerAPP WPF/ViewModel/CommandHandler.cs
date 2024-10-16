using System;
using System.CodeDom.Compiler;
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
        private readonly Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public CommandHandler(Action execute)
        {
            _execute = execute;
            
        }

        public CommandHandler(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
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
