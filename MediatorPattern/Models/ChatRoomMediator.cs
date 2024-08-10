using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Models
{
    public class ChatRoomMediator : Mediator
    {
        private readonly List<Participant> _participants = new List<Participant>();
        public override void Register(Participant participant)
        {
            if (!_participants.Contains(participant))
            {
                _participants.Add(participant);
            }
            
        }

        public override void Send(string from, string to, string message)
        {
            Participant participant = _participants.FirstOrDefault(p => p.Name == to);
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
