using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Practikum.Repositories.Interfaces;
using Practikum.Services.Interfaces;
using Practikum.Commen.DTOs;
using Practikum.Repositories.Entities;

namespace Practikum.Services.Services
{
    public class ChildService:IChildService
    {
        private readonly IChildRepository _childRepository;
        private readonly IMapper _mapper;
        public ChildService(IChildRepository childRepository, IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }
        public async Task<ChildDTO> AddAsync(int id,string fName, string identityN, DateTime bornDate)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync(id,fName, identityN, bornDate));
        }

        public async Task DeleteAsync(int id)
        {
            await _childRepository.DeleteAsync(id);
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetByIdAsync(id));
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(_mapper.Map<Child>(child)));
        }
    }
}
