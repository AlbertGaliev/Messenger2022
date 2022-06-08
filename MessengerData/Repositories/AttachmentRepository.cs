using MessengerData.Entities;
using MessengerData.EF;
using MessengerData.Repositories.Interfaces;
using MessengerData.Entities.Interfaces;

namespace MessengerData.Repositories
{
    class AttachmentRepository : IAttachmentRepository
    {
        MessengerDbContext dbContext;
        public AttachmentRepository(MessengerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(IEntity attachment)
        {
            dbContext.Attachments.Add(attachment as Attachment);
        }

        public void Delete(int id)
        {
            var attachment = dbContext.Attachments.Find(id);
            if (attachment != null)
            {
                dbContext.Attachments.Remove(attachment);
            }
        }

        public IEntity Read(int id)
        {
            var attachment = dbContext.Attachments.Find(id);
            return attachment;
        }

        public void Update(IEntity attachment)
        {
            var result = dbContext.Attachments.Find(attachment.Id);
            if (result != null)
            {
                dbContext.Attachments.Update(attachment as Attachment);
            }
        }
    }
}
