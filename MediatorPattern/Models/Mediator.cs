using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Models
{
    public abstract class Mediator
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }
}
