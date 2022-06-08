using MessengerData.EF;
using MessengerData.Entities;
using System.Linq;
using MessengerData.Repositories.Interfaces;
using MessengerData.Entities.Interfaces;

namespace MessengerData.Repositories
{
    class ChatRepository : IChatRepository
    {
        MessengerDbContext dbContext;
        public ChatRepository(MessengerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(IEntity chat)
        {
            var _chat = chat as Chat;
            var result = from temp in dbContext.Chats
                         where temp.Name == _chat.Name && temp.Creator == _chat.Creator
                         select temp;
            if (result.Count() == 0)
            {
                dbContext.Chats.Add(_chat);
            }
        }
        public IEntity Read(int id)
        {
            var chat = dbContext.Chats.Find(id);
            return chat;
        }
        public void Update(IEntity chat)
        {
            var _chat = dbContext.Chats.Find(chat.Id);
            if (_chat != null)
            {
                dbContext.Chats.Add(chat as Chat);
            }
        }
        public void Delete(int id)
        {
            var chat = dbContext.Chats.Find(id);
            if (chat != null)
            {
                dbContext.Chats.Remove(chat);
            }
        }

    }
}
