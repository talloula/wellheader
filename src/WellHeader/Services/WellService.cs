using Microsoft.EntityFrameworkCore;
using WellHeader.Interfaces;

namespace WellHeader.Services
{
    public class WellService : IWellService
    {
        private readonly IWellRepository _repository;
        
        public bool hasErrors = false;


        public WellService(IWellRepository repository) 
        {
            if(repository == null) throw new ArgumentNullException(nameof(repository));
            _repository = repository;
        }

        protected bool ValidateWell(Well wellToValidate) 
        {
            if ( (wellToValidate == null)   //null Well object
                || (wellToValidate.WellName == null)   //null string
                || (wellToValidate.WellName.Trim().Length == 0) ) //empty string or spaces
                {
                    hasErrors = true;
                    return false; //validation failed
                }
            return true;
        }
        public bool CreateWell(Well wellToCreate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Well> ListWells()
        {
            return _repository.GetAll().ToList();
        }

        public Well GetWellByID(int wellID)
        {
            return _repository.GetById(wellID);
        }
    }


}
