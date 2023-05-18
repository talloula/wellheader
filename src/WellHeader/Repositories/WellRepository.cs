using System.Linq;
using WellHeader.DAL;
using WellHeader.Models;
using WellHeader.Entities;
using WellHeader.Interfaces;
using System.Collections.Generic;

namespace WellHeader.Repositories
{
    public class WellRepository : IWellRepository 
    {
        private readonly WellheaderDbContext _context;       
        public WellRepository(WellheaderDbContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        public Well Create(Well entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Well entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Well> GetAll()
        {
            return _context.Wells.ToList();
        }

        public Well GetById(int id)
        {
            return _context.Set<Well>().Find(id);
            //throw new NotImplementedException();
        }

        public void Update(Well entity)
        {
            throw new NotImplementedException();
        }

        //public Well Get(Guid WellID)
        //{
        //    return _context.Set<Well>().Find(WellID);
        //}
    }
}
