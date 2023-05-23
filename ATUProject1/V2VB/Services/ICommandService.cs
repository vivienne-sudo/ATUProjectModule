using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2VB.Services
{
    public interface ICommandService
    {
        ICommand CreateCommand(Action<object> execute, Func<object, bool> canExecute = null);
    }
}