using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace task02
{
    public class delegatecommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        private Action<object> _execute;
        private Predicate<object> _canexecute;
        public delegatecommand(Action<object> a, Predicate<object> p)
        {
            this._execute = a;
            this._canexecute = p;
        }
        public bool CanExecute(object parameter)
        {
            return this._canexecute(parameter);
        }

        public void Execute(object parameter)
        {
           this._execute(parameter);
        }
    }
}
