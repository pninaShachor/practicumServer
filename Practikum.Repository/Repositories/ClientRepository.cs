using Microsoft.EntityFrameworkCore;
using Practikum.Repositories.Entities;
using Practikum.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Repositories.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IContext _context;
        public ClientRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Client> AddAsync(int id,string fName, string lName, string identityN, DateTime bornDate, string mOrF, string HMO, List<Child>children)
        {
            var r = _context.Clients.Add(new Client {Id=id,FName=fName,LName=lName,IdentityN=identityN,BornDate=bornDate,MorF=mOrF,HMO=HMO,Children=children});
            await _context.SaveChangesAsync();
            return r.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Clients.Remove(_context.Clients.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Client>> GetAllAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetByIdAsync(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task<Client> UpdateAsync(Client client)
        {
            var c1 = _context.Clients.Find(client.Id);
            c1.FName = client.FName;
            c1.LName = client.LName;
            c1.IdentityN = client.IdentityN;    
            c1.BornDate = client.BornDate;
            c1.MorF = client.MorF;
            c1.HMO = client.HMO;
            c1.Children = client.Children;
            await _context.SaveChangesAsync();
            return c1;
        }
    }
}
