using MessengerData.EF;
using MessengerData.Entities;
using MessengerData.Entities.Interfaces;
using MessengerData.Repositories.Interfaces;

namespace MessengerData.Repositories
{
    public class UserStatusRepository : IUserStatusRepository
    {
        MessengerDbContext dbContext;
        public UserStatusRepository(MessengerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(IEntity entity)
        {
            dbContext.UserStatuses.Add(entity as UserStatus);
        }

        public void Delete(IEntity entity)
        {
            dbContext.UserStatuses.Remove(entity as UserStatus);
        }

        public IEntity Read(int id)
        {
            var result = dbContext.UserStatuses.Find(id);
            return result;
        }

        public void Update(IEntity entity)
        {
            var result = dbContext.UserStatuses.Find(entity.Id);
            if (result != null)
            {
                dbContext.UserStatuses.Update(entity as UserStatus);
            }
        }
    }
}
