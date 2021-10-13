using Application.Dto;
using Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IRecuestApplication
    {
        Task<Response<bool>> Add(RecuestDto recuestDto);
        Task<Response<bool>> Update(RecuestDto recuestDto);
        Task<Response<bool>> Delete(int id);
        Task<Response<RecuestDto>> Get(int id);
        Task<Response<IEnumerable<RecuestDto>>> GetAll();
    }
}
