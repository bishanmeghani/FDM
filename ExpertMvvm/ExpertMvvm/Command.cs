using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExpertMvvm
{
    public class Command : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        public event EventHandler CanExecuteChanged;

        public Command(Action execute, Func<bool> canExecute = null)
        {
            if (execute == null)
            {
                throw new ArgumentException("execute was null");
            }

            _execute = execute;
            _canExecute = canExecute ?? (() => true);
        }

        public void Execute(object parameter)
        {
            if (!CanExecute(parameter))
            {
                return;
            }

            try { _execute(); }
            catch { Debugger.Break(); }
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            try { return _canExecute(); }
            catch { return false; }
        }

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged.Invoke(this, EventArgs.Empty);
        }
    }
}
