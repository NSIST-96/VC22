using System;
using System.Windows.Input;

namespace VC22.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value; 
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parameter); //{ throw new NotImplementedException(); }

        /// <summary> Логика команды </summary>
        /// <param name="parameter"></param>
        /// <exception cref="NotImplementedException"></exception>
        public abstract void Execute(object parameter); //{ throw new NotImplementedException(); }
    }
}
