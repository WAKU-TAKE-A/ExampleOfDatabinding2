using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// user add
using System.Windows.Input;

namespace MyUtil
{
    /// <summary>
    /// A class that implements ICommand. 
    /// <para>https://inter.work/csharp_delegate_command/</para>
    /// </summary>
    public class DelegateCommand : ICommand
    {
        private readonly Action _execute;

        /// <summary>
        /// When command verification is done.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="execute">Command</param>
        public DelegateCommand(Action execute)
        {
            _execute = execute;
        }

        /// <summary>
        /// Forcibly generate CanExecuteChanged.
        /// </summary>
        public static void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        /// <summary>
        /// Whether the command can be executed.
        /// </summary>
        /// <param name="parameter">CommandParameter</param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (_execute == null) { return; }
            _execute();
        }
    }
}
