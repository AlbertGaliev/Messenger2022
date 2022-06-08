using MessengerData.Entities.Interfaces;
namespace MessengerData.Repositories.Interfaces
{
    public interface IMessageRepository
    {
        void Create(IEntity message);
        IEntity Read(int id);
        void Update(IEntity message);
        void Delete(int id);

    }
}
