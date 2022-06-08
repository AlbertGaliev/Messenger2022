using MessengerData.Entities.Enums;
using MessengerData.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MessengerData.Entities
{
    public class UserStatus : BaseEntity
    {
        [ForeignKey("UserId")]
        public override int Id { get; set; }
        public UserOnlineStatus Status { get; set; }
        public User User { get; set; }

    }
}
