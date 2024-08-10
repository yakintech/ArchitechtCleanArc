using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Models
{
    public class TextEditor
    {

        private string _text;

        public void Write (string text)
        {
            _text = text;
            Console.WriteLine("Yazıldı: " + _text);
        }

        public void Erase()
        {
            _text = string.Empty;
            Console.WriteLine("Silindi: " + _text);
        }

        public void GetText()
        {
            Console.WriteLine("Text: " + _text);
        }
    }
}
