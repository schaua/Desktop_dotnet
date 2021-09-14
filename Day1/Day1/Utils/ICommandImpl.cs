using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Day1.Utils
{
    public class ICommandImpl : ICommand
    {
        private readonly Action _action;

        public ICommandImpl(Action action_)
        {
            _action = action_;
        }

        public void Execute(object unused)
        {
            _action();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
    }
}
