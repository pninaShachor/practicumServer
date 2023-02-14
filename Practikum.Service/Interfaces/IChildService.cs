
using Practikum.Commen.DTOs;
using Practikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Services.Interfaces
{
    public interface IChildService
    {
        public Task<List<ChildDTO>> GetAllAsync();

        public Task<ChildDTO> GetByIdAsync(int id);

        public Task<ChildDTO> AddAsync(int id,string fName, string identityN, DateTime bornDate);

        public Task<ChildDTO> UpdateAsync(ChildDTO child);

        public Task DeleteAsync(int id);
    }
}
