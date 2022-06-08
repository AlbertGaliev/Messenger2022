using MessengerData.EF;
using MessengerData.Entities;
using MessengerData.Entities.Interfaces;
using MessengerData.Repositories.Interfaces;

namespace MessengerData.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        MessengerDbContext dbContext;
        public MessageRepository(MessengerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(IEntity message)
        {
            dbContext.Messages.Add(message as Message);
        }

        public void Delete(int id)
        {
            var message = dbContext.Messages.Find(id);
            if (message != null)
            {
                dbContext.Messages.Remove(message);
            }
        }

        public IEntity Read(int id)
        {
            var message = dbContext.Messages.Find(id);
            return message;
        }

        public void Update(IEntity message)
        {
            var result = dbContext.Messages.Find(message.Id);
            if (result != null)
            {
                dbContext.Messages.Update(message as Message);
            }
        }
    }
}
