
using Practikum.Commen.DTOs;
using Practikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Services.Interfaces
{
    public interface IClientService
    {
        public Task<List<ClientDTO>> GetAllAsync();
        public Task<ClientDTO> GetByIdAsync(int id);
        public Task<ClientDTO> AddAsync(int id,string fName, string lName, string identityN, DateTime bornDate, string mOrF, string HMO, List<Child>children);
        public Task<ClientDTO> UpdateAsync(ClientDTO client);
        public Task DeleteAsync(int id);
    }
}
