using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    public class MP4Player
    {
        public void PlayMP4(string fileName)
        {
            Console.WriteLine("Playing MP4 file. Name: " + fileName);
        }
    }
}
