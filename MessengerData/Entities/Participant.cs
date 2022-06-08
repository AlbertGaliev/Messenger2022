using MessengerData.Entities.Interfaces;
using System;
namespace MessengerData.Entities
{
    public class Participant : BaseEntity
    {
        public int ChatId { get; set; }
        public int UserId { get; set; }
        public Chat Chat { get; set; }
        public User User { get; set; }
    }
}
