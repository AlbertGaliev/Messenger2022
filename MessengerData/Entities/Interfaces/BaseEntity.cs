using System;
namespace MessengerData.Entities.Interfaces
{
    public class BaseEntity : IEntity
    {
        public virtual int Id { get; set; }
        public DateTime CreationTime{ get; set; }
    }
}
