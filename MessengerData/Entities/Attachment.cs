using MessengerData.Entities.Interfaces;
namespace MessengerData.Entities
{
    public class Attachment : BaseEntity
    {
        public int MessageId { get; set; }
        public string FileUrl { get; set; }
        public Message Message { get; set; }

    }
}
