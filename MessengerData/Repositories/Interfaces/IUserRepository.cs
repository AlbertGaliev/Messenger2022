using MessengerData.Entities.Interfaces;
namespace MessengerData.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Create(IEntity user);
        IEntity Read(int id);
        void Update(IEntity user);
        void Delete(int id);
    }
}
