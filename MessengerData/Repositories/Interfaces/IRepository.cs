using MessengerData.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessengerData.Repositories.Interfaces
{
    interface IRepository<T> where T : IEntity
    {
        void Create(T item);
        T Read(int id);
        void Update(T item);
        void Delete(int id);

    }
}
