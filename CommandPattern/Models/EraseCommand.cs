using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Models
{
    public class EraseCommand : ICommand
    {
        private readonly TextEditor _textEditor;

        public EraseCommand(TextEditor textEditor)
        {
            _textEditor = textEditor;
        }

        public void Execute()
        {
            _textEditor.Erase();
        }

        public void UnExecute()
        {
        //
        }
    }
}
