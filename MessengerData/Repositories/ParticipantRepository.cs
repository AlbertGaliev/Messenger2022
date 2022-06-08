using MessengerData.Entities;
using System.Linq;
using MessengerData.EF;
using MessengerData.Repositories.Interfaces;
using MessengerData.Entities.Interfaces;

namespace MessengerData.Repositories
{
    class ParticipantRepository : IParticipantRepository
    {
        MessengerDbContext dbContext;
        public ParticipantRepository(MessengerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(IEntity participant)
        {
            var _participant = participant as Participant;
            var result = from temp in dbContext.Participants
                         where temp.ChatId == _participant.ChatId && temp.UserId == _participant.UserId
                         select temp;
            if(result.Count() == 0)
            {
                dbContext.Participants.Add(_participant);
            }
        }

        public void Delete(int id)
        {
            var participant = dbContext.Participants.Find(id);
            if (participant != null)
            {
                dbContext.Participants.Remove(participant);
            }
        }

        public IEntity Read(int id)
        {
            var participant = dbContext.Participants.Find(id);
            return participant;
        }

        public void Update(IEntity participant)
        {
            var result = dbContext.Participants.Find(participant.Id);
            if (result != null)
            {
                dbContext.Participants.Update(participant as Participant);
            }

        }
    }
}
