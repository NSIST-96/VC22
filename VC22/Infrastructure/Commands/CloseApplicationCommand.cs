using System.Windows;
using VC22.Infrastructure.Commands.Base;

namespace VC22.Infrastructure.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
            
        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
