namespace WellHeader.Interfaces
{
    public interface IWellService
    {
        
        bool CreateWell(Well wellToCreate);
        IEnumerable<Well> ListWells();
        Well GetWellByID(int wellID);   
    }
}
