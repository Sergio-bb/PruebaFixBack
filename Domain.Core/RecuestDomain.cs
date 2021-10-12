using Domain.Interfase;
using Entity;
using IRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Core
{
    public class RecuestDomain : IRecuestDomain
    {
        private readonly IRecuestRepository _recuestRepository;
        public RecuestDomain(IRecuestRepository recuestRepository)
        {
            _recuestRepository = recuestRepository;
        }
        public async Task<bool> Add(Recuest airline)
        {
            try
            {
                await _recuestRepository.AddAsync(airline);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var prop = _recuestRepository.GetByIdAsync(id);
                await _recuestRepository.DeleteAsync(prop.Result);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<Recuest> Get(int id)
        {
            return await _recuestRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Recuest>> GetAlls()
        {
            return await _recuestRepository.GetAllAsync();
        }

        public async Task<bool> Update(Recuest Recuest)
        {
            try
            {
                await _recuestRepository.UpdateAsync(Recuest);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
