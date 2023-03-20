
using Practikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Repositories.Interfaces
{
    public interface IChildRepository
    {
        public Task<List<Child>> GetAllAsync();

        public Task<Child> GetByIdAsync(int id);

        public Task<Child> AddAsync(int id,string fName, string identityN, DateTime bornDate);

        public Task<Child> UpdateAsync(Child child);

        public Task DeleteAsync(int id);
    }
}
