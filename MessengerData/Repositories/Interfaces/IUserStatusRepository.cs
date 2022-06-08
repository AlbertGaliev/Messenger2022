using MessengerData.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessengerData.Repositories.Interfaces
{
    public interface IUserStatusRepository
    {
        void Create(IEntity entity);
        IEntity Read(int id);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
