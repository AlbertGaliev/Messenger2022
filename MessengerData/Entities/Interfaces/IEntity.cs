using System;
using System.Collections.Generic;
using System.Text;

namespace MessengerData.Entities.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreationTime { get; set; }
    }
}
