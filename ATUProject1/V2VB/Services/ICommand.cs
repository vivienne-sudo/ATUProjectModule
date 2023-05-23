using System;
using System.Windows.Input;
using V2VB.ViewModel;

namespace V2VB.Services
{
    public interface ICommand 
    {
        void Execute(object parameter);
        bool CanExecute(object parameter);
        event EventHandler CanExecuteChanged;
    }

}
