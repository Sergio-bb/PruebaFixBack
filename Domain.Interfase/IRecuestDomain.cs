using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfase
{
    public interface IRecuestDomain
    {
        Task<bool> Add(Recuest Recuest);
        Task<bool> Update(Recuest Recuest);
        Task<bool> Delete(int id);
        Task<Recuest> Get(int id);
        public Task<IEnumerable<Recuest>> GetAlls();

    }
}
