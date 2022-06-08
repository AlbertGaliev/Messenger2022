using MessengerData.Entities.Interfaces;
namespace MessengerData.Repositories.Interfaces
{
    public interface IParticipantRepository
    {
        void Create(IEntity participant);
        IEntity Read(int id);
        void Update(IEntity participant);
        void Delete(int id);

    }
}
