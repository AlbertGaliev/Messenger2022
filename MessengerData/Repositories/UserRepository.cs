using MessengerData.EF;
using MessengerData.Entities;
using MessengerData.Entities.Interfaces;
using MessengerData.Repositories.Interfaces;
using System.Linq;

namespace MessengerData.Repositories
{
    public class UserRepository : IUserRepository
    {
        MessengerDbContext dbContext;
        public UserRepository()
        {
            dbContext = new MessengerDbContext();
        }
        public UserRepository(MessengerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(IEntity user)
        {
            dbContext.Users.Add(user as User);
        }
        public IEntity Read(int id)
        {
            var user = dbContext.Users.Find(id);
            return user;
        }
        public void Update(IEntity user)
        {
            var _user = user as User;
            var result = from temp in dbContext.Users
                       where temp.Login == _user.Login
                       select temp;
            if (result != null)
            {
                dbContext.Users.Update(_user);
            }
        }
        public void Delete(int id)
        {
            var user = dbContext.Users.Find(id);
            if (user != null)
            {
                dbContext.Users.Remove(user);
            }
        }
    }
}
