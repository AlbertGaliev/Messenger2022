using MessengerData.Entities.Interfaces;
using System.Collections.Generic;
namespace MessengerData.Entities
{
    public class Message : BaseEntity
    {
        public int ChatId { get; set; }
        public int SenderId { get; set; }
        public MessageType MessageType { get; set; }
        public string MessageText { get; set; }
        public Chat Chat { get; set; }
        public User Sender { get; set; }
        public ICollection<Attachment> Attachments { get; set; }


    }
}
