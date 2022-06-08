using MessengerData.Entities.Interfaces;
namespace MessengerData.Repositories.Interfaces
{
    public interface IAttachmentRepository
    {
        void Create(IEntity attachment);
        IEntity Read(int id);
        void Update(IEntity attachment);
        void Delete(int id);

    }
}
