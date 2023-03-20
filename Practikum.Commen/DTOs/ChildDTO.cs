
using Practikum.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practikum.Commen.DTOs
{
    public class ChildDTO
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string IdentityN { get; set; }
        public DateTime BornDate { get; set; }
    }
}
