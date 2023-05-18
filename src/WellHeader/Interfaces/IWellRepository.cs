using WellHeader.Entities;

namespace WellHeader.Interfaces
{
    public interface IWellRepository
    {
        IEnumerable<Well> GetAll();
        Well GetById(int id);
        Well Create(Well entity);
        void Update(Well entity);
        void Delete(Well entity);
    }

}
