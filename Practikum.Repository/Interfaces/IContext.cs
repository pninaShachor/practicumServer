
using Microsoft.EntityFrameworkCore;
using Practikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practikum.Repositories.Interfaces
{
    public interface IContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Child> Children { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
