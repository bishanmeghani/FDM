using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OnlineTrainingWPF
{
    public class Command : ICommand
    {//this is a generic command class, can be used for any button in our application
        private readonly Action _execute; //delegate here storing a method for us as an action, when any button clicked
        private readonly Func<bool> _canExecute; //a func here storing a bool, to see if button can be clicked
        public event EventHandler CanExecuteChanged; //canexecutechanged is to give a nudge to see if anythings changed in application

        public Command(Action execute, Func<bool> canExecute = null) //give it the execute and canexecute we want it to run. if canexecute not given, then it will be allowed to execute
        {
            if (execute == null)
            {
                throw new ArgumentException("execute was null");
            }

            _execute = execute;
            _canExecute = canExecute ?? (() => true);
        }

        public void Execute(object parameter) //checking canexecute again
        {
            if (!CanExecute(parameter))
            {
                return;
            }

            try { _execute(); }
            catch { Debugger.Break(); }
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter) //checking canexecutemethod and returnign true or false
        {
            try { return _canExecute(); }
            catch { return false; }
        }

        public void OnCanExecuteChanged() //invoking the canexecutechanged
        {
            CanExecuteChanged.Invoke(this, EventArgs.Empty);
        }
    }
}

