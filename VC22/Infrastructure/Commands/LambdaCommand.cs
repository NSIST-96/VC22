using System;
using VC22.Infrastructure.Commands.Base;

namespace VC22.Infrastructure.Commands
{
    internal class LambdaCommand : Command
    {
        //Поля readonly немного ускоряют работу приложения
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;
        public LambdaCommand( Action<object> Execute, Func<object, bool> CanExecute = null) 
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Exception)); // делегат
            _CanExecute = CanExecute; // делегат
        }

        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _Execute(parameter);
    }
}
