using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Models
{
    public class CommandManager
    {
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commands.Push(command);
        }

        public void Undo()
        {
            if (_commands.Count == 0)
            {
                return;
            }

            var command = _commands.Pop();
            command.UnExecute();
        }
    }
}
