using AnimalsRegistre.Models;

namespace AnimalsRegistre.Services
{
    public interface IAnimalsRepository : IRepository<Animals,int>

    {
        int Delete(int animalId);
    }
}
