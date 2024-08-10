using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Models
{
    public abstract class Participant
    {
        protected Mediator _mediator;
        protected string _name;


        public Participant(Mediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public string Name => _name;

        public abstract void Send(string to, string message);
        public abstract void Receive(string from, string message);
    }
}
