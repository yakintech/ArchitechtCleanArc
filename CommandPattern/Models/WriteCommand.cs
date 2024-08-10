using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Models
{
    public class WriteCommand : ICommand
    {

        private readonly TextEditor _textEditor;
        private string _text;

        public WriteCommand(TextEditor textEditor, string text)
        {
            _textEditor = textEditor;
            _text = text;
        }


        public void Execute()
        {
            _textEditor.Write(_text);
        }

        public void UnExecute()
        {
           _textEditor.Erase();
        }
    }
}
