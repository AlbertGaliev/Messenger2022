using MessengerData.Entities.Interfaces;
namespace MessengerData.Repositories.Interfaces
{
    public interface IChatRepository
    {
        void Create(IEntity chat);
        IEntity Read(int id);
        void Update(IEntity chat);
        void Delete(int id);

    }
}
