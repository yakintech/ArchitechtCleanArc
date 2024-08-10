using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Models
{
    public class User : Participant
    {
        public User(Mediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"From: {from} to {Name} : {message}");
        }

        public override void Send(string to, string message)
        {
            Console.WriteLine($"{Name} send message to {to} : {message}");
            _mediator.Send(_name, to, message);
        }
    }
}
