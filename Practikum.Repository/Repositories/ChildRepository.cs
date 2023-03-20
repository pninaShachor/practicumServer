using Microsoft.EntityFrameworkCore;
using Practikum.Repositories.Entities;
using Practikum.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Repositories.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(int id,string fName, string identityN, DateTime bornDate)
        {
            var r = _context.Children.Add(new Child {Id=id, FName = fName, IdentityN = identityN, BornDate = bornDate });
            await _context.SaveChangesAsync();
            return r.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Children.Remove(_context.Children.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.Children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var c1 = _context.Children.Find(child.Id);
            c1.FName = child.FName;
            c1.BornDate = child.BornDate;
            c1.IdentityN = child.IdentityN;
            await _context.SaveChangesAsync();
            return c1;
        }
    }
}
