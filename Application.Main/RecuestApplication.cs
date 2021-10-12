using Application.Dto;
using Application.Interface;
using AutoMapper;
using Common;
using Domain.Interfase;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Main
{
    public class RecuestApplication : IRecuestApplication
    {
        private readonly IRecuestDomain _recuestDomain;
        private readonly IMapper _mapper;
        public RecuestApplication(IRecuestDomain recuestDomain, IMapper mapper)
        {
            _recuestDomain = recuestDomain;
            _mapper = mapper;
        }

        public async Task<Response<bool>> Add(RecuestDto RecuestDto)
        {
            var response = new Response<bool>();
            if (DataVAlidation(RecuestDto))
            {
                try
                {
                    var recuest = _mapper.Map<Recuest>(RecuestDto);
                    response.Data = await _recuestDomain.Add(recuest);
                    if (response.Data)
                    {
                        response.IsSuccess = true;
                        response.Message = "Successful registration!!!";
                    }
                }
                catch (Exception e)
                {
                    response.Message = e.Message;
                }
                return response;
            }
            else
            {
                response.Message = "House isn't avaliable";
                return response;
            }
        }

        public async Task<Response<bool>> Delete(int id)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _recuestDomain.Delete(id);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Successful removal!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<RecuestDto>> Get(int id)
        {
            var response = new Response<RecuestDto>();
            try
            {
                var recuest = await _recuestDomain.Get(id);
                response.Data = _mapper.Map<RecuestDto>(recuest);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Successful consultation!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<IEnumerable<RecuestDto>>> GetAll()
        {
            var response = new Response<IEnumerable<RecuestDto>>();
            try
            {
                var recuest = await _recuestDomain.GetAlls();
                response.Data = _mapper.Map<IEnumerable<RecuestDto>>(recuest);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Successful consultation!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<bool>> Update(RecuestDto RecuestDto)
        {
            var response = new Response<bool>();
            if (DataVAlidation(RecuestDto))
            {
                try
                {
                    var recuest = _mapper.Map<Recuest>(RecuestDto);
                    response.Data = await _recuestDomain.Update(recuest);
                    if (response.Data)
                    {
                        response.IsSuccess = true;
                        response.Message = "Successful update!!!";
                    }
                }
                catch (Exception e)
                {
                    response.Message = e.Message;
                }
                return response;

            }
            else
            {
                response.Message = "House isn't avaliable";
                return response;
            }
        }
        private bool DataVAlidation(RecuestDto recuest)
        {
            if(recuest.House == "Gryffindor" ||
                recuest.House == "Hufflepuff" ||
                recuest.House == "Ravenclaw" || 
                recuest.House == "Slytherin")
            {
                return true;
            }
            else
            {
                return false;
            }           
        }
    }
}
