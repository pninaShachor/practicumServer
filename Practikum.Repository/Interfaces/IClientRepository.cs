using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Practikum.Repositories.Entities;

namespace Practikum.Repositories.Interfaces
{
    public interface IClientRepository
    {
        public Task<List<Client>> GetAllAsync();
        public Task<Client> GetByIdAsync(int id);
        public Task<Client> AddAsync(int id,string fName,string lName,string identityN, DateTime bornDate, string mOrF, string HMO, List<Child>children);
        public Task<Client> UpdateAsync(Client client);
        public Task DeleteAsync(int id);
        
    }
}
