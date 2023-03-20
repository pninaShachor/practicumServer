using AutoMapper;
using Practikum.Commen.DTOs;
using Practikum.Repositories.Entities;
using Practikum.Repositories.Interfaces;
using Practikum.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using EMorF = Practikum.Commen.DTOs.EMorF;
//(Repositories.Entities.EMorF)
namespace Practikum.Services.Services
{
    public class ClientService:IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;
        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }
        public async Task<ClientDTO> AddAsync(int id,string fName, string lName, string identityN, DateTime bornDate, string mOrF, string HMO, List<Child>children)
        {
            return _mapper.Map<ClientDTO>(await _clientRepository.AddAsync(id,fName,lName, identityN, bornDate, mOrF,HMO, children));
        }

        public async Task DeleteAsync(int id)
        {
            await _clientRepository.DeleteAsync(id);
        }

        public async Task<List<ClientDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ClientDTO>>(await _clientRepository.GetAllAsync());
        }

        public async Task<ClientDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ClientDTO>(await _clientRepository.GetByIdAsync(id));
        }

        public async Task<ClientDTO> UpdateAsync(ClientDTO client)
        {
            return _mapper.Map<ClientDTO>(await _clientRepository.UpdateAsync(_mapper.Map<Client>(client)));
        }
    }
}
