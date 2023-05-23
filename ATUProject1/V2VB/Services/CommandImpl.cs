using System;

namespace V2VB.Services
{
    public class CommandImpl : ICommand
        {
            private readonly Command _command;

            public CommandImpl(Action execute)
            {
                _command = new Command(execute);
            }

            public bool CanExecute(object parameter)
            {
                return _command.CanExecute(parameter);
            }

            public void Execute(object parameter)
            {
                _command.Execute(parameter);
            }

            public event EventHandler CanExecuteChanged
            {
                add { _command.CanExecuteChanged += value; }
                remove { _command.CanExecuteChanged -= value; }
            }
        }
    
}