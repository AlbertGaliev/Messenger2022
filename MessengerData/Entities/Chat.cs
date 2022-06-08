using MessengerData.Entities.Interfaces;
using System.Collections.Generic;
namespace MessengerData.Entities
{
    public class Chat : BaseEntity
    {
        public string Name { get; set; }
        public int CreatorId { get; set; }
        public User Creator { get; set; }
        public ICollection<Participant> Participants { get; set; }
        public ICollection<Message> Messages { get; set; }


    }
}
