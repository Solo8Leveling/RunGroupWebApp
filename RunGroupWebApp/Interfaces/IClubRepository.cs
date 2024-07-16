using RunGroupWebApp.Models;

namespace RunGroupWebApp.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();   //IEnumerable tipinde yazilib cunki toplu melumat elde edeceyik
        Task<Club> GetByIdAsync(int id);    //sadece Club yazb cunki bir verilen dondurecek        
        Task<Club> GetByIdAsyncNoTracking(int id);
        Task<IEnumerable<Club>> GetClubByCity(string city);
        bool Add(Club club);
        bool Update(Club club);
        bool Delete(Club club);
        bool Save();
    }
}
