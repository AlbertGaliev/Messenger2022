using MessengerData.EF;
using MessengerData.Repositories.Interfaces;
using System;

namespace MessengerData.Repositories.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private readonly MessengerDbContext dbContext = new MessengerDbContext();
        private IUserRepository userRepository;
        private IUserStatusRepository userStatusRepository;
        private IChatRepository chatRepository;
        private IParticipantRepository participantRepository;
        private IMessageRepository messageRepository;
        private IAttachmentRepository attachmentRepository;

        public IUserRepository Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(dbContext);
                }
                return userRepository;
            }
        }
        public IUserStatusRepository UserStatuses
        {
            get
            {
                if (userStatusRepository == null)
                {
                    userStatusRepository = new UserStatusRepository(dbContext);
                }
                return userStatusRepository;
            }
        }
        public IChatRepository Chats
        {
            get
            {
                if (chatRepository == null)
                {
                    chatRepository = new ChatRepository(dbContext);
                }
                return chatRepository;
            }
        }
        public IParticipantRepository Participants
        {
            get
            {
                if (participantRepository == null)
                {
                    participantRepository = new ParticipantRepository(dbContext);
                }
                return participantRepository;
            }
        }
        public IMessageRepository Messages
        {
            get
            {
                if (messageRepository == null)
                {
                    messageRepository = new MessageRepository(dbContext);
                }
                return messageRepository;
            }
        }
        public IAttachmentRepository Attachments
        {
            get
            {
                if (attachmentRepository == null)
                {
                    attachmentRepository = new AttachmentRepository(dbContext);
                }
                return attachmentRepository;
            }
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}

