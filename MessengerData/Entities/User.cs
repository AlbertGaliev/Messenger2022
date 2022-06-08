using MessengerData.Entities.Interfaces;
using System.Collections.Generic;
namespace MessengerData.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Chat> Chats { get; set; }
        public ICollection<Participant> Participants { get; set; }
    }
}
