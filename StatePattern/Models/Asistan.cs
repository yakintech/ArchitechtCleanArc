using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Models
{
    public class Asistan
    {
        IMode _mode;

        public Asistan()
        {
            _mode = new OnlineMode();
        }


        public void Answer()
        {
            _mode.Answer();
        }

        public void ChangeMode(IMode mode)
        {
            _mode = mode;
        }
    }
}
